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

    [Cmdlet("New", "KshTermSet")]
    [OutputType(typeof(TermSet))]
    public class NewTermSetCommand : ClientObjectCmdlet<ITermSetService>
    {

        public NewTermSetCommand()
        {
        }

        [Parameter(Mandatory = true, Position = 0, ValueFromPipeline = true)]
        public TermGroup TermGroup { get; private set; }

        [Parameter(Mandatory = false)]
        public Guid Id { get; private set; }

        [Parameter(Mandatory = true)]
        public uint Lcid { get; private set; }

        [Parameter(Mandatory = true)]
        public string Name { get; private set; }

        protected override void ProcessRecordCore()
        {
            if (this.Id == default)
            {
                this.Id = Guid.NewGuid();
            }
            this.WriteObject(this.Service.CreateObject(this.TermGroup, this.Name, this.Id, this.Lcid));
        }

    }

}
