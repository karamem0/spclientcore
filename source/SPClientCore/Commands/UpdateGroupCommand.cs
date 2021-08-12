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

    [Cmdlet("Update", "KshGroup")]
    [OutputType(typeof(Group))]
    public class UpdateGroupCommand : ClientObjectCmdlet<IGroupService>
    {

        public UpdateGroupCommand()
        {
        }

        [Parameter(Mandatory = true, Position = 0, ValueFromPipeline = true)]
        public Group Identity { get; private set; }

        [Parameter(Mandatory = false)]
        public bool AllowMembersEditMembership { get; private set; }

        [Parameter(Mandatory = false)]
        public bool AllowRequestToJoinLeave { get; private set; }

        [Parameter(Mandatory = false)]
        public bool AutoAcceptRequestToJoinLeave { get; private set; }

        [Parameter(Mandatory = false)]
        public string Description { get; private set; }

        [Parameter(Mandatory = false)]
        public bool OnlyAllowMembersViewMembership { get; private set; }

        [Parameter(Mandatory = false)]
        public string RequestToJoinLeaveEmailSetting { get; private set; }

        [Parameter(Mandatory = false)]
        public string Title { get; private set; }

        [Parameter(Mandatory = false)]
        public SwitchParameter PassThru { get; private set; }

        protected override void ProcessRecordCore()
        {
            this.Service.UpdateObject(this.Identity, this.MyInvocation.BoundParameters);
            if (this.PassThru)
            {
                this.WriteObject(this.Service.GetObject(this.Identity));
            }
        }

    }

}
