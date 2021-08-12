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
    [TestCategory("Update-KshTermLabel")]
    public class UpdateTermLabelCommandTests
    {

        [TestMethod()]
        public void UpdateTermLabelLcid()
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
                    "Get-KshTerm",
                    new Dictionary<string, object>()
                    {
                        { "TermSet", result3.ElementAt(0) },
                        { "TermId", context.AppSettings["Term1Id"] },
                    }
                );
                var result5 = context.Runspace.InvokeCommand<TermLabel>(
                    "New-KshTermLabel",
                    new Dictionary<string, object>()
                    {
                        { "Term", result4.ElementAt(0) },
                        { "Name", "Test Term 0" },
                        { "Lcid", 1033 },
                        { "IsDefault", false }
                    }
                );
                var result6 = context.Runspace.InvokeCommand<TermLabel>(
                    "Update-KshTermLabel",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result5.ElementAt(0) },
                        { "Lcid", 1041 },
                        { "PassThru", true }
                    }
                );
                var result7 = context.Runspace.InvokeCommand(
                    "Remove-KshTermLabel",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result6.ElementAt(0) }
                    }
                );
                var actual = result6.ElementAt(0);
            }
        }

        [TestMethod()]
        public void UpdateTermLabelName()
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
                    "Get-KshTerm",
                    new Dictionary<string, object>()
                    {
                        { "TermSet", result3.ElementAt(0) },
                        { "TermId", context.AppSettings["Term1Id"] },
                    }
                );
                var result5 = context.Runspace.InvokeCommand<TermLabel>(
                    "New-KshTermLabel",
                    new Dictionary<string, object>()
                    {
                        { "Term", result4.ElementAt(0) },
                        { "Name", "Test Term 0" },
                        { "Lcid", 1033 },
                        { "IsDefault", false }
                    }
                );
                var result6 = context.Runspace.InvokeCommand<TermLabel>(
                    "Update-KshTermLabel",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result5.ElementAt(0) },
                        { "Name", "Test Term 9" },
                        { "PassThru", true }
                    }
                );
                var result7 = context.Runspace.InvokeCommand(
                    "Remove-KshTermLabel",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result6.ElementAt(0) }
                    }
                );
                var actual = result6.ElementAt(0);
            }
        }

        [TestMethod()]
        public void UpdateTermLabelIsDefault()
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
                    "Get-KshTerm",
                    new Dictionary<string, object>()
                    {
                        { "TermSet", result3.ElementAt(0) },
                        { "TermId", context.AppSettings["Term1Id"] },
                    }
                );
                var result5 = context.Runspace.InvokeCommand<TermLabel>(
                    "New-KshTermLabel",
                    new Dictionary<string, object>()
                    {
                        { "Term", result4.ElementAt(0) },
                        { "Name", "Test Term 0" },
                        { "Lcid", 1033 },
                        { "IsDefault", false }
                    }
                );
                var result6 = context.Runspace.InvokeCommand<TermLabel>(
                    "Update-KshTermLabel",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result5.ElementAt(0) },
                        { "IsDefault", true },
                        { "PassThru", true }
                    }
                );
                var result7 = context.Runspace.InvokeCommand<TermLabel>(
                    "Get-KshTermLabel",
                    new Dictionary<string, object>()
                    {
                        { "Term", result4.ElementAt(0) },
                        { "LabelName", context.AppSettings["Term1Name"] }
                    }
                );
                var result8 = context.Runspace.InvokeCommand(
                    "Update-KshTermLabel",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result7.ElementAt(0) },
                        { "IsDefault", true }
                    }
                );
                var result9 = context.Runspace.InvokeCommand(
                    "Remove-KshTermLabel",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result6.ElementAt(0) }
                    }
                );
                var actual = result6.ElementAt(0);
            }
        }

    }

}
