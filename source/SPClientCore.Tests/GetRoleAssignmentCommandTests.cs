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
    [TestCategory("Get-KshAssignment")]
    public class GetRoleAssignmentCommandTests
    {

        [TestMethod()]
        public void GetSiteRoleAssignments()
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
                var result2 = context.Runspace.InvokeCommand<RoleAssignment>(
                    "Get-KshRoleAssignment",
                    new Dictionary<string, object>()
                    {
                        { "Site", true }
                    }
                );
                var actual = result2.ToArray();
            }
        }

        [TestMethod()]
        public void GetListRoleAssignments()
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
                var result3 = context.Runspace.InvokeCommand<RoleAssignment>(
                    "Get-KshRoleAssignment",
                    new Dictionary<string, object>()
                    {
                        { "List", result2.ElementAt(0) }
                    }
                );
                var actual = result3.ToArray();
            }
        }

        [TestMethod()]
        public void GetListItemRoleAssignments()
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
                var result3 = context.Runspace.InvokeCommand<ListItem>(
                    "Get-KshListItem",
                    new Dictionary<string, object>()
                    {
                        { "List", result2.ElementAt(0) },
                        { "ItemId", context.AppSettings["ListItem1Id"] }
                    }
                );
                var result4 = context.Runspace.InvokeCommand<RoleAssignment>(
                    "Get-KshRoleAssignment",
                    new Dictionary<string, object>()
                    {
                        { "ListItem", result3.ElementAt(0) }
                    }
                );
                var actual = result4.ToArray();
            }
        }

        [TestMethod()]
        public void GetSiteRoleAssignmentByPrincipalId()
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
                var result2 = context.Runspace.InvokeCommand<Site>(
                    "Get-KshSite",
                    new Dictionary<string, object>()
                    {
                        { "SiteUrl", context.AppSettings["Site1Url"] }
                    }
                );
                var result3 = context.Runspace.InvokeCommand<RoleAssignment>(
                    "Get-KshRoleAssignment",
                    new Dictionary<string, object>()
                    {
                        { "Site", true },
                        { "PrincipalId", context.AppSettings["SiteRoleAssignment1Id"] }
                    }
                );
                var actual = result3.ToArray();
            }
        }

        [TestMethod()]
        public void GetListRoleAssignmentByPrincipalId()
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
                var result3 = context.Runspace.InvokeCommand<RoleAssignment>(
                    "Get-KshRoleAssignment",
                    new Dictionary<string, object>()
                    {
                        { "List", result2.ElementAt(0) },
                        { "PrincipalId", context.AppSettings["ListRoleAssignment1Id"] }
                    }
                );
                var actual = result3.ToArray();
            }
        }

        [TestMethod()]
        public void GetListItemRoleAssignmentByPrincipalId()
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
                var result3 = context.Runspace.InvokeCommand<ListItem>(
                    "Get-KshListItem",
                    new Dictionary<string, object>()
                    {
                        { "List", result2.ElementAt(0) },
                        { "ItemId", context.AppSettings["ListItem1Id"] }
                    }
                );
                var result4 = context.Runspace.InvokeCommand<RoleAssignment>(
                    "Get-KshRoleAssignment",
                    new Dictionary<string, object>()
                    {
                        { "ListItem", result3.ElementAt(0) },
                        { "PrincipalId", context.AppSettings["ListItemRoleAssignment1Id"] }
                    }
                );
                var actual = result4.ToArray();
            }
        }

    }

}
