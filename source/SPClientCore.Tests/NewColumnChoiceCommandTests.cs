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
    [TestCategory("New-KshColumnChoice")]
    public class NewColumnChoiceCommandTests
    {

        [TestMethod()]
        public void CreateListColumnChoice()
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
                var result3 = context.Runspace.InvokeCommand<ColumnChoice>(
                    "New-KshColumnChoice",
                    new Dictionary<string, object>()
                    {
                        { "List", result2.ElementAt(0) },
                        { "Choices", new[] { "Test Value 1", "Test Value 2", "Test Value 3" } },
                        { "ChoiceFormat", "RadioButtons" },
                        // { "ClientSideComponentId", null },
                        // { "ClientSideComponentProperties", null },
                        { "CustomFormatter", "{ \"txtContent\": \"@currentField\" }" },
                        { "DefaultValue", "Test Value 1" },
                        { "Description", "Test Column 0 Description" },
                        { "Direction", "none" },
                        { "EnforceUniqueValues", true },
                        { "FillInChoice", true },
                        { "Hidden", true },
                        { "Group", "Test Column 0 Group" },
                        { "Id", "35aa78a6-66d7-472c-ab6b-d534193842af" },
                        { "Indexed", true },
                        { "JSLink", "clienttemplates.js" },
                        { "Name", "TestColumn0" },
                        { "NoCrawl", true },
                        { "ReadOnly", true },
                        { "Required", true },
                        { "StaticName", "TestColumn0" },
                        { "Title", "Test Column 0" },
                        { "AddColumnInternalNameHint", true },
                        { "AddToDefaultView", true },
                    }
                );
                var result4 = context.Runspace.InvokeCommand(
                    "Update-KshColumnChoice",
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
        public void CreateSiteColumnChoice()
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
                var result2 = context.Runspace.InvokeCommand<ColumnChoice>(
                    "New-KshColumnChoice",
                    new Dictionary<string, object>()
                    {
                        { "Choices", new[] { "Test Value 1", "Test Value 2", "Test Value 3" } },
                        { "ChoiceFormat", "RadioButtons" },
                        // { "ClientSideComponentId", null },
                        // { "ClientSideComponentProperties", null },
                        { "CustomFormatter", "{ \"txtContent\": \"@currentField\" }" },
                        { "DefaultValue", "Test Value 1" },
                        { "Description", "Test Column 0 Description" },
                        { "Direction", "none" },
                        { "EnforceUniqueValues", true },
                        { "FillInChoice", true },
                        { "Group", "Test Column 0 Group" },
                        { "Hidden", true },
                        { "Id", "35aa78a6-66d7-472c-ab6b-d534193842af" },
                        { "Indexed", true },
                        // { "JSLink", "clienttemplates.js" },
                        { "Name", "TestColumn0" },
                        { "NoCrawl", true },
                        { "ReadOnly", true },
                        { "Required", true },
                        { "StaticName", "TestColumn0" },
                        { "Title", "Test Column 0" },
                        { "AddColumnInternalNameHint", true },
                        { "AddToDefaultView", true },
                    }
                );
                var result3 = context.Runspace.InvokeCommand(
                    "Update-KshColumnChoice",
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
