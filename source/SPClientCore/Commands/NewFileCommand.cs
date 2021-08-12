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

    [Cmdlet("New", "KshFile")]
    [OutputType(typeof(File))]
    public class NewFileCommand : ClientObjectCmdlet<IFileService>
    {

        public NewFileCommand()
        {
        }

        [Parameter(Mandatory = true, Position = 0, ValueFromPipeline = true)]
        public Folder Folder { get; private set; }

        [Parameter(Mandatory = true)]
        public byte[] Content { get; private set; }

        [Parameter(Mandatory = true)]
        public string FileName { get; private set; }

        [Parameter(Mandatory = false)]
        public bool Overwrite { get; private set; }

        protected override void ProcessRecordCore()
        {
            this.WriteObject(this.Service.CreateObject(this.Folder, this.MyInvocation.BoundParameters));
        }

    }

}
