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

    [Cmdlet("New", "KshSubscription")]
    [OutputType(typeof(Subscription))]
    public class NewSubscriptionCommand : ClientObjectCmdlet<ISubscriptionService>
    {

        public NewSubscriptionCommand()
        {
        }

        [Parameter(Mandatory = true, Position = 0, ValueFromPipeline = true)]
        public List List { get; private set; }

        [Parameter(Mandatory = false)]
        public string ClientState { get; private set; }

        [Parameter(Mandatory = true)]
        public DateTime ExpirationDateTime { get; private set; }

        [Parameter(Mandatory = true)]
        public string NotificationUrl { get; private set; }

        protected override void ProcessRecordCore()
        {
            this.WriteObject(this.Service.CreateObject(this.List, this.MyInvocation.BoundParameters));
        }

    }

}
