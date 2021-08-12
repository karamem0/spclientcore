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
    [TestCategory("Get-KshChange")]
    public class GetChangeCommandTests
    {

        [TestMethod()]
        public void GetSiteCollectionChanges()
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
                var result2 = context.Runspace.InvokeCommand<Change>(
                    "Get-KshChange",
                    new Dictionary<string, object>()
                    {
                        { "SiteCollection", true },
                        { "FetchLimit", 10 },
                        { "Objects", "All" },
                        { "Operations", "All" },
                        { "RecursiveAll", true }
                    }
                );
                var actual = result2.ToArray();
            }
        }

        [TestMethod()]
        public void GetSiteChanges()
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
                var result2 = context.Runspace.InvokeCommand<Change>(
                    "Get-KshChange",
                    new Dictionary<string, object>()
                    {
                        { "Site", true },
                        { "FetchLimit", 10 },
                        { "Objects", "All" },
                        { "Operations", "All" },
                        { "RecursiveAll", true }
                    }
                );
                var actual = result2.ToArray();
            }
        }

        [TestMethod()]
        public void GetListChanges()
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
                var result3 = context.Runspace.InvokeCommand<Change>(
                    "Get-KshChange",
                    new Dictionary<string, object>()
                    {
                        { "List", result2.ElementAt(0) },
                        { "FetchLimit", 10 },
                        { "Objects", "All" },
                        { "Operations", "All" },
                        { "RecursiveAll", true }
                    }
                );
                var actual = result3.ToArray();
            }
        }

    }

}
