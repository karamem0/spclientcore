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

    [Cmdlet("Save", "KshAttachmentFile")]
    [OutputType(typeof(AttachmentFile))]
    public class SaveAttachmentFileCommand : ClientObjectCmdlet<IAttachmentFileService>
    {

        public SaveAttachmentFileCommand()
        {
        }

        [Parameter(Mandatory = true, Position = 0, ValueFromPipeline = true)]
        public ListItem ListItem { get; private set; }

        [Parameter(Mandatory = true)]
        public System.IO.Stream Content { get; private set; }

        [Parameter(Mandatory = true)]
        public string FileName { get; private set; }

        [Parameter(Mandatory = true)]
        public SwitchParameter PassThru { get; private set; }

        protected override void ProcessRecordCore()
        {
            this.Service.UploadObject(this.ListItem, this.FileName, this.Content);
            if (this.PassThru)
            {
                this.WriteObject(this.Service.GetObject(this.ListItem, this.FileName));
            }
        }

    }

}
