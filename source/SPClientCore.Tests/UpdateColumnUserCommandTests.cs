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
    [TestCategory("Update-KshColumnUser")]
    public class UpdateColumnUserCommandTests
    {

        [TestMethod()]
        public void UpdateListColumnUser()
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
                var result3 = context.Runspace.InvokeCommand<ColumnUser>(
                    "New-KshColumnUser",
                    new Dictionary<string, object>()
                    {
                        { "List", result2.ElementAt(0) },
                        { "AllowMultipleValues", true },
                        { "LookupColumnName", "Title" },
                        { "Name", "TestColumn0" },
                        { "SelectionGroupId", context.AppSettings["Group1Id"] },
                        { "SelectionMode", "PeopleOnly" },
                        { "Title", "Test Column 0" },
                        { "AddColumnInternalNameHint", true },
                        { "AddToDefaultView", true }
                    }
                );
                var result4 = context.Runspace.InvokeCommand<ColumnUser>(
                    "Update-KshColumnUser",
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
                        { "LookupColumnName", "EMail" },
                        { "NoCrawl", true },
                        { "ReadOnly", true },
                        { "Required", true },
                        { "RelationshipDeleteBehavior", "None" },
                        { "SelectionGroupId", context.AppSettings["Group2Id"] },
                        { "SelectionMode", "PeopleAndGroups" },
                        { "StaticName", "TestColumn0" },
                        { "Title", "Test Column 0" },
                        { "UnlimitedLengthInDocumentLibrary", true },
                        { "PassThru", true }
                    }
                );
                var result5 = context.Runspace.InvokeCommand(
                    "Update-KshColumnUser",
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
        public void UpdateListColumnUserMulti()
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
                var result3 = context.Runspace.InvokeCommand<ColumnUser>(
                    "New-KshColumnUser",
                    new Dictionary<string, object>()
                    {
                        { "List", result2.ElementAt(0) },
                        { "AllowMultipleValues", false },
                        { "LookupColumnName", "Title" },
                        { "Name", "TestColumn0" },
                        { "SelectionGroupId", context.AppSettings["Group1Id"] },
                        { "SelectionMode", "PeopleOnly" },
                        { "Title", "Test Column 0" },
                        { "AddColumnInternalNameHint", true },
                        { "AddToDefaultView", true }
                    }
                );
                var result4 = context.Runspace.InvokeCommand<ColumnUser>(
                    "Update-KshColumnUser",
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
                        { "LookupColumnName", "EMail" },
                        { "NoCrawl", true },
                        { "ReadOnly", true },
                        { "Required", true },
                        { "RelationshipDeleteBehavior", "None" },
                        { "SelectionGroupId", context.AppSettings["Group2Id"] },
                        { "SelectionMode", "PeopleAndGroups" },
                        { "StaticName", "TestColumn0" },
                        { "Title", "Test Column 0" },
                        { "UnlimitedLengthInDocumentLibrary", true },
                        { "PassThru", true }
                    }
                );
                var result5 = context.Runspace.InvokeCommand(
                    "Update-KshColumnUser",
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
        public void UpdateSiteColumnUser()
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
                var result2 = context.Runspace.InvokeCommand<ColumnUser>(
                    "New-KshColumnUser",
                    new Dictionary<string, object>()
                    {
                        { "AllowMultipleValues", true },
                        { "LookupColumnName", "Title" },
                        { "Name", "TestColumn0" },
                        { "SelectionGroupId", context.AppSettings["Group1Id"] },
                        { "SelectionMode", "PeopleOnly" },
                        { "Title", "Test Column 0" },
                        { "AddColumnInternalNameHint", true },
                        { "AddToDefaultView", true }
                    }
                );
                var result3 = context.Runspace.InvokeCommand<ColumnUser>(
                    "Update-KshColumnUser",
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
                        { "LookupColumnName", "EMail" },
                        { "NoCrawl", true },
                        { "ReadOnly", true },
                        { "Required", true },
                        { "RelationshipDeleteBehavior", "None" },
                        { "SelectionGroupId", context.AppSettings["Group2Id"] },
                        { "SelectionMode", "PeopleAndGroups" },
                        { "StaticName", "TestColumn0" },
                        { "Title", "Test Column 0" },
                        { "UnlimitedLengthInDocumentLibrary", true },
                        { "PassThru", true }
                    }
                );
                var result4 = context.Runspace.InvokeCommand(
                    "Update-KshColumnUser",
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
        public void UpdateSiteColumnUserMulti()
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
                var result2 = context.Runspace.InvokeCommand<ColumnUser>(
                    "New-KshColumnUser",
                    new Dictionary<string, object>()
                    {
                        { "AllowMultipleValues", false },
                        { "LookupColumnName", "Title" },
                        { "Name", "TestColumn0" },
                        { "SelectionGroupId", context.AppSettings["Group1Id"] },
                        { "SelectionMode", "PeopleOnly" },
                        { "Title", "Test Column 0" },
                        { "AddColumnInternalNameHint", true },
                        { "AddToDefaultView", true }
                    }
                );
                var result3 = context.Runspace.InvokeCommand<ColumnUser>(
                    "Update-KshColumnUser",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result2.ElementAt(0) },
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
                        { "LookupColumnName", "EMail" },
                        { "NoCrawl", true },
                        { "ReadOnly", true },
                        { "Required", true },
                        { "RelationshipDeleteBehavior", "None" },
                        { "SelectionGroupId", context.AppSettings["Group2Id"] },
                        { "SelectionMode", "PeopleAndGroups" },
                        { "StaticName", "TestColumn0" },
                        { "Title", "Test Column 0" },
                        { "UnlimitedLengthInDocumentLibrary", true },
                        { "PassThru", true }
                    }
                );
                var result4 = context.Runspace.InvokeCommand(
                    "Update-KshColumnUser",
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
