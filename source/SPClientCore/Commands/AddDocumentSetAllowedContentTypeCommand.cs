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

    [Cmdlet("Add", "KshDocumentSetAllowedContentType")]
    [OutputType(typeof(void))]
    public class AddDocumentSetAllowedContentTypeCommand : ClientObjectCmdlet<IDocumentSetAllowedContentTypeService>
    {

        public AddDocumentSetAllowedContentTypeCommand()
        {
        }

        [Parameter(Mandatory = true, Position = 0)]
        public ContentType ContentType { get; private set; }

        [Parameter(Mandatory = true)]
        public ContentType AllowedContentType { get; private set; }

        [Parameter(Mandatory = false)]
        public SwitchParameter PushChanges { get; private set; }

        protected override void ProcessRecordCore()
        {
            this.Service.AddObject(this.ContentType, this.AllowedContentType, this.PushChanges);
        }

    }

}
