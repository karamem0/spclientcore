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

    [Cmdlet("Get", "KshDocumentSetDefaultDocument")]
    [OutputType(typeof(DefaultDocument))]
    public class GetDocumentSetDefaultDocumentCommand : ClientObjectCmdlet<IDocumentSetDefaultDocumentService>
    {

        public GetDocumentSetDefaultDocumentCommand()
        {
        }

        [Parameter(Mandatory = true, Position = 0)]
        public ContentType ContentType { get; private set; }

        [Parameter(Mandatory = false)]
        public SwitchParameter NoEnumerate { get; private set; }

        protected override void ProcessRecordCore()
        {
            this.WriteObject(this.Service.GetObjectEnumerable(this.ContentType), this.NoEnumerate ? false : true);
        }

    }

}
