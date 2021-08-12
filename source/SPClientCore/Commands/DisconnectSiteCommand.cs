//
// Copyright (c) 2021 karamem0
//
// This software is released under the MIT License.
//
// https://github.com/karamem0/spclientcore/blob/master/LICENSE
//

using Karamem0.SharePoint.PowerShell.Resources;
using Karamem0.SharePoint.PowerShell.Runtime.Commands;
using Karamem0.SharePoint.PowerShell.Runtime.Common;
using Karamem0.SharePoint.PowerShell.Runtime.OAuth;
using Karamem0.SharePoint.PowerShell.Runtime.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.JsonWebTokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;

namespace Karamem0.SharePoint.PowerShell.Commands
{

    [Cmdlet("Disconnect", "KshSite")]
    [OutputType(typeof(void))]
    public class DisconnectSiteCommand : ClientObjectCmdlet
    {

        public DisconnectSiteCommand()
        {
        }

        [Parameter(Mandatory = false, Position = 0, ValueFromPipeline = true)]
        public Uri Url { get; private set; }

        protected override void ProcessRecordCore()
        {
            if (this.Url == null)
            {
                if (ClientService.ServiceProvider == null)
                {
                    throw new InvalidOperationException(StringResources.ErrorNotConnected);
                }
                var clientContext = ClientService.ServiceProvider.GetService<ClientContext>();
                var accessToken = clientContext.AccessToken;
                var jwtToken = new JsonWebToken(accessToken);
                var jwtAudience = jwtToken.GetPayloadValue<string>("aud");
                if (Uri.TryCreate(jwtAudience, UriKind.Absolute, out var url))
                {
                    AadOAuthTokenStore.Remove(url.GetAuthority());
                }
                ClientService.Unregister();
            }
            else
            {
                AadOAuthTokenStore.Remove(this.Url.GetAuthority());
            }
        }

    }

}
