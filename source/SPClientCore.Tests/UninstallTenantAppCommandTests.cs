//
// Copyright (c) 2021 karamem0
//
// This software is released under the MIT License.
//
// https://github.com/karamem0/spclientcore/blob/master/LICENSE
//

using Karamem0.SharePoint.PowerShell.Models;
using Karamem0.SharePoint.PowerShell.Tests.Runtime;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Karamem0.SharePoint.PowerShell.Tests
{

    [TestClass()]
    [TestCategory("Uninstall-KshTenantApp")]
    public class UninstallTenantAppCommandTests
    {

        [TestMethod()]
        public void UninstallTenantApp()
        {
            using (var context = new PSCmdletContext())
            {
                var result1 = context.Runspace.InvokeCommand(
                    "Connect-KshSite",
                    new Dictionary<string, object>()
                    {
                        { "Url", context.AppSettings["TenantAppCatalogUrl"] },
                        { "Credential", PSCredentialFactory.CreateCredential(
                            context.AppSettings["LoginUserName"],
                            context.AppSettings["LoginPassword"])
                        }
                    }
                );
                var result2 = context.Runspace.InvokeCommand<App>(
                    "New-KshTenantApp",
                    new Dictionary<string, object>()
                    {
                        { "Content", System.IO.File.OpenRead(context.AppSettings["App0Path"]) },
                        { "FileName", "TestApp0.sppkg" },
                        { "Overwrite", true }
                    }
                );
                var result3 = context.Runspace.InvokeCommand<File>(
                    "Get-KshFile",
                    new Dictionary<string, object>()
                    {
                        { "App", result2.ElementAt(0) }
                    }
                );
                var result4 = context.Runspace.InvokeCommand<ListItem>(
                    "Get-KshListItem",
                    new Dictionary<string, object>()
                    {
                        { "File", result3.ElementAt(0) }
                    }
                );
                var result5 = context.Runspace.InvokeCommand(
                    "Connect-KshSite",
                    new Dictionary<string, object>()
                    {
                        { "Url", context.AppSettings["AuthorityUrl"] + context.AppSettings["Site1Url"] },
                        { "Credential", PSCredentialFactory.CreateCredential(
                            context.AppSettings["LoginUserName"],
                            context.AppSettings["LoginPassword"])
                        }
                    }
                );
                var result6 = context.Runspace.InvokeCommand(
                    "Install-KshTenantApp",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result2.ElementAt(0) }
                    }
                );
                while (true)
                {
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                    var result7 = context.Runspace.InvokeCommand<AppInstance>(
                        "Get-KshAppInstance",
                        new Dictionary<string, object>()
                        {
                            { "AppProductId", result4.ElementAt(0)["AppProductID"] }
                        }
                    );
                    if (result7.ElementAt(0).Status == AppStatus.Installed)
                    {
                        break;
                    }
                }
                var result8 = context.Runspace.InvokeCommand(
                    "Uninstall-KshTenantApp",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result2.ElementAt(0) }
                    }
                );
                while (true)
                {
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                    var result9 = context.Runspace.InvokeCommand<AppInstance>(
                        "Get-KshAppInstance",
                        new Dictionary<string, object>()
                        {
                            { "AppProductId", result4.ElementAt(0)["AppProductID"] }
                        }
                    );
                    if (result9.Any())
                    {
                    }
                    else
                    {
                        break;
                    }
                }
                var result10 = context.Runspace.InvokeCommand(
                    "Connect-KshSite",
                    new Dictionary<string, object>()
                    {
                        { "Url", context.AppSettings["TenantAppCatalogUrl"] },
                        { "Credential", PSCredentialFactory.CreateCredential(
                            context.AppSettings["LoginUserName"],
                            context.AppSettings["LoginPassword"])
                        }
                    }
                );
                var result11 = context.Runspace.InvokeCommand(
                    "Remove-KshTenantApp",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result2.ElementAt(0) }
                    }
                );
            }
        }

    }

}
