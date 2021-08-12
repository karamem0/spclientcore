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

    [Cmdlet("New", "KshTenantHubSite")]
    [OutputType(typeof(HubSite))]
    public class NewTenantHubSiteCommand : ClientObjectCmdlet<ITenantHubSiteService>
    {

        public NewTenantHubSiteCommand()
        {
        }

        [Parameter(Mandatory = false)]
        public string Description { get; private set; }

        [Parameter(Mandatory = false)]
        public bool EnablePermissionsSync { get; private set; }

        [Parameter(Mandatory = false)]
        public bool HideNameInNavigation { get; private set; }

        [Parameter(Mandatory = false)]
        public string LogoUrl { get; private set; }

        [Parameter(Mandatory = true)]
        public Guid SiteCollectionId { get; private set; }

        [Parameter(Mandatory = true)]
        public string SiteCollectionUrl { get; private set; }

        [Parameter(Mandatory = true)]
        public string Title { get; private set; }

        protected override void ProcessRecordCore()
        {
            this.WriteObject(this.Service.CreateObject(this.SiteCollectionUrl, this.MyInvocation.BoundParameters));
        }

    }

}
