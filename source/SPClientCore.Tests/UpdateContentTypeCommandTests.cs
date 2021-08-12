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
    [TestCategory("Update-KshContentType")]
    public class UpdateContentTypeCommandTests
    {

        [TestMethod()]
        public void UpdateListContentType()
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
                    "New-KshContentType",
                    new Dictionary<string, object>()
                    {
                        { "List", result2.ElementAt(0) },
                        { "Name", "Test Content Type 0" }
                    }
                );
                var result4 = context.Runspace.InvokeCommand<ContentType>(
                    "Update-KshContentType",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result3.ElementAt(0) },
                        { "Description", "Test Content Type 9 Description" },
                        { "DisplayFormUrl", context.AppSettings["Site1Url"] + "/TestList9/Forms/DispForm.aspx" },
                        { "EditFormUrl", context.AppSettings["Site1Url"] + "/TestList9/Forms/EditForm.aspx" },
                        { "Group", "Test Content Type 9 Group" },
                        { "Hidden", true },
                        { "JSLink", context.AppSettings["Site1Url"] + "/TestList9/Forms/JSLink.js" },
                        { "Name", "Test Content Type 9" },
                        { "NewFormUrl", context.AppSettings["Site1Url"] + "/TestList9/Forms/Upload.aspx" },
                        { "ReadOnly", true },
                        { "Sealed", true },
                        { "PassThru", true }
                    }
                );
                var result5 = context.Runspace.InvokeCommand<ContentType>(
                    "Update-KshContentType",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result4.ElementAt(0) },
                        { "ReadOnly", false },
                        { "Sealed", false },
                        { "PassThru", true }
                    }
                );
                var result6 = context.Runspace.InvokeCommand(
                    "Remove-KshContentType",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result4.ElementAt(0) }
                    }
                );
                var actual = result4.ElementAt(0);
            }
        }

        [TestMethod()]
        public void UpdateSiteContentType()
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
                    "New-KshContentType",
                    new Dictionary<string, object>()
                    {
                        { "Name", "Test Content Type 0" }
                    }
                );
                var result3 = context.Runspace.InvokeCommand<ContentType>(
                    "Update-KshContentType",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result2.ElementAt(0) },
                        { "Description", "Test Content Type 9 Description" },
                        { "DisplayFormUrl", context.AppSettings["Site1Url"] + "/TestList9/Forms/DispForm.aspx" },
                        { "EditFormUrl", context.AppSettings["Site1Url"] + "/TestList9/Forms/EditForm.aspx" },
                        { "Group", "Test Content Type 9 Group" },
                        { "Hidden", true },
                        { "JSLink", context.AppSettings["Site1Url"] + "/TestList9/Forms/JSLink.js" },
                        { "Name", "Test Content Type 9" },
                        { "NewFormUrl", context.AppSettings["Site1Url"] + "/TestList9/Forms/Upload.aspx" },
                        { "ReadOnly", true },
                        { "Sealed", true },
                        { "PassThru", true }
                    }
                );
                var result4 = context.Runspace.InvokeCommand<ContentType>(
                    "Update-KshContentType",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result2.ElementAt(0) },
                        { "ReadOnly", false },
                        { "Sealed", false },
                        { "PassThru", true }
                    }
                );
                var result5 = context.Runspace.InvokeCommand(
                    "Remove-KshContentType",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result2.ElementAt(0) }
                    }
                );
                var actual = result3.ElementAt(0);
            }
        }

    }

}
