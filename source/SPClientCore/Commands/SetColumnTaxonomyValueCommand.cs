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

    [Cmdlet("Set", "KshColumnTaxonomyValue")]
    [OutputType(typeof(void))]
    public class SetColumnTaxonomyValueCommand : ClientObjectCmdlet<IColumnTaxonomyService>
    {

        public SetColumnTaxonomyValueCommand()
        {
        }

        [Parameter(Mandatory = true, Position = 0)]
        public ColumnTaxonomy Column { get; private set; }

        [Parameter(Mandatory = true, Position = 1)]
        public ListItem ListItem { get; private set; }

        [Parameter(Mandatory = true)]
        public Term[] Value { get; private set; }

        [Parameter(Mandatory = true)]
        public uint Lcid { get; private set; }

        protected override void ProcessRecordCore()
        {
            this.Service.SetObjectValue(this.Column, this.ListItem, this.Value, this.Lcid);
        }

    }

}
