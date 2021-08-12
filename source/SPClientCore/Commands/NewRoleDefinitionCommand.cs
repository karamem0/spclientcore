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

    [Cmdlet("New", "KshRoleDefinition")]
    [OutputType(typeof(RoleDefinition))]
    public class NewRoleDefinitionCommand : ClientObjectCmdlet<IRoleDefinitionService>
    {

        public NewRoleDefinitionCommand()
        {
        }

        [Parameter(Mandatory = false)]
        public BasePermission BasePermission { get; private set; }

        [Parameter(Mandatory = false)]
        public string Description { get; private set; }

        [Parameter(Mandatory = true)]
        public string Name { get; private set; }

        [Parameter(Mandatory = false)]
        public int Order { get; private set; }

        protected override void ProcessRecordCore()
        {
            this.WriteObject(this.Service.CreateObject(this.MyInvocation.BoundParameters));
        }

    }

}
