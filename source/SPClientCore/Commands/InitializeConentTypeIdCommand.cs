//
// Copyright (c) 2021 karamem0
//
// This software is released under the MIT License.
//
// https://github.com/karamem0/spclientcore/blob/master/LICENSE
//

using Karamem0.SharePoint.PowerShell.Models;
using Karamem0.SharePoint.PowerShell.Runtime.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;

namespace Karamem0.SharePoint.PowerShell.Commands
{

    [Cmdlet("Initialize", "KshContentTypeId")]
    [OutputType(typeof(ContentTypeId))]
    public class InitializeContentTypeIdCommand : ClientObjectCmdlet
    {

        public InitializeContentTypeIdCommand()
        {
        }

        [Parameter(Mandatory = true, Position = 0)]
        public string StringValue { get; private set; }

        protected override void ProcessRecordCore()
        {
            this.WriteObject(new ContentTypeId(this.StringValue));
        }

    }

}
