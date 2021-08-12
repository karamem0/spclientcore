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
    [TestCategory("New-KshNavigationNode")]
    public class NewNavigationNodeCommandTests
    {

        [TestMethod()]
        public void CreateNavigationNode()
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
                var result2 = context.Runspace.InvokeCommand<NavigationNode>(
                    "Get-KshNavigationNode",
                    new Dictionary<string, object>()
                    {
                        { "NavigationNodeId", context.AppSettings["NavigationNode1Id"] }
                    }
                );
                var result3 = context.Runspace.InvokeCommand<NavigationNode>(
                    "New-KshNavigationNode",
                    new Dictionary<string, object>()
                    {
                        { "NavigationNode", result2.ElementAt(0) },
                        { "AsLastNode", true },
                        { "IsExternal", true },
                        { "Title", "Test Navigation Node 0" },
                        { "Url", "http://www.example.com" }
                    }
                );
                var result4 = context.Runspace.InvokeCommand(
                    "Remove-KshNavigationNode",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result3.ElementAt(0) }
                    }
                );
                var actual = result3.ElementAt(0);
            }
        }

        [TestMethod()]
        public void CreateNavigationNodeToQuickLaunch()
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
                var result2 = context.Runspace.InvokeCommand<NavigationNode>(
                    "New-KshNavigationNode",
                    new Dictionary<string, object>()
                    {
                        { "QuickLaunch", true },
                        { "AsLastNode", true },
                        { "IsExternal", true },
                        { "Title", "Test Navigation Node 0" },
                        { "Url", "http://www.example.com" }
                    }
                );
                var result3 = context.Runspace.InvokeCommand(
                    "Remove-KshNavigationNode",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result2.ElementAt(0) }
                    }
                );
                var actual = result2.ElementAt(0);
            }
        }

        [TestMethod()]
        public void CreateNavigationNodeToTopNavigationBar()
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
                var result2 = context.Runspace.InvokeCommand<NavigationNode>(
                    "New-KshNavigationNode",
                    new Dictionary<string, object>()
                    {
                        { "TopNavigationBar", true },
                        { "AsLastNode", true },
                        { "IsExternal", true },
                        { "Title", "Test Navigation Node 0" },
                        { "Url", "http://www.example.com" }
                    }
                );
                var result3 = context.Runspace.InvokeCommand(
                    "Remove-KshNavigationNode",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result2.ElementAt(0) }
                    }
                );
                var actual = result2.ElementAt(0);
            }
        }

    }

}
