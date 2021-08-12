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

namespace Karamem0.SharePoint.PowerShell.Tests
{

    [TestClass()]
    [TestCategory("Set-KshSitePage")]
    public class SetSitePageCommandTests
    {

        [TestMethod()]
        public void SetSitePage()
        {
            using (var context = new PSCmdletContext())
            {
                var result1 = context.Runspace.InvokeCommand(
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
                var result2 = context.Runspace.InvokeCommand(
                    "Add-KshSitePage",
                    new Dictionary<string, object>()
                    {
                        { "PageName", "Test Site Page 0" }
                    }
                );
                var result3 = context.Runspace.InvokeCommand(
                    "Set-KshSitePage",
                    new Dictionary<string, object>()
                    {
                        { "PageName", "Test Site Page 0" },
                        { "PageLayoutType", "Home" },
                        { "Title", "Test Site Page 9" }
                    }
                );
                var result4 = context.Runspace.InvokeCommand(
                    "Remove-KshSitePage",
                    new Dictionary<string, object>()
                    {
                        { "PageName", "Test Site Page 0" }
                    }
                );
            }
        }

        [TestMethod()]
        public void SetSitePageByFolder()
        {
            using (var context = new PSCmdletContext())
            {
                var result1 = context.Runspace.InvokeCommand(
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
                var result2 = context.Runspace.InvokeCommand<List>(
                    "Get-KshList",
                    new Dictionary<string, object>()
                    {
                        { "LibraryType", "ClientRenderedSitePages" }
                    }
                );
                var result3 = context.Runspace.InvokeCommand(
                    "Add-KshSitePage",
                    new Dictionary<string, object>()
                    {
                        { "List", result2.ElementAt(0) },
                        { "PageName", "Test Site Page 0" }
                    }
                );
                var result4 = context.Runspace.InvokeCommand(
                    "Set-KshSitePage",
                    new Dictionary<string, object>()
                    {
                        { "List", result2.ElementAt(0) },
                        { "PageName", "Test Site Page 0" },
                        { "PageLayoutType", "Home" },
                        { "Title", "Test Site Page 9" }
                    }
                );
                var result5 = context.Runspace.InvokeCommand(
                    "Remove-KshSitePage",
                    new Dictionary<string, object>()
                    {
                        { "List", result2.ElementAt(0) },
                        { "PageName", "Test Site Page 0" },
                    }
                );
            }
        }

    }

}
