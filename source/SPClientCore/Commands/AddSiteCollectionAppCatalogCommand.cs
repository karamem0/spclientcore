//
// Copyright (c) 2021 karamem0
//
// This software is released under the MIT License.
//
// https://github.com/karamem0/spclientcore/blob/master/LICENSE
//

using Karamem0.SharePoint.PowerShell.Models;
using Karamem0.SharePoint.PowerShell.Resources;
using Karamem0.SharePoint.PowerShell.Runtime.Commands;
using Karamem0.SharePoint.PowerShell.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;

namespace Karamem0.SharePoint.PowerShell.Commands
{

    [Cmdlet("Add", "KshSiteCollectionAppCatalog")]
    [OutputType(typeof(void))]
    public class AddSiteCollectionAppCatalogCommand : ClientObjectCmdlet<ISiteCollectionAppCatalogService>
    {

        public AddSiteCollectionAppCatalogCommand()
        {
        }

        [Parameter(Mandatory = true, ParameterSetName = "ParamSet1")]
        public SiteCollection SiteCollection { get; private set; }

        [Parameter(Mandatory = true, ParameterSetName = "ParamSet2")]
        public TenantSiteCollection TenantSiteCollection { get; private set; }

        [Parameter(Mandatory = true, ParameterSetName = "ParamSet3")]
        public Uri SiteCollectionUrl { get; private set; }

        protected override void ProcessRecordCore()
        {
            if (this.ParameterSetName == "ParamSet1")
            {
                this.Service.AddObject(new Uri(this.SiteCollection.Url, UriKind.Absolute));
            }
            if (this.ParameterSetName == "ParamSet2")
            {
                this.Service.AddObject(new Uri(this.TenantSiteCollection.Url, UriKind.Absolute));
            }
            if (this.ParameterSetName == "ParamSet3")
            {
                if (this.SiteCollectionUrl.IsAbsoluteUri)
                {
                    this.Service.AddObject(this.SiteCollectionUrl);
                }
                else
                {
                    throw new ArgumentException(
                        string.Format(StringResources.ErrorValueIsNotAbsoluteUrl, this.SiteCollectionUrl),
                        nameof(this.SiteCollectionUrl));
                }
            }
        }

    }

}
