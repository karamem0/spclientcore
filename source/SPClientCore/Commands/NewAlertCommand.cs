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

    [Cmdlet("New", "KshAlert")]
    [OutputType(typeof(Alert))]
    public class NewAlertCommand : ClientObjectCmdlet<IAlertService>
    {

        public NewAlertCommand()
        {
        }

        [Parameter(Mandatory = false)]
        public AlertFrequency AlertFrequency { get; private set; }

        [Parameter(Mandatory = false)]
        public string AlertTemplateName { get; private set; }

        [Parameter(Mandatory = false)]
        public DateTime AlertTime { get; private set; }

        [Parameter(Mandatory = false)]
        public AlertType AlertType { get; private set; }

        [Parameter(Mandatory = false)]
        public bool AlwaysNotify { get; private set; }

        [Parameter(Mandatory = false)]
        public AlertDeliveryChannel DeliveryChannels { get; private set; }

        [Parameter(Mandatory = false)]
        public AlertEventType EventType { get; private set; }

        [Parameter(Mandatory = false)]
        public int EventTypeBitmask { get; private set; }

        [Parameter(Mandatory = false)]
        public string Filter { get; private set; }

        [Parameter(Mandatory = true)]
        public List List { get; private set; }

        [Parameter(Mandatory = false)]
        public ListItem ListItem { get; private set; }

        [Parameter(Mandatory = false)]
        public IReadOnlyDictionary<string, string> Properties { get; private set; }

        [Parameter(Mandatory = false)]
        public AlertStatus Status { get; private set; }

        [Parameter(Mandatory = false)]
        public string Title { get; private set; }

        [Parameter(Mandatory = true)]
        public User User { get; private set; }

        protected override void ProcessRecordCore()
        {
            this.WriteObject(this.Service.GetObject(this.Service.CreateObject(this.MyInvocation.BoundParameters)));
        }

    }

}
