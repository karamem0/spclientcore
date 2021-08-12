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

    [Cmdlet("New", "KshRoleAssignment")]
    [OutputType(typeof(RoleAssignment))]
    public class NewRoleAssignmentCommand : ClientObjectCmdlet<ISiteService, IRoleAssignmentService>
    {

        public NewRoleAssignmentCommand()
        {
        }

        [Parameter(Mandatory = true, Position = 0, ParameterSetName = "ParamSet1")]
        public SwitchParameter Site { get; private set; }

        [Parameter(Mandatory = true, Position = 0, ParameterSetName = "ParamSet2")]
        public List List { get; private set; }

        [Parameter(Mandatory = true, Position = 0, ParameterSetName = "ParamSet3")]
        public ListItem ListItem { get; private set; }

        [Parameter(Mandatory = true, Position = 1, ParameterSetName = "ParamSet1")]
        [Parameter(Mandatory = true, Position = 1, ParameterSetName = "ParamSet2")]
        [Parameter(Mandatory = true, Position = 1, ParameterSetName = "ParamSet3")]
        public Principal Principal { get; private set; }

        [Parameter(Mandatory = true, Position = 2, ParameterSetName = "ParamSet1")]
        [Parameter(Mandatory = true, Position = 2, ParameterSetName = "ParamSet2")]
        [Parameter(Mandatory = true, Position = 2, ParameterSetName = "ParamSet3")]
        public RoleDefinition RoleDefinition { get; private set; }

        protected override void ProcessRecordCore()
        {
            if (this.ParameterSetName == "ParamSet1")
            {
                this.ValidateSwitchParameter(nameof(this.Site));
                this.WriteObject(this.Service2.CreateObject(this.Service1.GetObject(), this.Principal, this.RoleDefinition));
            }
            if (this.ParameterSetName == "ParamSet2")
            {
                this.WriteObject(this.Service2.CreateObject(this.List, this.Principal, this.RoleDefinition));
            }
            if (this.ParameterSetName == "ParamSet3")
            {
                this.WriteObject(this.Service2.CreateObject(this.ListItem, this.Principal, this.RoleDefinition));
            }
        }

    }

}
