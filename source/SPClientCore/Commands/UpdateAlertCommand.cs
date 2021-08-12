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

    [Cmdlet("Update", "KshAlert")]
    [OutputType(typeof(Alert))]
    public class UpdateAlertCommand : ClientObjectCmdlet<IAlertService>
    {

        public UpdateAlertCommand()
        {
        }

        [Parameter(Mandatory = true, Position = 0, ValueFromPipeline = true)]
        public Alert Identity { get; private set; }

        [Parameter(Mandatory = false)]
        public AlertFrequency AlertFrequency { get; private set; }

        [Parameter(Mandatory = false)]
        public DateTime AlertTime { get; private set; }

        [Parameter(Mandatory = false)]
        public bool AlwaysNotify { get; private set; }

        [Parameter(Mandatory = false)]
        public AlertDeliveryChannel DeliveryChannels { get; private set; }

        [Parameter(Mandatory = false)]
        public AlertEventType EventType { get; private set; }

        [Parameter(Mandatory = false)]
        public string Filter { get; private set; }

        [Parameter(Mandatory = false)]
        public AlertStatus Status { get; private set; }

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
