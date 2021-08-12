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
    [TestCategory("Update-KshFolder")]
    public class UpdateFolderCommandTests
    {

        [TestMethod()]
        public void UpdateFolder()
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
                var result2 = context.Runspace.InvokeCommand<Folder>(
                    "Get-KshFolder",
                    new Dictionary<string, object>()
                    {
                        { "FolderUrl", context.AppSettings["Folder1Url"] }
                    }
                );
                var result3 = context.Runspace.InvokeCommand<Folder>(
                    "New-KshFolder",
                    new Dictionary<string, object>()
                    {
                        { "Folder", result2.ElementAt(0) },
                        { "FolderName", "Test Folder 0" }
                    }
                );
                var result4 = context.Runspace.InvokeCommand<ContentTypeId>(
                    "Initialize-KshContentTypeId",
                    new Dictionary<string, object>()
                    {
                        { "StringValue", context.AppSettings["ListContentType6Id"] },
                    }
                );
                var result5 = context.Runspace.InvokeCommand<Folder>(
                    "Update-KshFolder",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result3.ElementAt(0) },
                        { "UniqueContentTypeOrder", new[] { result4.ElementAt(0) } },
                        { "WelcomePage", "AllItems.aspx" },
                        { "PassThru", true }
                    }
                );
                var result6 = context.Runspace.InvokeCommand(
                    "Remove-KshFolder",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result5.ElementAt(0) }
                    }
                );
                var actual = result5.ElementAt(0);
            }
        }

    }

}
