//
// Copyright (c) 2021 karamem0
//
// This software is released under the MIT License.
//
// https://github.com/karamem0/spclientcore/blob/master/LICENSE
//

using Karamem0.SharePoint.PowerShell.Tests.Runtime;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Karamem0.SharePoint.PowerShell.Tests
{

    [TestClass()]
    [TestCategory("Remove-KshTenantCdnOrigin")]
    public class RemoveTenantCdnOriginCommandTests
    {

        [TestMethod()]
        public void RemoveTenantPublicCdnOrigin()
        {
            using (var context = new PSCmdletContext())
            {
                var result1 = context.Runspace.InvokeCommand(
                    "Connect-KshSite",
                    new Dictionary<string, object>()
                    {
                        { "Url", context.AppSettings["AdminUrl"] },
                        { "Credential", PSCredentialFactory.CreateCredential(
                            context.AppSettings["LoginUserName"],
                            context.AppSettings["LoginPassword"])
                        }
                    }
                );
                var result2 = context.Runspace.InvokeCommand(
                    "Add-KshTenantCdnOrigin",
                    new Dictionary<string, object>()
                    {
                        { "Public", true },
                        { "Origin", "*/TESTLIST1" }
                    }
                );
                var result3 = context.Runspace.InvokeCommand(
                    "Remove-KshTenantCdnOrigin",
                    new Dictionary<string, object>()
                    {
                        { "Public", true },
                        { "Origin", "*/TESTLIST1" }
                    }
                );
                var result4 = context.Runspace.InvokeCommand<string>(
                    "Get-KshTenantCdnOrigin",
                    new Dictionary<string, object>()
                    {
                        { "Private", true }
                    }
                );
                var actual = result4.ToArray();
            }
        }

        [TestMethod()]
        public void RemoveTenantPrivateCdnOrigin()
        {
            using (var context = new PSCmdletContext())
            {
                var result1 = context.Runspace.InvokeCommand(
                    "Connect-KshSite",
                    new Dictionary<string, object>()
                    {
                        { "Url", context.AppSettings["AdminUrl"] },
                        { "Credential", PSCredentialFactory.CreateCredential(
                            context.AppSettings["LoginUserName"],
                            context.AppSettings["LoginPassword"])
                        }
                    }
                );
                var result2 = context.Runspace.InvokeCommand(
                    "Add-KshTenantCdnOrigin",
                    new Dictionary<string, object>()
                    {
                        { "Private", true },
                        { "Origin", "*/TESTLIST1" }
                    }
                );
                var result3 = context.Runspace.InvokeCommand(
                    "Remove-KshTenantCdnOrigin",
                    new Dictionary<string, object>()
                    {
                        { "Private", true },
                        { "Origin", "*/TESTLIST1" }
                    }
                );
                var result4 = context.Runspace.InvokeCommand<string>(
                    "Get-KshTenantCdnOrigin",
                    new Dictionary<string, object>()
                    {
                        { "Private", true }
                    }
                );
                var actual = result4.ToArray();
            }
        }

    }

}
