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

    [Cmdlet("Set", "KshUniqueRoleAssignmentEnabled")]
    [OutputType(typeof(void))]
    public class SetUniqueRoleAssignmentEnabledCommand : ClientObjectCmdlet<ISiteService, IRoleAssignmentService>
    {

        public SetUniqueRoleAssignmentEnabledCommand()
        {
        }

        [Parameter(Mandatory = true, Position = 0, ParameterSetName = "ParamSet1")]
        [Parameter(Mandatory = true, Position = 0, ParameterSetName = "ParamSet2")]
        public SwitchParameter Site { get; private set; }

        [Parameter(Mandatory = true, Position = 0, ParameterSetName = "ParamSet3")]
        [Parameter(Mandatory = true, Position = 0, ParameterSetName = "ParamSet4")]
        public List List { get; private set; }

        [Parameter(Mandatory = true, Position = 0, ParameterSetName = "ParamSet5")]
        [Parameter(Mandatory = true, Position = 0, ParameterSetName = "ParamSet6")]
        public ListItem ListItem { get; private set; }

        [Parameter(Mandatory = true, ParameterSetName = "ParamSet1")]
        [Parameter(Mandatory = true, ParameterSetName = "ParamSet3")]
        [Parameter(Mandatory = true, ParameterSetName = "ParamSet5")]
        public SwitchParameter Enabled { get; private set; }

        [Parameter(Mandatory = false, ParameterSetName = "ParamSet1")]
        [Parameter(Mandatory = false, ParameterSetName = "ParamSet3")]
        [Parameter(Mandatory = false, ParameterSetName = "ParamSet5")]
        public SwitchParameter CopyRoleAssignments { get; private set; }

        [Parameter(Mandatory = false, ParameterSetName = "ParamSet1")]
        [Parameter(Mandatory = false, ParameterSetName = "ParamSet3")]
        [Parameter(Mandatory = false, ParameterSetName = "ParamSet5")]
        public SwitchParameter ClearSubscopes { get; private set; }

        [Parameter(Mandatory = true, ParameterSetName = "ParamSet2")]
        [Parameter(Mandatory = true, ParameterSetName = "ParamSet4")]
        [Parameter(Mandatory = true, ParameterSetName = "ParamSet6")]
        public SwitchParameter Disabled { get; private set; }

        protected override void ProcessRecordCore()
        {
            if (this.ParameterSetName == "ParamSet1")
            {
                this.ValidateSwitchParameter(nameof(this.Site));
                this.ValidateSwitchParameter(nameof(this.Enabled));
                this.Service2.BreakObjectInheritance(this.Service1.GetObject(), this.CopyRoleAssignments, this.ClearSubscopes);
            }
            if (this.ParameterSetName == "ParamSet2")
            {
                this.ValidateSwitchParameter(nameof(this.Site));
                this.ValidateSwitchParameter(nameof(this.Disabled));
                this.Service2.ResetObjectInheritance(this.Service1.GetObject());
            }
            if (this.ParameterSetName == "ParamSet3")
            {
                this.ValidateSwitchParameter(nameof(this.Enabled));
                this.Service2.BreakObjectInheritance(this.List, this.CopyRoleAssignments, this.ClearSubscopes);
            }
            if (this.ParameterSetName == "ParamSet4")
            {
                this.ValidateSwitchParameter(nameof(this.Disabled));
                this.Service2.ResetObjectInheritance(this.List);
            }
            if (this.ParameterSetName == "ParamSet5")
            {
                this.ValidateSwitchParameter(nameof(this.Enabled));
                this.Service2.BreakObjectInheritance(this.ListItem, this.CopyRoleAssignments, this.ClearSubscopes);
            }
            if (this.ParameterSetName == "ParamSet6")
            {
                this.ValidateSwitchParameter(nameof(this.Disabled));
                this.Service2.ResetObjectInheritance(this.ListItem);
            }
        }

    }

}
