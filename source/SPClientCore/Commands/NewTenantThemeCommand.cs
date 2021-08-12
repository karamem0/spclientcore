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
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;

namespace Karamem0.SharePoint.PowerShell.Commands
{

    [Cmdlet("New", "KshTenantTheme")]
    [OutputType(typeof(TenantTheme))]
    public class NewTenantThemeCommand : ClientObjectCmdlet<ITenantThemeService>
    {

        public NewTenantThemeCommand()
        {
        }

        [Parameter(Mandatory = true)]
        public bool IsInverted { get; private set; }

        [Parameter(Mandatory = true)]
        public string Name { get; private set; }

        [Parameter(Mandatory = true)]
        public Hashtable Palette { get; private set; }

        protected override void ProcessRecordCore()
        {
            _ = this.Service.CreateObject(this.Name, this.MyInvocation.BoundParameters);
            this.WriteObject(this.Service.GetObject(this.Name));
        }

    }

}
