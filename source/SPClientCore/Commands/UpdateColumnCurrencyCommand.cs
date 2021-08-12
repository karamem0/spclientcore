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

    [Cmdlet("Update", "KshColumnCurrency")]
    [OutputType(typeof(ColumnCurrency))]
    public class UpdateColumnCurrencyCommand : ClientObjectCmdlet<IColumnService>
    {

        public UpdateColumnCurrencyCommand()
        {
        }

        [Parameter(Mandatory = true, Position = 0, ValueFromPipeline = true)]
        public Column Identity { get; private set; }

        [Parameter(Mandatory = false)]
        public string ClientSideComponentId { get; private set; }

        [Parameter(Mandatory = false)]
        public string ClientSideComponentProperties { get; private set; }

        [Parameter(Mandatory = false)]
        public string ClientValidationFormula { get; private set; }

        [Parameter(Mandatory = false)]
        public string ClientValidationMessage { get; private set; }

        [Parameter(Mandatory = false)]
        public uint CurrencyLcid { get; private set; }

        [Parameter(Mandatory = false)]
        public string CustomFormatter { get; private set; }

        [Parameter(Mandatory = false)]
        public string DefaultFormula { get; private set; }

        [Parameter(Mandatory = false)]
        public string DefaultValue { get; private set; }

        [Parameter(Mandatory = false)]
        public string Description { get; private set; }

        [Parameter(Mandatory = false)]
        public string Direction { get; private set; }

        [Parameter(Mandatory = false)]
        public bool EnforceUniqueValues { get; private set; }

        [Parameter(Mandatory = false)]
        public string Group { get; private set; }

        [Parameter(Mandatory = false)]
        public bool Hidden { get; private set; }

        [Parameter(Mandatory = false)]
        public bool Indexed { get; private set; }

        [Parameter(Mandatory = false)]
        public string JSLink { get; private set; }

        [Parameter(Mandatory = false)]
        public double MaxValue { get; private set; }

        [Parameter(Mandatory = false)]
        public double MinValue { get; private set; }

        [Parameter(Mandatory = false)]
        public bool NoCrawl { get; private set; }

        [Parameter(Mandatory = false)]
        public int NumberFormat { get; private set; }

        [Parameter(Mandatory = false)]
        public bool ReadOnly { get; private set; }

        [Parameter(Mandatory = false)]
        public bool Required { get; private set; }

        [Parameter(Mandatory = false)]
        public string StaticName { get; private set; }

        [Parameter(Mandatory = false)]
        public string Title { get; private set; }

        [Parameter(Mandatory = false)]
        public string ValidationFormula { get; private set; }

        [Parameter(Mandatory = false)]
        public string ValidationMessage { get; private set; }

        [Parameter(Mandatory = false)]
        public SwitchParameter PushChanges { get; private set; }

        [Parameter(Mandatory = false)]
        public SwitchParameter PassThru { get; private set; }

        protected override void ProcessRecordCore()
        {
            this.Service.UpdateObject(this.Identity, this.MyInvocation.BoundParameters, this.PushChanges);
            if (this.PassThru)
            {
                this.WriteObject(this.Service.GetObject(this.Identity));
            }
        }

    }

}
