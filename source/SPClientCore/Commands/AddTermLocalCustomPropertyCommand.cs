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

    [Cmdlet("Add", "KshTermLocalCustomProperty")]
    [OutputType(typeof(void))]
    public class AddTermLocalCustomPropertyCommand : ClientObjectCmdlet<ITermLocalCustomPropertyService>
    {

        public AddTermLocalCustomPropertyCommand()
        {
        }

        [Parameter(Mandatory = true, Position = 0)]
        public Term Term { get; private set; }

        [Parameter(Mandatory = true)]
        public string Name { get; private set; }

        [Parameter(Mandatory = true)]
        public string Value { get; private set; }

        protected override void ProcessRecordCore()
        {
            this.Service.AddObject(this.Term, this.Name, this.Value);
        }

    }

}
