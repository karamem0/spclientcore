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

    [Cmdlet("Set", "KshTermDescription")]
    [OutputType(typeof(void))]
    public class SetTermDescriptionCommand : ClientObjectCmdlet<ITermDescriptionService>
    {

        public SetTermDescriptionCommand()
        {
        }

        [Parameter(Mandatory = true, Position = 0)]
        public Term Term { get; private set; }

        [Parameter(Mandatory = true)]
        public string Description { get; private set; }

        [Parameter(Mandatory = true)]
        public uint Lcid { get; private set; }

        protected override void ProcessRecordCore()
        {
            this.Service.SetObject(this.Term, this.Description, this.Lcid);
        }

    }

}
