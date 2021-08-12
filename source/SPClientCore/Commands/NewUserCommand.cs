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

    [Cmdlet("New", "KshUser")]
    [OutputType(typeof(User))]
    public class NewUserCommand : ClientObjectCmdlet<IUserService>
    {

        public NewUserCommand()
        {
        }

        [Parameter(Mandatory = false)]
        public string Email { get; private set; }

        [Parameter(Mandatory = true)]
        public string LoginName { get; private set; }

        [Parameter(Mandatory = false)]
        public string Title { get; private set; }

        protected override void ProcessRecordCore()
        {
            this.WriteObject(this.Service.CreateObject(this.MyInvocation.BoundParameters));
        }

    }

}
