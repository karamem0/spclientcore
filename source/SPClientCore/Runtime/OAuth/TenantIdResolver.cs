//
// Copyright (c) 2021 karamem0
//
// This software is released under the MIT License.
//
// https://github.com/karamem0/spclientcore/blob/master/LICENSE
//

using Karamem0.SharePoint.PowerShell.Resources;
using Karamem0.SharePoint.PowerShell.Runtime.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;

namespace Karamem0.SharePoint.PowerShell.Runtime.OAuth
{

    public class TenantIdResolver
    {

        private readonly HttpClient httpClient;

        private readonly Uri baseAddress;

        private string tenantId;

        public TenantIdResolver(HttpClient httpClient, Uri baseAddress)
        {
            this.httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
            this.baseAddress = baseAddress ?? throw new ArgumentNullException(nameof(baseAddress));
        }

        public string Resolve()
        {
            if (this.tenantId == null)
            {
                var requestUrl = this.baseAddress.ConcatPath("_vti_bin/client.svc");
                var requestMessage = new HttpRequestMessage(HttpMethod.Post, requestUrl);
                requestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer");
                var responseMessage = this.httpClient.SendAsync(requestMessage).GetAwaiter().GetResult();
                var authHeaderValue = responseMessage.Headers.WwwAuthenticate.FirstOrDefault();
                if (authHeaderValue != null)
                {
                    var authRealm = Regex.Match(authHeaderValue.Parameter, "realm=\"(.+?)\"");
                    if (authRealm.Success)
                    {
                        this.tenantId = authRealm.Groups[1].Value;
                    }
                }
            }
            if (this.tenantId == null)
            {
                throw new InvalidOperationException(StringResources.ErrorCannotResolveTenantId);
            }
            return this.tenantId;
        }

    }

}
