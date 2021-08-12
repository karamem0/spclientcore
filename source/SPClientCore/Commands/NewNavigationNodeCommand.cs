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

    [Cmdlet("New", "KshNavigationNode")]
    [OutputType(typeof(NavigationNode))]
    public class NewNavigationNodeCommand : ClientObjectCmdlet<INavigationNodeService>
    {

        public NewNavigationNodeCommand()
        {
        }

        [Parameter(Mandatory = true, Position = 0, ValueFromPipeline = true, ParameterSetName = "ParamSet1")]
        public NavigationNode NavigationNode { get; private set; }

        [Parameter(Mandatory = true, ParameterSetName = "ParamSet2")]
        public SwitchParameter QuickLaunch { get; private set; }

        [Parameter(Mandatory = true, ParameterSetName = "ParamSet3")]
        public SwitchParameter TopNavigationBar { get; private set; }

        [Parameter(Mandatory = false)]
        public bool AsLastNode { get; private set; }

        [Parameter(Mandatory = false)]
        public bool IsExternal { get; private set; }

        [Parameter(Mandatory = false)]
        public NavigationNode PreviousNode { get; private set; }

        [Parameter(Mandatory = false)]
        public string Title { get; private set; }

        [Parameter(Mandatory = false)]
        public string Url { get; private set; }

        protected override void ProcessRecordCore()
        {
            if (this.ParameterSetName == "ParamSet1")
            {
                this.WriteObject(this.Service.CreateObject(this.NavigationNode, this.MyInvocation.BoundParameters));
            }
            if (this.ParameterSetName == "ParamSet2")
            {
                this.WriteObject(this.Service.CreateObjectToQuickLaunch(this.MyInvocation.BoundParameters));
            }
            if (this.ParameterSetName == "ParamSet3")
            {
                this.WriteObject(this.Service.CreateObjectToTopNavigationBar(this.MyInvocation.BoundParameters));
            }
        }

    }

}
