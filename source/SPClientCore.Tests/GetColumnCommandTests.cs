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
    [TestCategory("Get-KshColumn")]
    public class GetColumnCommandTests
    {

        [TestMethod()]
        public void GetListContentTypeColumns()
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
                var result4 = context.Runspace.InvokeCommand<Column>(
                    "Get-KshColumn",
                    new Dictionary<string, object>()
                    {
                        { "ContentType", result3.ElementAt(0) }
                    }
                );
                var actual = result4.ToArray();
            }
        }

        [TestMethod()]
        public void GetListContentTypeColumnByIdentity()
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
                var result4 = context.Runspace.InvokeCommand<Column>(
                    "Get-KshColumn",
                    new Dictionary<string, object>()
                    {
                        { "ContentType", result3.ElementAt(0) },
                        { "ColumnId", context.AppSettings["Column1Id"] }
                    }
                );
                var result5 = context.Runspace.InvokeCommand<Column>(
                    "Get-KshColumn",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result4.ElementAt(0) }
                    }
                );
                var actual = result5.ElementAt(0);
            }
        }

        [TestMethod()]
        public void GetListContentTypeColumnByColumnId()
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
                var result4 = context.Runspace.InvokeCommand<Column>(
                    "Get-KshColumn",
                    new Dictionary<string, object>()
                    {
                        { "ContentType", result3.ElementAt(0) },
                        { "ColumnId", context.AppSettings["Column1Id"] }
                    }
                );
                var actual = result4.ElementAt(0);
            }
        }

        [TestMethod()]
        public void GetListContentTypeColumnByColumnTitle()
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
                var result4 = context.Runspace.InvokeCommand<Column>(
                    "Get-KshColumn",
                    new Dictionary<string, object>()
                    {
                        { "ContentType", result3.ElementAt(0) },
                        { "ColumnTitle", context.AppSettings["Column1Title"] }
                    }
                );
                var actual = result4.ElementAt(0);
            }
        }

        [TestMethod()]
        public void GetSiteContentTypeColumns()
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
                var result3 = context.Runspace.InvokeCommand<Column>(
                    "Get-KshColumn",
                    new Dictionary<string, object>()
                    {
                        { "ContentType", result2.ElementAt(0) }
                    }
                );
                var actual = result2.ToArray();
            }
        }

        [TestMethod()]
        public void GetSiteContentTypeColumnByIdentity()
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
                var result3 = context.Runspace.InvokeCommand<Column>(
                    "Get-KshColumn",
                    new Dictionary<string, object>()
                    {
                        { "ContentType", result2.ElementAt(0) },
                        { "ColumnId", context.AppSettings["Column1Id"] }
                    }
                );
                var result4 = context.Runspace.InvokeCommand<Column>(
                    "Get-KshColumn",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result3.ElementAt(0) }
                    }
                );
                var actual = result4.ElementAt(0);
            }
        }

        [TestMethod()]
        public void GetSiteContentTypeColumnByColumnId()
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
                var result3 = context.Runspace.InvokeCommand<Column>(
                    "Get-KshColumn",
                    new Dictionary<string, object>()
                    {
                        { "ContentType", result2.ElementAt(0) },
                        { "ColumnId", context.AppSettings["Column1Id"] }
                    }
                );
                var actual = result3.ElementAt(0);
            }
        }

        [TestMethod()]
        public void GetSiteContentTypeColumnByColumnTitle()
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
                var result3 = context.Runspace.InvokeCommand<Column>(
                    "Get-KshColumn",
                    new Dictionary<string, object>()
                    {
                        { "ContentType", result2.ElementAt(0) },
                        { "ColumnTitle", context.AppSettings["Column1Title"] }
                    }
                );
                var actual = result3.ElementAt(0);
            }
        }

        [TestMethod()]
        public void GetListColumns()
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
                        { "List", result2.ElementAt(0) }
                    }
                );
                var actual = result3.ToArray();
            }
        }

        [TestMethod()]
        public void GetListColumnByIdentity()
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
                        { "ColumnId", context.AppSettings["Column1Id"] }
                    }
                );
                var result4 = context.Runspace.InvokeCommand<Column>(
                    "Get-KshColumn",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result3.ElementAt(0) }
                    }
                );
                var actual = result4.ElementAt(0);
            }
        }

        [TestMethod()]
        public void GetListColumnByColumnId()
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
                        { "ColumnId", context.AppSettings["Column1Id"] }
                    }
                );
                var actual = result3.ElementAt(0);
            }
        }

        [TestMethod()]
        public void GetListColumnByColumnTitle()
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
                        { "ColumnTitle", context.AppSettings["Column1Title"] }
                    }
                );
                var actual = result3.ElementAt(0);
            }
        }

        [TestMethod()]
        public void GetSiteColumns()
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
                    }
                );
                var actual = result2.ToArray();
            }
        }

        [TestMethod()]
        public void GetSiteColumnByIdentity()
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
                        { "Identity", result2.ElementAt(0) }
                    }
                );
                var actual = result3.ElementAt(0);
            }
        }

        [TestMethod()]
        public void GetSiteColumnByColumnId()
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
                var actual = result2.ElementAt(0);
            }
        }

        [TestMethod()]
        public void GetSiteColumnByColumnTitle()
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
                        { "ColumnTitle", context.AppSettings["Column1Title"] }
                    }
                );
                var actual = result2.ElementAt(0);
            }
        }

    }

}
