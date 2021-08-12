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
    [TestCategory("Get-KshComment")]
    public class GetCommentCommandTests
    {

        [TestMethod()]
        public void GetComments()
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
                var result2 = context.Runspace.InvokeCommand<File>(
                    "Get-KshFile",
                    new Dictionary<string, object>()
                    {
                        { "FileUrl", context.AppSettings["SitePage1Url"] }
                    }
                );
                var result3 = context.Runspace.InvokeCommand<ListItem>(
                    "Get-KshListItem",
                    new Dictionary<string, object>()
                    {
                        { "File", result2.ElementAt(0) }
                    }
                );
                var result4 = context.Runspace.InvokeCommand<Comment>(
                    "Get-KshComment",
                    new Dictionary<string, object>()
                    {
                        { "ListItem", result3.ElementAt(0) }
                    }
                );
                var actual = result4.ToArray();
            }
        }

        [TestMethod()]
        public void GetCommentByIdentity()
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
                var result2 = context.Runspace.InvokeCommand<File>(
                    "Get-KshFile",
                    new Dictionary<string, object>()
                    {
                        { "FileUrl", context.AppSettings["SitePage1Url"] }
                    }
                );
                var result3 = context.Runspace.InvokeCommand<ListItem>(
                    "Get-KshListItem",
                    new Dictionary<string, object>()
                    {
                        { "File", result2.ElementAt(0) }
                    }
                );
                var result4 = context.Runspace.InvokeCommand<Comment>(
                    "Get-KshComment",
                    new Dictionary<string, object>()
                    {
                        { "ListItem", result3.ElementAt(0) },
                        { "CommentId", context.AppSettings["Comment1Id"] }
                    }
                );
                var result5 = context.Runspace.InvokeCommand<Comment>(
                    "Get-KshComment",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result4.ElementAt(0) }
                    }
                );
                var actual = result5.ElementAt(0);
            }
        }

        [TestMethod()]
        public void GetCommentByCommentId()
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
                var result2 = context.Runspace.InvokeCommand<File>(
                    "Get-KshFile",
                    new Dictionary<string, object>()
                    {
                        { "FileUrl", context.AppSettings["SitePage1Url"] }
                    }
                );
                var result3 = context.Runspace.InvokeCommand<ListItem>(
                    "Get-KshListItem",
                    new Dictionary<string, object>()
                    {
                        { "File", result2.ElementAt(0) }
                    }
                );
                var result4 = context.Runspace.InvokeCommand<Comment>(
                    "Get-KshComment",
                    new Dictionary<string, object>()
                    {
                        { "ListItem", result3.ElementAt(0) },
                        { "CommentId", context.AppSettings["Comment1Id"] }
                    }
                );
                var actual = result4.ElementAt(0);
            }
        }

    }

}
