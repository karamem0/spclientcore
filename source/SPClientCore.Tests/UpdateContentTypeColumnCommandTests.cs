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
    [TestCategory("Update-KshContentTypeColumn")]
    public class UpdateContentTypeColumnCommandTests
    {

        [TestMethod()]
        public void UpdateListContentTypeColumn()
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
                var result3 = context.Runspace.InvokeCommand<ContentType>(
                    "Get-KshContentType",
                    new Dictionary<string, object>()
                    {
                        { "List", result2.ElementAt(0) },
                        { "ContentTypeId", context.AppSettings["ListContentType1Id"] }
                    }
                );
                var result4 = context.Runspace.InvokeCommand<ColumnText>(
                    "New-KshColumnText",
                    new Dictionary<string, object>()
                    {
                        { "Name", "TestColumn0" },
                        { "Title", "Test Column 0" }
                    }
                );
                var result5 = context.Runspace.InvokeCommand<ContentTypeColumn>(
                    "New-KshContentTypeColumn",
                    new Dictionary<string, object>()
                    {
                        { "ContentType", result3.ElementAt(0) },
                        { "Column", result4.ElementAt(0) }
                    }
                );
                var result6 = context.Runspace.InvokeCommand<ContentTypeColumn>(
                    "Update-KshContentTypeColumn",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result5.ElementAt(0) },
                        { "Hidden", true },
                        { "Required", true },
                        { "PassThru", true }
                    }
                );
                var result7 = context.Runspace.InvokeCommand(
                    "Remove-KshContentTypeColumn",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result5.ElementAt(0) }
                    }
                );
                var result8 = context.Runspace.InvokeCommand(
                    "Remove-KshColumn",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result4.ElementAt(0) }
                    }
                );
                var result9 = context.Runspace.InvokeCommand<Column>(
                    "Get-KshColumn",
                    new Dictionary<string, object>()
                    {
                        { "List", result2.ElementAt(0) },
                        { "ColumnId", result4.ElementAt(0).Id }
                    }
                );
                var result10 = context.Runspace.InvokeCommand(
                    "Remove-KshColumn",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result9.ElementAt(0) }
                    }
                );
                var actual = result6.ElementAt(0);
            }
        }

        [TestMethod()]
        public void UpdateSiteContentTypeColumn()
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
                var result2 = context.Runspace.InvokeCommand<ContentType>(
                    "Get-KshContentType",
                    new Dictionary<string, object>()
                    {
                        { "ContentTypeId", context.AppSettings["SiteContentType1Id"] }
                    }
                );
                var result3 = context.Runspace.InvokeCommand<ColumnText>(
                    "New-KshColumnText",
                    new Dictionary<string, object>()
                    {
                        { "Name", "TestColumn0" },
                        { "Title", "Test Column 0" }
                    }
                );
                var result4 = context.Runspace.InvokeCommand<ContentTypeColumn>(
                    "New-KshContentTypeColumn",
                    new Dictionary<string, object>()
                    {
                        { "ContentType", result2.ElementAt(0) },
                        { "Column", result3.ElementAt(0) }
                    }
                );
                var result6 = context.Runspace.InvokeCommand<ContentTypeColumn>(
                    "Update-KshContentTypeColumn",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result4.ElementAt(0) },
                        { "Hidden", true },
                        { "Required", true },
                        { "PassThru", true }
                    }
                );
                var result7 = context.Runspace.InvokeCommand(
                    "Remove-KshContentTypeColumn",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result4.ElementAt(0) }
                    }
                );
                var result8 = context.Runspace.InvokeCommand(
                    "Remove-KshColumn",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result3.ElementAt(0) }
                    }
                );
                var actual = result6.ElementAt(0);
            }
        }

    }

}
