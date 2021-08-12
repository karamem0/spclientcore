//
// Copyright (c) 2021 karamem0
//
// This software is released under the MIT License.
//
// https://github.com/karamem0/spclientcore/blob/master/LICENSE
//

using Karamem0.SharePoint.PowerShell.Models;
using Karamem0.SharePoint.PowerShell.Runtime.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;

namespace Karamem0.SharePoint.PowerShell.Commands
{

    [Cmdlet("Initialize", "KshBasePermission")]
    [OutputType(typeof(BasePermission))]
    public class InitializeBasePermissionCommand : ClientObjectCmdlet
    {

        public InitializeBasePermissionCommand()
        {
        }

        [Parameter(Mandatory = true, Position = 0)]
        public PermissionKind[] Permission { get; private set; }

        protected override void ProcessRecordCore()
        {
            this.WriteObject(new BasePermission(this.Permission));
        }

    }

}
