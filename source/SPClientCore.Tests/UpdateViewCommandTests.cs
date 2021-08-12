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
    [TestCategory("Update-KshView")]
    public class UpdateViewCommandTests
    {

        [TestMethod()]
        public void UpdateView()
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
                var result3 = context.Runspace.InvokeCommand<View>(
                    "New-KshView",
                    new Dictionary<string, object>()
                    {
                        { "List", result2.ElementAt(0) },
                        { "Title", "Test View 0" },
                        { "ViewColumns", "Title" }
                    }
                );
                var result4 = context.Runspace.InvokeCommand<View>(
                    "Update-KshView",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result3.ElementAt(0) },
                        { "Aggregations", "<FieldRef Name='LinkTitle' Type='COUNT' />" },
                        { "AggregationsStatus", "On" },
                        { "AssociatedContentTypeId", null },
                        { "CalendarViewStyles", null },
                        { "CustomOrder", null },
                        // { "ContentTypeId", null },
                        { "DefaultView", true },
                        { "DefaultViewForContentType", true },
                        { "EditorModified", false },
                        { "Formats", "<FormatDef Type='RowHeight' Value='100' />" },
                        { "GridLayout", null },
                        { "Hidden", true },
                        { "IncludeRootFolder", true },
                        // { "ImageUrl", null },
                        { "JSLink", "clienttemplates.js" },
                        // { "ListViewXml", null },
                        // { "Method", null },
                        { "MobileDefaultView", true },
                        { "MobileView", true },
                        { "NewDocumentTemplates", context.AppSettings["Site1Url"] + "/TestList0/Forms/template.dotx" },
                        { "RowLimit", 10 },
                        { "Paged", false },
                        { "Scope", ViewScope.Recursive },
                        { "TabularView", false },
                        { "Title", "Test View 9" },
                        { "Toolbar", "Standard" },
                        { "ViewData", "" },
                        { "ViewJoins",
                            "<Join Type='LEFT' ListAlias='TestList1'>" +
                            "<Eq>" +
                            "<FieldRef Name='TestColumn8' RefType='Id'/>" +
                            "<FieldRef List='TestList1' Name='ID'/>" +
                            "</Eq>" +
                            "</Join>" },
                        { "ViewProjectedColumns", "<Field Name='TestColumn16' Type='Lookup' List='TestList1' ShowField='Title'/>" },
                        { "ViewQuery", "<OrderBy><FieldRef Name='Title'/></OrderBy>" },
                        { "ViewType2", null },
                        { "PassThru", true }
                    }
                );
                var result5 = context.Runspace.InvokeCommand(
                    "Remove-KshView",
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
