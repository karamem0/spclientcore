//
// Copyright (c) 2021 karamem0
//
// This software is released under the MIT License.
//
// https://github.com/karamem0/spclientcore/blob/master/LICENSE
//

using Karamem0.SharePoint.PowerShell.Runtime.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;

namespace Karamem0.SharePoint.PowerShell.Runtime.OAuth
{

    public class AcsOAuthContext : OAuthContext
    {

        private readonly string clientId;

        private readonly string clientSecret;

        private readonly string resource;

        private readonly TenantIdResolver tenantIdResolver;

        public AcsOAuthContext(string clientId, string clientSecret, string resource)
        {
            this.clientId = clientId;
            this.clientSecret = clientSecret;
            this.resource = resource;
            this.tenantIdResolver = new TenantIdResolver(this.HttpClient, new Uri(this.resource, UriKind.Absolute));
        }

        public OAuthMessage AcquireToken()
        {
            var tenantId = this.tenantIdResolver.Resolve();
            var resourceId = new Uri(this.resource, UriKind.Absolute).Host;
            var requestUrl = new Uri(OAuthConstants.AcsAuthority, UriKind.Absolute)
                .ConcatPath(tenantId)
                .ConcatPath("tokens/oauth/2");
            var requertParameters = new Dictionary<string, object>()
            {
                { "grant_type", "client_credentials" },
                { "client_id", $"{this.clientId}@{tenantId}" },
                { "client_secret", this.clientSecret },
                { "resource", $"{OAuthConstants.ResourceId}/{resourceId}@{tenantId}" }
            };
            var requestContent = UriQuery.Create(requertParameters);
            var requestMessage = new HttpRequestMessage(HttpMethod.Post, requestUrl);
            requestMessage.Content = new StringContent(requestContent, Encoding.UTF8, "application/x-www-form-urlencoded");
            requestMessage.Headers.Add("Accept", "application/json");
            var responseMessage = this.HttpClient.SendAsync(requestMessage).GetAwaiter().GetResult();
            var responseContent = responseMessage.Content.ReadAsStringAsync().GetAwaiter().GetResult();
            if (responseMessage.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<AcsOAuthToken>(responseContent);
            }
            else
            {
                return JsonConvert.DeserializeObject<OAuthError>(responseContent);
            }
        }

    }

}
