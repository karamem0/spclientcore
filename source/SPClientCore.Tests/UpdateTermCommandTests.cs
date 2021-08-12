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
    [TestCategory("Update-KshTerm")]
    public class UpdateTermCommandTests
    {

        [TestMethod()]
        public void UpdateTerm()
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
                var result2 = context.Runspace.InvokeCommand<TermGroup>(
                    "Get-KshTermGroup",
                    new Dictionary<string, object>()
                    {
                        { "TermGroupId", context.AppSettings["TermGroup1Id"] }
                    }
                );
                var result3 = context.Runspace.InvokeCommand<TermSet>(
                    "Get-KshTermSet",
                    new Dictionary<string, object>()
                    {
                        { "TermGroup", result2.ElementAt(0) },
                        { "TermSetId", context.AppSettings["TermSet1Id"] }
                    }
                );
                var result4 = context.Runspace.InvokeCommand<Term>(
                    "New-KshTerm",
                    new Dictionary<string, object>()
                    {
                        { "TermSet", result3.ElementAt(0) },
                        { "Lcid", 1033 },
                        { "Name", "Test Term 0" }
                    }
                );
                var result5 = context.Runspace.InvokeCommand<Term>(
                    "Update-KshTerm",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result4.ElementAt(0) },
                        { "IsAvailableForTagging", true },
                        { "Name", "Test Term 9" },
                        { "Owner", context.AppSettings["User1LoginName"] },
                        { "PassThru", true }
                    }
                );
                var result6 = context.Runspace.InvokeCommand(
                    "Remove-KshTerm",
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
