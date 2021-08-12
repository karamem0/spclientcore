//
// Copyright (c) 2021 karamem0
//
// This software is released under the MIT License.
//
// https://github.com/karamem0/spclientcore/blob/master/LICENSE
//

using Karamem0.SharePoint.PowerShell.Runtime.Commands;
using Karamem0.SharePoint.PowerShell.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;

namespace Karamem0.SharePoint.PowerShell.Commands
{

    [Cmdlet("Test", "KshTenantSiteCollection")]
    [OutputType(typeof(bool))]
    public class TestTenantSiteCollectionCommand : ClientObjectCmdlet<ITenantService>
    {

        public TestTenantSiteCollectionCommand()
        {
        }

        protected override void ProcessRecordCore()
        {
            try
            {
                var tenant = this.Service.GetObject();
                if (tenant != null)
                {
                    this.WriteObject(true);
                }
                else
                {
                    this.WriteObject(false);
                }
            }
            catch
            {
                this.WriteObject(false);
            }
        }

    }

}
