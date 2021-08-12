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

    [Cmdlet("Save", "KshFile")]
    [OutputType(typeof(File))]
    public class SaveFileCommand : ClientObjectCmdlet<IFileService>
    {

        public SaveFileCommand()
        {
        }

        [Parameter(Mandatory = true)]
        public Folder Folder { get; private set; }

        [Parameter(Mandatory = true)]
        public System.IO.Stream Content { get; private set; }

        [Parameter(Mandatory = true)]
        public string FileName { get; private set; }

        [Parameter(Mandatory = false)]
        public bool Overwrite { get; private set; }

        [Parameter(Mandatory = false)]
        public SwitchParameter PassThru { get; private set; }

        protected override void ProcessRecordCore()
        {
            this.Service.UploadObject(this.Folder.ServerRelativeUrl, this.FileName, this.Content, this.Overwrite);
            if (this.PassThru)
            {
                this.WriteObject(this.Service.GetObject(this.Folder, this.FileName));
            }
        }

    }

}
