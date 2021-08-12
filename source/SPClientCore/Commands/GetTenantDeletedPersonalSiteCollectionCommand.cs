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

    [Cmdlet("Get", "KshTenantDeletedPersonalSiteCollection")]
    [OutputType(typeof(TenantDeletedSiteCollection))]
    public class GetTenantDeletedPersonalSiteCollectionCommand : ClientObjectCmdlet<ITenantDeletedPersonalSiteCollectionService>
    {

        public GetTenantDeletedPersonalSiteCollectionCommand()
        {
        }

        [Parameter(Mandatory = true, Position = 0, ParameterSetName = "ParamSet1")]
        public Uri SiteCollectionUrl { get; private set; }

        [Parameter(Mandatory = false, ParameterSetName = "ParamSet1")]
        [Parameter(Mandatory = false, ParameterSetName = "ParamSet2")]
        public SwitchParameter NoEnumerate { get; private set; }

        protected override void ProcessRecordCore()
        {
            if (this.ParameterSetName == "ParamSet1")
            {
                if (this.SiteCollectionUrl.IsAbsoluteUri)
                {
                    this.WriteObject(this.Service.GetObjectEnumerable(this.SiteCollectionUrl), this.NoEnumerate ? false : true);
                }
                else
                {
                    throw new ArgumentException(
                        string.Format(StringResources.ErrorValueIsNotAbsoluteUrl, this.SiteCollectionUrl),
                        nameof(this.SiteCollectionUrl));
                }
            }
            if (this.ParameterSetName == "ParamSet2")
            {
                this.WriteObject(this.Service.GetObjectEnumerable(), this.NoEnumerate ? false : true);
            }
        }

    }

}
