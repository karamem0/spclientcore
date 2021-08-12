//
// Copyright (c) 2021 karamem0
//
// This software is released under the MIT License.
//
// https://github.com/karamem0/spclientcore/blob/master/LICENSE
//

using Karamem0.SharePoint.PowerShell.Models;
using Karamem0.SharePoint.PowerShell.Runtime.Commands;
using Karamem0.SharePoint.PowerShell.Runtime.Common;
using Karamem0.SharePoint.PowerShell.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;

namespace Karamem0.SharePoint.PowerShell.Commands
{

    [Cmdlet("New", "KshListItem")]
    [OutputType(typeof(ListItem))]
    public class NewListItemCommand : ClientObjectCmdlet<IListItemService>
    {

        public NewListItemCommand()
        {
        }

        [Parameter(Mandatory = true, Position = 0, ValueFromPipeline = true)]
        public List List { get; private set; }

        [Parameter(Mandatory = true, Position = 1)]
        public Hashtable Value { get; private set; }

        protected override void ProcessRecordCore()
        {
            this.WriteObject(this.Service.CreateObject(this.List, this.Value.ToDictionary<string, object>()));
        }

    }

}
