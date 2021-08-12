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

    [Cmdlet("Get", "KshSiteTemplate")]
    [OutputType(typeof(SiteTemplate))]
    public class GetSiteTemplateCommand : ClientObjectCmdlet<ISiteService, ISiteTemplateService>
    {

        public GetSiteTemplateCommand()
        {
        }

        [Parameter(Mandatory = true, Position = 0, ParameterSetName = "ParamSet1")]
        public string SiteTemplateName { get; private set; }

        [Parameter(Mandatory = false, Position = 1, ParameterSetName = "ParamSet1")]
        [Parameter(Mandatory = false, ParameterSetName = "ParamSet2")]
        public SwitchParameter IncludeCrossLanguage { get; private set; }

        [Parameter(Mandatory = false, Position = 2, ParameterSetName = "ParamSet1")]
        [Parameter(Mandatory = false, ParameterSetName = "ParamSet2")]
        public uint Lcid { get; private set; }

        [Parameter(Mandatory = false, ParameterSetName = "ParamSet2")]
        public SwitchParameter NoEnumerate { get; private set; }

        protected override void ProcessRecordCore()
        {
            if (this.Lcid == default)
            {
                var site = this.Service1.GetObject();
                if (site != null)
                {
                    this.Lcid = site.Lcid;
                }
            }
            if (this.ParameterSetName == "ParamSet1")
            {
                this.WriteObject(this.Service2.GetObject(this.SiteTemplateName, this.Lcid, this.IncludeCrossLanguage));
            }
            if (this.ParameterSetName == "ParamSet2")
            {
                this.WriteObject(this.Service2.GetObjectEnumerable(this.Lcid, this.IncludeCrossLanguage), this.NoEnumerate ? false : true);
            }
        }

    }

}
