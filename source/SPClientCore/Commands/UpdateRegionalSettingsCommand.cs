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

    [Cmdlet("Update", "KshRegionalSettings")]
    [OutputType(typeof(RegionalSettings))]
    public class UpdateRegionalSettingsCommand : ClientObjectCmdlet<IRegionalSettingsService>
    {

        public UpdateRegionalSettingsCommand()
        {
        }

        [Parameter(Mandatory = false)]
        public short AdjustHijriDays { get; private set; }

        [Parameter(Mandatory = false)]
        public short AlternateCalendarType { get; private set; }

        [Parameter(Mandatory = false)]
        public short CalendarType { get; private set; }

        [Parameter(Mandatory = false)]
        public short Collation { get; private set; }

        [Parameter(Mandatory = false)]
        public uint FirstDayOfWeek { get; private set; }

        [Parameter(Mandatory = false)]
        public uint FirstWeekOfYear { get; private set; }

        [Parameter(Mandatory = false)]
        public uint Lcid { get; private set; }

        [Parameter(Mandatory = false)]
        public bool ShowWeeks { get; private set; }

        [Parameter(Mandatory = false)]
        public bool Time24 { get; private set; }

        [Parameter(Mandatory = false)]
        public Karamem0.SharePoint.PowerShell.Models.TimeZone TimeZone { get; private set; }

        [Parameter(Mandatory = false)]
        public short WorkDayEndHour { get; private set; }

        [Parameter(Mandatory = false)]
        public short WorkDays { get; private set; }

        [Parameter(Mandatory = false)]
        public short WorkDayStartHour { get; private set; }

        [Parameter(Mandatory = false)]
        public SwitchParameter PassThru { get; private set; }

        protected override void ProcessRecordCore()
        {
            this.Service.UpdateObject(this.MyInvocation.BoundParameters);
            if (this.PassThru)
            {
                this.WriteObject(this.Service.GetObject());
            }
        }

    }

}
