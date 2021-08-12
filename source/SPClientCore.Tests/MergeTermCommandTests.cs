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
    [TestCategory("Merge-KshTerm")]
    public class MergeTermCommandTests
    {

        [TestMethod()]
        public void MergeTerm()
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
                    "Get-KshTerm",
                    new Dictionary<string, object>()
                    {
                        { "TermSet", result3.ElementAt(0) },
                        { "TermId", context.AppSettings["Term1Id"] }
                    }
                );
                var result6 = context.Runspace.InvokeCommand<Term>(
                    "Merge-KshTerm",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result4.ElementAt(0) },
                        { "ToMerge", result5.ElementAt(0) }
                    }
                );
                var result7 = context.Runspace.InvokeCommand<TermLabel>(
                    "Get-KshTermLabel",
                    new Dictionary<string, object>()
                    {
                        { "Term", result5.ElementAt(0) },
                        { "LabelName", "Test Term 0" }
                    }
                );
                var result8 = context.Runspace.InvokeCommand(
                    "Remove-KshTermLabel",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result7.ElementAt(0) }
                    }
                );
            }
        }

    }

}
