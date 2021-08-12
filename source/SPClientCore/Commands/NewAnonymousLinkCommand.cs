//
// Copyright (c) 2021 karamem0
//
// This software is released under the MIT License.
//
// https://github.com/karamem0/spclientcore/blob/master/LICENSE
//

using Karamem0.SharePoint.PowerShell.Runtime.Commands;
using Karamem0.SharePoint.PowerShell.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;

namespace Karamem0.SharePoint.PowerShell.Commands
{

    [Cmdlet("New", "KshAnonymousLink")]
    [OutputType(typeof(string))]
    public class NewAnonymousLinkCommand : ClientObjectCmdlet<ISharingLinkService>
    {

        public NewAnonymousLinkCommand()
        {
        }

        [Parameter(Mandatory = true, ParameterSetName = "ParamSet1")]
        [Parameter(Mandatory = true, ParameterSetName = "ParamSet2")]
        public string Url { get; private set; }

        [Parameter(Mandatory = true, ParameterSetName = "ParamSet1")]
        [Parameter(Mandatory = true, ParameterSetName = "ParamSet2")]
        public bool IsEditLink { get; private set; }

        [Parameter(Mandatory = true, ParameterSetName = "ParamSet2")]
        public DateTime Expiration { get; private set; }

        protected override void ProcessRecordCore()
        {
            if (this.ParameterSetName == "ParamSet1")
            {
                this.WriteObject(this.Service.CreateAnonymousLink(this.Url, this.IsEditLink));
            }
            if (this.ParameterSetName == "ParamSet2")
            {
                this.WriteObject(this.Service.CreateAnonymousLink(this.Url, this.IsEditLink, this.Expiration));
            }
        }

    }

}
