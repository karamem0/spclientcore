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

    [Cmdlet("New", "KshSiteCollectionApp")]
    [OutputType(typeof(App))]
    public class NewSiteCollectionAppCommand : ClientObjectCmdlet<ISiteCollectionAppService>
    {

        public NewSiteCollectionAppCommand()
        {
        }

        [Parameter(Mandatory = true)]
        public System.IO.Stream Content { get; private set; }

        [Parameter(Mandatory = true)]
        public string FileName { get; private set; }

        [Parameter(Mandatory = false)]
        public bool Overwrite { get; private set; }

        protected override void ProcessRecordCore()
        {
            this.WriteObject(this.Service.CreateObject(this.Content, this.FileName, this.Overwrite));
        }

    }

}
