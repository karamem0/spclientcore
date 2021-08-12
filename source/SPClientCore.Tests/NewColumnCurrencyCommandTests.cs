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
    [TestCategory("New-KshColumnCurrency")]
    public class NewColumnCurrencyCommandTests
    {

        [TestMethod()]
        public void CreateListColumnCurrency()
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
                        { "ListId", context.AppSettings["List1Id"] }
                    }
                );
                var result3 = context.Runspace.InvokeCommand<ColumnCurrency>(
                    "New-KshColumnCurrency",
                    new Dictionary<string, object>()
                    {
                        { "List", result2.ElementAt(0) },
                        // { "ClientSideComponentId", null },
                        // { "ClientSideComponentProperties", null },
                        { "CurrencyLcid", 1041 },
                        { "CustomFormatter", "{ \"txtContent\": \"@currentField\" }" },
                        { "DefaultValue", "50" },
                        { "Description", "Test Column 0 Description" },
                        { "Direction", "none" },
                        { "EnforceUniqueValues", true },
                        { "Group", "Test Column 0 Group" },
                        { "Hidden", true },
                        { "Id", "35aa78a6-66d7-472c-ab6b-d534193842af" },
                        { "Indexed", true },
                        { "JSLink", "clienttemplates.js" },
                        { "MaxValue", 99 },
                        { "MinValue", 1 },
                        { "Name", "TestColumn0" },
                        { "NoCrawl", true },
                        { "NumberFormat", 2 },
                        { "ReadOnly", true },
                        { "Required", true },
                        { "StaticName", "TestColumn0" },
                        { "Title", "Test Column 0" },
                        { "AddColumnInternalNameHint", true },
                        { "AddToDefaultView", true }
                    }
                );
                var result4 = context.Runspace.InvokeCommand(
                    "Update-KshColumnCurrency",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result3.ElementAt(0) },
                        { "Hidden", false },
                        { "ReadOnly", false }
                    }
                );
                var result5 = context.Runspace.InvokeCommand(
                    "Remove-KshColumn",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result3.ElementAt(0) }
                    }
                );
                var actual = result3.ElementAt(0);
            }
        }

        [TestMethod()]
        public void CreateSiteColumnCurrency()
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
                var result2 = context.Runspace.InvokeCommand<ColumnCurrency>(
                    "New-KshColumnCurrency",
                    new Dictionary<string, object>()
                    {
                        // { "ClientSideComponentId", null },
                        // { "ClientSideComponentProperties", null },
                        { "CurrencyLcid", 1041 },
                        { "CustomFormatter", "{ \"txtContent\": \"@currentField\" }" },
                        { "DefaultValue", "50" },
                        { "Description", "Test Column 0 Description" },
                        { "Direction", "none" },
                        { "EnforceUniqueValues", true },
                        { "Group", "Test Column 0 Group" },
                        { "Hidden", true },
                        { "Id", "35aa78a6-66d7-472c-ab6b-d534193842af" },
                        { "Indexed", true },
                        // { "JSLink", "clienttemplates.js" },
                        { "MaxValue", 99 },
                        { "MinValue", 1 },
                        { "Name", "TestColumn0" },
                        { "NoCrawl", true },
                        { "NumberFormat", 2 },
                        { "ReadOnly", true },
                        { "Required", true },
                        { "StaticName", "TestColumn0" },
                        { "Title", "Test Column 0" },
                        { "AddColumnInternalNameHint", true },
                        { "AddToDefaultView", true }
                    }
                );
                var result3 = context.Runspace.InvokeCommand(
                    "Update-KshColumnCurrency",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result2.ElementAt(0) },
                        { "Hidden", false },
                        { "ReadOnly", false }
                    }
                );
                var result4 = context.Runspace.InvokeCommand(
                    "Remove-KshColumn",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result2.ElementAt(0) }
                    }
                );
                var actual = result2.ElementAt(0);
            }
        }

    }

}
