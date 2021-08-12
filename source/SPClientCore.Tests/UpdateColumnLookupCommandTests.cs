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
    [TestCategory("Update-KshColumnLookup")]
    public class UpdateColumnLookupCommandTests
    {

        [TestMethod()]
        public void UpdateListColumnLookup()
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
                var result3 = context.Runspace.InvokeCommand<ColumnLookup>(
                    "New-KshColumnLookup",
                    new Dictionary<string, object>()
                    {
                        { "List", result2.ElementAt(0) },
                        { "AllowMultipleValues", true },
                        { "LookupListId", context.AppSettings["List1Id"] },
                        { "LookupColumnName", context.AppSettings["Column1Name"] },
                        { "Name", "TestColumn0" },
                        { "Title", "Test Column 0" },
                        { "AddColumnInternalNameHint", true },
                        { "AddToDefaultView", true }
                    }
                );
                var result4 = context.Runspace.InvokeCommand<ColumnLookup>(
                    "Update-KshColumnLookup",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result3.ElementAt(0) },
                        { "AllowMultipleValues", false },
                        // { "ClientSideComponentId", null },
                        // { "ClientSideComponentProperties", null },
                        { "CustomFormatter", "{ \"txtContent\": \"@currentField\" }" },
                        { "Direction", "none" },
                        { "Description", "Test Column 0 Description" },
                        { "EnforceUniqueValues", false },
                        { "Group", "Test Group 0" },
                        { "Hidden", true },
                        { "Indexed", false },
                        { "JSLink", "clienttemplates.js" },
                        { "LookupListId", context.AppSettings["List1Id"] },
                        { "LookupColumnName", context.AppSettings["Column2Name"] },
                        { "NoCrawl", true },
                        { "ReadOnly", true },
                        { "RelationshipDeleteBehavior", "None" },
                        { "Required", true },
                        { "StaticName", "TestColumn0" },
                        { "Title", "Test Column 0" },
                        { "UnlimitedLengthInDocumentLibrary", true },
                        { "PassThru", true }
                    }
                );
                var result5 = context.Runspace.InvokeCommand(
                    "Update-KshColumnLookup",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result4.ElementAt(0) },
                        { "Hidden", false },
                        { "ReadOnly", false }
                    }
                );
                var result6 = context.Runspace.InvokeCommand(
                    "Remove-KshColumn",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result4.ElementAt(0) }
                    }
                );
                var actual = result4.ElementAt(0);
            }
        }

        [TestMethod()]
        public void UpdateListColumnLookupMulti()
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
                var result3 = context.Runspace.InvokeCommand<ColumnLookup>(
                    "New-KshColumnLookup",
                    new Dictionary<string, object>()
                    {
                        { "List", result2.ElementAt(0) },
                        { "AllowMultipleValues", false },
                        { "LookupListId", context.AppSettings["List1Id"] },
                        { "LookupColumnName", context.AppSettings["Column1Name"] },
                        { "Name", "TestColumn0" },
                        { "Title", "Test Column 0" },
                        { "AddColumnInternalNameHint", true },
                        { "AddToDefaultView", true }
                    }
                );
                var result4 = context.Runspace.InvokeCommand<ColumnLookup>(
                    "Update-KshColumnLookup",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result3.ElementAt(0) },
                        { "AllowMultipleValues", true },
                        // { "ClientSideComponentId", null },
                        // { "ClientSideComponentProperties", null },
                        { "CustomFormatter", "{ \"txtContent\": \"@currentField\" }" },
                        { "Direction", "none" },
                        { "Description", "Test Column 0 Description" },
                        { "EnforceUniqueValues", false },
                        { "Group", "Test Group 0" },
                        { "Hidden", true },
                        { "Indexed", false },
                        { "JSLink", "clienttemplates.js" },
                        { "LookupListId", context.AppSettings["List1Id"] },
                        { "LookupColumnName", context.AppSettings["Column2Name"] },
                        { "NoCrawl", true },
                        { "ReadOnly", true },
                        { "RelationshipDeleteBehavior", "None" },
                        { "Required", true },
                        { "StaticName", "TestColumn0" },
                        { "Title", "Test Column 0" },
                        { "UnlimitedLengthInDocumentLibrary", true },
                        { "PassThru", true }
                    }
                );
                var result5 = context.Runspace.InvokeCommand(
                    "Update-KshColumnLookup",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result4.ElementAt(0) },
                        { "Hidden", false },
                        { "ReadOnly", false }
                    }
                );
                var result6 = context.Runspace.InvokeCommand(
                    "Remove-KshColumn",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result4.ElementAt(0) }
                    }
                );
                var actual = result4.ElementAt(0);
            }
        }

        [TestMethod()]
        public void UpdateSiteColumnLookup()
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
                var result2 = context.Runspace.InvokeCommand<ColumnLookup>(
                    "New-KshColumnLookup",
                    new Dictionary<string, object>()
                    {
                        { "AllowMultipleValues", true },
                        { "LookupListId", context.AppSettings["List1Id"] },
                        { "LookupColumnName", context.AppSettings["Column1Name"] },
                        { "Name", "TestColumn0" },
                        { "Title", "Test Column 0" },
                        { "AddColumnInternalNameHint", true },
                        { "AddToDefaultView", true }
                    }
                );
                var result3 = context.Runspace.InvokeCommand<ColumnLookup>(
                    "Update-KshColumnLookup",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result2.ElementAt(0) },
                        { "AllowMultipleValues", false },
                        // { "ClientSideComponentId", null },
                        // { "ClientSideComponentProperties", null },
                        { "CustomFormatter", "{ \"txtContent\": \"@currentField\" }" },
                        { "Direction", "none" },
                        { "Description", "Test Column 0 Description" },
                        { "EnforceUniqueValues", false },
                        { "Group", "Test Group 0" },
                        { "Hidden", true },
                        { "Indexed", false },
                        { "JSLink", "clienttemplates.js" },
                        { "LookupListId", context.AppSettings["List1Id"] },
                        { "LookupColumnName", context.AppSettings["Column2Name"] },
                        { "NoCrawl", true },
                        { "ReadOnly", true },
                        { "RelationshipDeleteBehavior", "None" },
                        { "Required", true },
                        { "StaticName", "TestColumn0" },
                        { "Title", "Test Column 0" },
                        { "UnlimitedLengthInDocumentLibrary", true },
                        { "PassThru", true }
                    }
                );
                var result4 = context.Runspace.InvokeCommand(
                    "Update-KshColumnLookup",
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
        public void UpdateSiteColumnLookupMulti()
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
                var result2 = context.Runspace.InvokeCommand<ColumnLookup>(
                    "New-KshColumnLookup",
                    new Dictionary<string, object>()
                    {
                        { "AllowMultipleValues", false },
                        { "LookupListId", context.AppSettings["List1Id"] },
                        { "LookupColumnName", context.AppSettings["Column1Name"] },
                        { "Name", "TestColumn0" },
                        { "Title", "Test Column 0" },
                        { "AddColumnInternalNameHint", true },
                        { "AddToDefaultView", true }
                    }
                );
                var result3 = context.Runspace.InvokeCommand<ColumnLookup>(
                    "Update-KshColumnLookup",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result2.ElementAt(0) },
                        // { "ClientSideComponentId", null },
                        // { "ClientSideComponentProperties", null },
                        { "AllowMultipleValues", true },
                        { "CustomFormatter", "{ \"txtContent\": \"@currentField\" }" },
                        { "Direction", "none" },
                        { "Description", "Test Column 0 Description" },
                        { "EnforceUniqueValues", false },
                        { "Group", "Test Group 0" },
                        { "Hidden", true },
                        { "Indexed", false },
                        { "JSLink", "clienttemplates.js" },
                        { "LookupListId", context.AppSettings["List1Id"] },
                        { "LookupColumnName", context.AppSettings["Column2Name"] },
                        { "NoCrawl", true },
                        { "ReadOnly", true },
                        { "RelationshipDeleteBehavior", "None" },
                        { "Required", true },
                        { "StaticName", "TestColumn0" },
                        { "Title", "Test Column 0" },
                        { "UnlimitedLengthInDocumentLibrary", true },
                        { "PassThru", true }
                    }
                );
                var result4 = context.Runspace.InvokeCommand(
                    "Update-KshColumnLookup",
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

    }

}
