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
    [TestCategory("New-KshView")]
    public class NewViewCommandTests
    {

        [TestMethod()]
        public void CreateView()
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
                        { "Paged", true },
                        { "PersonalView", false },
                        { "RowLimit", 10 },
                        { "SetAsDefaultView", true },
                        { "Title", "Test View 0" },
                        { "ViewColumns", new[] { "Test Column 1", "Test Column 2", "Test Column 3" } },
                        { "ViewQuery", "<OrderBy><FieldRef Name='Title'/></OrderBy>" },
                        { "ViewType", "Html" }
                    }
                );
                var result4 = context.Runspace.InvokeCommand(
                    "Remove-KshView",
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
