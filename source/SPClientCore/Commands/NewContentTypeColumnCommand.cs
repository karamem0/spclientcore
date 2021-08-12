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

    [Cmdlet("New", "KshContentTypeColumn")]
    [OutputType(typeof(ContentTypeColumn))]
    public class NewContentTypeColumnCommand : ClientObjectCmdlet<IContentTypeColumnService>
    {

        public NewContentTypeColumnCommand()
        {
        }

        [Parameter(Mandatory = true)]
        public ContentType ContentType { get; private set; }

        [Parameter(Mandatory = true)]
        public Column Column { get; private set; }

        [Parameter(Mandatory = false)]
        public SwitchParameter PushChanges { get; private set; }

        protected override void ProcessRecordCore()
        {
            this.WriteObject(this.Service.CreateObject(this.ContentType, this.MyInvocation.BoundParameters, this.PushChanges));
        }

    }

}
