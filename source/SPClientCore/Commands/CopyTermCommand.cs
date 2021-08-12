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

    [Cmdlet("Copy", "KshTerm")]
    [OutputType(typeof(Term))]
    public class CopyTermCommand : ClientObjectCmdlet<ITermService>
    {

        public CopyTermCommand()
        {
        }

        [Parameter(Mandatory = true, Position = 0, ValueFromPipeline = true)]
        public Term Identity { get; private set; }

        [Parameter(Mandatory = false)]
        public SwitchParameter CopyChildren { get; private set; }

        protected override void ProcessRecordCore()
        {
            this.WriteObject(this.Service.CopyObject(this.Identity, this.CopyChildren));
        }

    }

}
