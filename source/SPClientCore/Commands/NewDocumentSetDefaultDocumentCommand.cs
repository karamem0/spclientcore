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

    [Cmdlet("New", "KshDocumentSetDefaultDocument")]
    [OutputType(typeof(DefaultDocument))]
    public class NewDocumentSetDefaultDocumentCommand : ClientObjectCmdlet<IDocumentSetDefaultDocumentService>
    {

        public NewDocumentSetDefaultDocumentCommand()
        {
        }

        [Parameter(Mandatory = true)]
        public ContentType ContentType { get; private set; }

        [Parameter(Mandatory = true)]
        public ContentType DocumentContentType { get; private set; }

        [Parameter(Mandatory = true)]
        public byte[] Content { get; private set; }

        [Parameter(Mandatory = true)]
        public string FileName { get; private set; }

        [Parameter(Mandatory = false)]
        public SwitchParameter PushChanges { get; private set; }

        protected override void ProcessRecordCore()
        {
            this.WriteObject(this.Service.CreateObject(this.ContentType, this.DocumentContentType, this.FileName, this.Content, this.PushChanges));
        }

    }

}
