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
    [TestCategory("Add-KshViewColumn")]
    public class AddViewColumnCommandTests
    {

        [TestMethod()]
        public void AddViewColumnByColumn()
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
                        { "ListId", context.AppSettings["List1Id"] },
                    }
                );
                var result3 = context.Runspace.InvokeCommand<View>(
                    "Get-KshView",
                    new Dictionary<string, object>()
                    {
                        { "List", result2.ElementAt(0) },
                        { "ViewId", context.AppSettings["View1Id"] }
                    }
                );
                var result4 = context.Runspace.InvokeCommand<ColumnText>(
                    "New-KshColumnText",
                    new Dictionary<string, object>()
                    {
                        { "List", result2.ElementAt(0) },
                        { "Name", "TestColumn0" },
                        { "Title", "Test Column 0" },
                        { "AddColumnInternalNameHint", true },
                        { "AddToDefaultView", true }
                    }
                );
                var result5 = context.Runspace.InvokeCommand(
                    "Add-KshViewColumn",
                    new Dictionary<string, object>()
                    {
                        { "View", result3.ElementAt(0) },
                        { "Column", result4.ElementAt(0) }
                    }
                );
                var result6 = context.Runspace.InvokeCommand(
                    "Remove-KshViewColumn",
                    new Dictionary<string, object>()
                    {
                        { "View", result3.ElementAt(0) },
                        { "Column", result4.ElementAt(0) }
                    }
                );
                var result7 = context.Runspace.InvokeCommand(
                    "Remove-KshColumn",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result4.ElementAt(0) }
                    }
                );
            }
        }

        [TestMethod()]
        public void AddViewColumnByColumnName()
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
                        { "ListId", context.AppSettings["List1Id"] },
                    }
                );
                var result3 = context.Runspace.InvokeCommand<View>(
                    "Get-KshView",
                    new Dictionary<string, object>()
                    {
                        { "List", result2.ElementAt(0) },
                        { "ViewId", context.AppSettings["View1Id"] }
                    }
                );
                var result4 = context.Runspace.InvokeCommand<ColumnText>(
                    "New-KshColumnText",
                    new Dictionary<string, object>()
                    {
                        { "List", result2.ElementAt(0) },
                        { "Name", "TestColumn0" },
                        { "Title", "Test Column 0" },
                        { "AddColumnInternalNameHint", true },
                        { "AddToDefaultView", true }
                    }
                );
                var result5 = context.Runspace.InvokeCommand(
                    "Add-KshViewColumn",
                    new Dictionary<string, object>()
                    {
                        { "View", result3.ElementAt(0) },
                        { "ColumnName", result4.ElementAt(0).Name }
                    }
                );
                var result6 = context.Runspace.InvokeCommand(
                    "Remove-KshViewColumn",
                    new Dictionary<string, object>()
                    {
                        { "View", result3.ElementAt(0) },
                        { "Column", result4.ElementAt(0) }
                    }
                );
                var result7 = context.Runspace.InvokeCommand(
                    "Remove-KshColumn",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result4.ElementAt(0) }
                    }
                );
            }
        }

    }

}
