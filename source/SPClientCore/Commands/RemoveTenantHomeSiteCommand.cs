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

    [Cmdlet("Remove", "KshTenantHomeSite")]
    [OutputType(typeof(void))]
    public class RemoveTenantHomeSiteCommand : ClientObjectCmdlet<ITenantHomeSiteService>
    {

        public RemoveTenantHomeSiteCommand()
        {
        }

        protected override void ProcessRecordCore()
        {
            this.Service.RemoveObject();
        }

    }

}
