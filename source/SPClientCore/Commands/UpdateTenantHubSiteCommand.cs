//
// Copyright (c) 2021 karamem0
//
// This software is released under the MIT License.
//
// https://github.com/karamem0/spclientcore/blob/master/LICENSE
//

using Karamem0.SharePoint.PowerShell.Models;
using Karamem0.SharePoint.PowerShell.Runtime.Commands;
using Karamem0.SharePoint.PowerShell.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;

namespace Karamem0.SharePoint.PowerShell.Commands
{

    [Cmdlet("Update", "KshTenantHubSite")]
    [OutputType(typeof(HubSite))]
    public class UpdateTenantHubSiteCommand : ClientObjectCmdlet<ITenantHubSiteService>
    {

        public UpdateTenantHubSiteCommand()
        {
        }

        [Parameter(Mandatory = true, Position = 0, ValueFromPipeline = true)]
        public HubSite Identity { get; private set; }

        [Parameter(Mandatory = false)]
        public string Description { get; private set; }

        [Parameter(Mandatory = false)]
        public bool EnablePermissionsSync { get; private set; }

        [Parameter(Mandatory = false)]
        public bool HideNameInNavigation { get; private set; }

        [Parameter(Mandatory = false)]
        public string LogoUrl { get; private set; }

        [Parameter(Mandatory = false)]
        public Guid ParentHubSiteId { get; private set; }

        [Parameter(Mandatory = false)]
        public string Title { get; private set; }

        [Parameter(Mandatory = false)]
        public SwitchParameter PassThru { get; private set; }

        protected override void ProcessRecordCore()
        {
            this.Service.UpdateObject(this.Identity, this.MyInvocation.BoundParameters);
            var clientObject = this.Service.GetObject(this.Identity.SiteCollectionUrl);
            if (this.PassThru)
            {
                this.WriteObject(clientObject);
            }
        }

    }

}
