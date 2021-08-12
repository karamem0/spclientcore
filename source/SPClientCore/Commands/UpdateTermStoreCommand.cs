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

    [Cmdlet("Update", "KshTermStore")]
    [OutputType(typeof(TermStore))]
    public class UpdateTermStoreCommand : ClientObjectCmdlet<ITermStoreService>
    {

        public UpdateTermStoreCommand()
        {
        }

        [Parameter(Mandatory = false)]
        public uint DefaultLcid { get; private set; }

        [Parameter(Mandatory = false)]
        public uint WorkingLcid { get; private set; }

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
