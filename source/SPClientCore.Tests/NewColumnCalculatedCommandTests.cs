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
    [TestCategory("New-KshColumnCalculated")]
    public class NewColumnCalculatedCommandTests
    {

        [TestMethod()]
        public void CreateListColumnCalculatedOfBoolean()
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
                var result3 = context.Runspace.InvokeCommand<Column>(
                    "Get-KshColumn",
                    new Dictionary<string, object>()
                    {
                        { "List", result2.ElementAt(0) },
                        { "ColumnId", context.AppSettings["Column10Id"] }
                    }
                );
                var result4 = context.Runspace.InvokeCommand<ColumnCalculated>(
                    "New-KshColumnCalculated",
                    new Dictionary<string, object>()
                    {
                        { "List", result2.ElementAt(0) },
                        // { "ClientSideComponentId", null },
                        // { "ClientSideComponentProperties", null },
                        { "Columns", new[] { result3.ElementAt(0) } },
                        { "CustomFormatter", "{ \"txtContent\": \"@currentField\" }" },
                        { "Description", "Test Column 0 Description" },
                        { "Direction", "none" },
                        { "Formula", "=[Test Column 10]" },
                        { "Group", "Test Column 0 Group" },
                        { "Hidden", true },
                        { "Id", "35aa78a6-66d7-472c-ab6b-d534193842af" },
                        { "JSLink", "clienttemplates.js" },
                        { "Name", "TestColumn0" },
                        { "NoCrawl", true },
                        { "OutputType", "Boolean" },
                        { "StaticName", "TestColumn0" },
                        { "Title", "Test Column 0" },
                        { "AddColumnInternalNameHint", true },
                        { "AddToDefaultView", true }
                    }
                );
                var result5 = context.Runspace.InvokeCommand(
                    "Update-KshColumnCalculated",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result4.ElementAt(0) },
                        { "Hidden", false }
                    }
                );
                var result6 = context.Runspace.InvokeCommand(
                    "Remove-KshColumn",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result4.ElementAt(0) }
                    }
                );
                var actual = result3.ElementAt(0);
            }
        }

        [TestMethod()]
        public void CreateListColumnCalculatedOfCurrency()
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
                var result3 = context.Runspace.InvokeCommand<Column>(
                    "Get-KshColumn",
                    new Dictionary<string, object>()
                    {
                        { "List", result2.ElementAt(0) },
                        { "ColumnId", context.AppSettings["Column6Id"] }
                    }
                );
                var result4 = context.Runspace.InvokeCommand<ColumnCalculated>(
                    "New-KshColumnCalculated",
                    new Dictionary<string, object>()
                    {
                        { "List", result2.ElementAt(0) },
                        // { "ClientSideComponentId", null },
                        // { "ClientSideComponentProperties", null },
                        { "Columns", new[] { result3.ElementAt(0) } },
                        { "CurrencyLcid", 1041 },
                        { "CustomFormatter", "{ \"txtContent\": \"@currentField\" }" },
                        { "Description", "Test Column 0 Description" },
                        { "Direction", "none" },
                        { "Formula", "=[Test Column 6]" },
                        { "Group", "Test Column 0 Group" },
                        { "Hidden", true },
                        { "Id", "35aa78a6-66d7-472c-ab6b-d534193842af" },
                        { "JSLink", "clienttemplates.js" },
                        { "Name", "TestColumn0" },
                        { "NoCrawl", true },
                        { "NumberFormat", 2 },
                        { "OutputType", "Currency" },
                        { "StaticName", "TestColumn0" },
                        { "Title", "Test Column 0" },
                        { "AddColumnInternalNameHint", true },
                        { "AddToDefaultView", true }
                    }
                );
                var result5 = context.Runspace.InvokeCommand(
                    "Update-KshColumnCalculated",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result4.ElementAt(0) },
                        { "Hidden", false }
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
        public void CreateListColumnCalculatedOfDateTime()
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
                var result3 = context.Runspace.InvokeCommand<Column>(
                    "Get-KshColumn",
                    new Dictionary<string, object>()
                    {
                        { "List", result2.ElementAt(0) },
                        { "ColumnId", context.AppSettings["Column7Id"] }
                    }
                );
                var result4 = context.Runspace.InvokeCommand<ColumnCalculated>(
                    "New-KshColumnCalculated",
                    new Dictionary<string, object>()
                    {
                        { "List", result2.ElementAt(0) },
                        // { "ClientSideComponentId", null },
                        // { "ClientSideComponentProperties", null },
                        { "Columns", new[] { result3.ElementAt(0) } },
                        { "CustomFormatter", "{ \"txtContent\": \"@currentField\" }" },
                        { "DateFormat", "DateTime" },
                        { "Description", "Test Column 0 Description" },
                        { "Direction", "none" },
                        { "Formula", "=[Test Column 7]" },
                        { "Group", "Test Column 0 Group" },
                        { "Hidden", true },
                        { "Id", "35aa78a6-66d7-472c-ab6b-d534193842af" },
                        { "JSLink", "clienttemplates.js" },
                        { "Name", "TestColumn0" },
                        { "NoCrawl", true },
                        { "OutputType", "DateTime" },
                        { "StaticName", "TestColumn0" },
                        { "Title", "Test Column 0" },
                        { "AddColumnInternalNameHint", true },
                        { "AddToDefaultView", true }
                    }
                );
                var result5 = context.Runspace.InvokeCommand(
                    "Update-KshColumnCalculated",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result4.ElementAt(0) },
                        { "Hidden", false }
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
        public void CreateListColumnCalculatedOfNumber()
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
                var result3 = context.Runspace.InvokeCommand<Column>(
                    "Get-KshColumn",
                    new Dictionary<string, object>()
                    {
                        { "List", result2.ElementAt(0) },
                        { "ColumnId", context.AppSettings["Column5Id"] },
                    }
                );
                var result4 = context.Runspace.InvokeCommand<ColumnCalculated>(
                    "New-KshColumnCalculated",
                    new Dictionary<string, object>()
                    {
                        { "List", result2.ElementAt(0) },
                        // { "ClientSideComponentId", null },
                        // { "ClientSideComponentProperties", null },
                        { "Columns", new[] { result3.ElementAt(0) } },
                        { "CustomFormatter", "{ \"txtContent\": \"@currentField\" }" },
                        { "Description", "Test Column 0 Description" },
                        { "Direction", "none" },
                        { "Formula", "=[Test Column 5]" },
                        { "Group", "Test Column 0 Group" },
                        { "Hidden", true },
                        { "Id", "35aa78a6-66d7-472c-ab6b-d534193842af" },
                        { "JSLink", "clienttemplates.js" },
                        { "Name", "TestColumn0" },
                        { "NoCrawl", true },
                        { "NumberFormat", 2 },
                        { "OutputType", "Number" },
                        { "ShowAsPercentage", true },
                        { "StaticName", "TestColumn0" },
                        { "Title", "Test Column 0" },
                        { "AddColumnInternalNameHint", true },
                        { "AddToDefaultView", true }
                    }
                );
                var result5 = context.Runspace.InvokeCommand(
                    "Update-KshColumnCalculated",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result4.ElementAt(0) },
                        { "Hidden", false }
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
        public void CreateListColumnCalculatedOfText()
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
                var result3 = context.Runspace.InvokeCommand<Column>(
                    "Get-KshColumn",
                    new Dictionary<string, object>()
                    {
                        { "List", result2.ElementAt(0) },
                        { "ColumnId", context.AppSettings["Column1Id"] },
                    }
                );
                var result4 = context.Runspace.InvokeCommand<Column>(
                    "Get-KshColumn",
                    new Dictionary<string, object>()
                    {
                        { "List", result2.ElementAt(0) },
                        { "ColumnId", context.AppSettings["Column3Id"] },
                    }
                );
                var result5 = context.Runspace.InvokeCommand<ColumnCalculated>(
                    "New-KshColumnCalculated",
                    new Dictionary<string, object>()
                    {
                        { "List", result2.ElementAt(0) },
                        // { "ClientSideComponentId", null },
                        // { "ClientSideComponentProperties", null },
                        { "Columns", new[] { result3.ElementAt(0), result4.ElementAt(0) } },
                        { "CustomFormatter", "{ \"txtContent\": \"@currentField\" }" },
                        { "Description", "Test Column 0 Description" },
                        { "Direction", "none" },
                        { "Formula", "=[Test Column 1]&[Test Column 3]" },
                        { "Group", "Test Column 0 Group" },
                        { "Hidden", true },
                        { "Id", "35aa78a6-66d7-472c-ab6b-d534193842af" },
                        { "JSLink", "clienttemplates.js" },
                        { "Name", "TestColumn0" },
                        { "NoCrawl", true },
                        { "OutputType", "Text" },
                        { "StaticName", "TestColumn0" },
                        { "Title", "Test Column 0" },
                        { "AddColumnInternalNameHint", true },
                        { "AddToDefaultView", true }
                    }
                );
                var result6 = context.Runspace.InvokeCommand(
                    "Update-KshColumnCalculated",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result5.ElementAt(0) },
                        { "Hidden", false }
                    }
                );
                var result7 = context.Runspace.InvokeCommand(
                    "Remove-KshColumn",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result5.ElementAt(0) }
                    }
                );
                var actual = result5.ElementAt(0);
            }
        }

        [TestMethod()]
        public void CreateSiteColumnCalculatedOfBoolean()
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
                var result2 = context.Runspace.InvokeCommand<Column>(
                    "Get-KshColumn",
                    new Dictionary<string, object>()
                    {
                        { "ColumnId", context.AppSettings["Column10Id"] }
                    }
                );
                var result3 = context.Runspace.InvokeCommand<ColumnCalculated>(
                    "New-KshColumnCalculated",
                    new Dictionary<string, object>()
                    {
                        // { "ClientSideComponentId", null },
                        // { "ClientSideComponentProperties", null },
                        { "Columns", new[] { result2.ElementAt(0) } },
                        { "CustomFormatter", "{ \"txtContent\": \"@currentField\" }" },
                        { "Description", "Test Column 0 Description" },
                        { "Direction", "none" },
                        { "Formula", "=TestColumn10" },
                        { "Group", "Test Column 0 Group" },
                        { "Hidden", true },
                        { "Id", "35aa78a6-66d7-472c-ab6b-d534193842af" },
                        // { "JSLink", "clienttemplates.js" },
                        { "Name", "TestColumn0" },
                        { "NoCrawl", true },
                        { "OutputType", "Boolean" },
                        { "StaticName", "TestColumn0" },
                        { "Title", "Test Column 0" },
                        { "AddColumnInternalNameHint", true },
                        { "AddToDefaultView", true }
                    }
                );
                var result4 = context.Runspace.InvokeCommand(
                    "Update-KshColumnCalculated",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result3.ElementAt(0) },
                        { "Hidden", false }
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
        public void CreateSiteColumnCalculatedOfCurrency()
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
                var result2 = context.Runspace.InvokeCommand<Column>(
                    "Get-KshColumn",
                    new Dictionary<string, object>()
                    {
                        { "ColumnId", context.AppSettings["Column6Id"] }
                    }
                );
                var result3 = context.Runspace.InvokeCommand<ColumnCalculated>(
                    "New-KshColumnCalculated",
                    new Dictionary<string, object>()
                    {
                        // { "ClientSideComponentId", null },
                        // { "ClientSideComponentProperties", null },
                        { "Columns", new[] { result2.ElementAt(0) } },
                        { "CurrencyLcid", 1041 },
                        { "CustomFormatter", "{ \"txtContent\": \"@currentField\" }" },
                        { "Description", "Test Column 0 Description" },
                        { "Direction", "none" },
                        { "Formula", "=TestColumn6" },
                        { "Group", "Test Column 0 Group" },
                        { "Hidden", true },
                        { "Id", "35aa78a6-66d7-472c-ab6b-d534193842af" },
                        // { "JSLink", "clienttemplates.js" },
                        { "Name", "TestColumn0" },
                        { "NoCrawl", true },
                        { "NumberFormat", 2 },
                        { "OutputType", "Currency" },
                        { "StaticName", "TestColumn0" },
                        { "Title", "Test Column 0" },
                        { "AddColumnInternalNameHint", true },
                        { "AddToDefaultView", true }
                    }
                );
                var result4 = context.Runspace.InvokeCommand(
                    "Update-KshColumnCalculated",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result3.ElementAt(0) },
                        { "Hidden", false }
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
        public void CreateSiteColumnCalculatedOfDateTime()
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
                var result2 = context.Runspace.InvokeCommand<Column>(
                    "Get-KshColumn",
                    new Dictionary<string, object>()
                    {
                        { "ColumnId", context.AppSettings["Column7Id"] }
                    }
                );
                var result3 = context.Runspace.InvokeCommand<ColumnCalculated>(
                    "New-KshColumnCalculated",
                    new Dictionary<string, object>()
                    {
                        // { "ClientSideComponentId", null },
                        // { "ClientSideComponentProperties", null },
                        { "Columns", new[] { result2.ElementAt(0) } },
                        { "CustomFormatter", "{ \"txtContent\": \"@currentField\" }" },
                        { "DateFormat", "DateTime" },
                        { "Description", "Test Column 0 Description" },
                        { "Direction", "none" },
                        { "Formula", "=TestColumn7" },
                        { "Group", "Test Column 0 Group" },
                        { "Hidden", true },
                        { "Id", "35aa78a6-66d7-472c-ab6b-d534193842af" },
                        // { "JSLink", "clienttemplates.js" },
                        { "Name", "TestColumn0" },
                        { "NoCrawl", true },
                        { "OutputType", "DateTime" },
                        { "StaticName", "TestColumn0" },
                        { "Title", "Test Column 0" },
                        { "AddColumnInternalNameHint", true },
                        { "AddToDefaultView", true }
                    }
                );
                var result4 = context.Runspace.InvokeCommand(
                    "Update-KshColumnCalculated",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result3.ElementAt(0) },
                        { "Hidden", false }
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
        public void CreateSiteColumnCalculatedOfNumber()
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
                var result2 = context.Runspace.InvokeCommand<Column>(
                    "Get-KshColumn",
                    new Dictionary<string, object>()
                    {
                        { "ColumnId", context.AppSettings["Column5Id"] }
                    }
                );
                var result3 = context.Runspace.InvokeCommand<ColumnCalculated>(
                    "New-KshColumnCalculated",
                    new Dictionary<string, object>()
                    {
                        // { "ClientSideComponentId", null },
                        // { "ClientSideComponentProperties", null },
                        { "Columns", new[] { result2.ElementAt(0) } },
                        { "CustomFormatter", "{ \"txtContent\": \"@currentField\" }" },
                        { "Description", "Test Column 0 Description" },
                        { "Direction", "none" },
                        { "Formula", "=TestColumn5" },
                        { "Group", "Test Column 0 Group" },
                        { "Hidden", true },
                        { "Id", "35aa78a6-66d7-472c-ab6b-d534193842af" },
                        // { "JSLink", "clienttemplates.js" },
                        { "Name", "TestColumn0" },
                        { "NoCrawl", true },
                        { "NumberFormat", 2 },
                        { "OutputType", "Number" },
                        { "ShowAsPercentage", true },
                        { "StaticName", "TestColumn0" },
                        { "Title", "Test Column 0" },
                        { "AddColumnInternalNameHint", true },
                        { "AddToDefaultView", true }
                    }
                );
                var result4 = context.Runspace.InvokeCommand(
                    "Update-KshColumnCalculated",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result3.ElementAt(0) },
                        { "Hidden", false }
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
        public void CreateSiteColumnCalculatedOfText()
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
                var result2 = context.Runspace.InvokeCommand<Column>(
                    "Get-KshColumn",
                    new Dictionary<string, object>()
                    {
                        { "ColumnId", context.AppSettings["Column1Id"] }
                    }
                );
                var result3 = context.Runspace.InvokeCommand<Column>(
                    "Get-KshColumn",
                    new Dictionary<string, object>()
                    {
                        { "ColumnId", context.AppSettings["Column3Id"] }
                    }
                );
                var result4 = context.Runspace.InvokeCommand<ColumnCalculated>(
                    "New-KshColumnCalculated",
                    new Dictionary<string, object>()
                    {
                        // { "ClientSideComponentId", null },
                        // { "ClientSideComponentProperties", null },
                        { "Columns", new[] { result2.ElementAt(0), result3.ElementAt(0) } },
                        { "CustomFormatter", "{ \"txtContent\": \"@currentField\" }" },
                        { "Description", "Test Column 0 Description" },
                        { "Direction", "none" },
                        { "Formula", "=TestColumn1&TestColumn3" },
                        { "Group", "Test Column 0 Group" },
                        { "Hidden", true },
                        { "Id", "35aa78a6-66d7-472c-ab6b-d534193842af" },
                        // { "JSLink", "clienttemplates.js" },
                        { "Name", "TestColumn0" },
                        { "NoCrawl", true },
                        { "OutputType", "Text" },
                        { "StaticName", "TestColumn0" },
                        { "Title", "Test Column 0" },
                        { "AddColumnInternalNameHint", true },
                        { "AddToDefaultView", true }
                    }
                );
                var result5 = context.Runspace.InvokeCommand(
                    "Update-KshColumnCalculated",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result4.ElementAt(0) },
                        { "Hidden", false }
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

    }

}
