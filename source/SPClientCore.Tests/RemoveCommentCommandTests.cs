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
    [TestCategory("Remove-KshComment")]
    public class RemoveCommentCommandTests
    {

        [TestMethod()]
        public void RemoveComment()
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
                        { "PageName", "Test Site Page 0" },
                        { "PageLayoutType", "Article" }
                    }
                );
                var result4 = context.Runspace.InvokeCommand<Folder>(
                    "Get-KshFolder",
                    new Dictionary<string, object>()
                    {
                        { "List", result2.ElementAt(0) }
                    }
                );
                var result5 = context.Runspace.InvokeCommand<File>(
                    "Get-KshFile",
                    new Dictionary<string, object>()
                    {
                        { "Folder", result4.ElementAt(0) },
                        { "FileName", "Test Site Page 0.aspx" }
                    }
                );
                var result6 = context.Runspace.InvokeCommand<ListItem>(
                    "Get-KshListItem",
                    new Dictionary<string, object>()
                    {
                        { "File", result5.ElementAt(0) }
                    }
                );
                var result7 = context.Runspace.InvokeCommand<Comment>(
                    "New-KshComment",
                    new Dictionary<string, object>()
                    {
                        { "ListItem", result6.ElementAt(0) },
                        { "Text", "Test Comment 0" }
                    }
                );
                var result8 = context.Runspace.InvokeCommand(
                    "Remove-KshComment",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result7.ElementAt(0) }
                    }
                );
                var result9 = context.Runspace.InvokeCommand(
                    "Remove-KshFile",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result5.ElementAt(0) }
                    }
                );
            }
        }

    }

}
