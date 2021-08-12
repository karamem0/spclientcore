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
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Karamem0.SharePoint.PowerShell.Tests
{

    [TestClass()]
    [TestCategory("Set-KshUniqueRoleAssignmentEnabled")]
    public class SetUniqueRoleAssignmentEnabledCommandTests
    {

        [TestMethod()]
        public void DisableSiteUniqueRoleAssignment()
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
                    "New-KshSite",
                    new Dictionary<string, object>()
                    {
                        { "ServerRelativeUrl", "TestSite0" }
                    }
                );
                var result3 = context.Runspace.InvokeCommand<Site>(
                    "Select-KshSite",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result2.ElementAt(0) },
                        { "PassThru", true }
                    }
                );
                var result4 = context.Runspace.InvokeCommand(
                    "Set-KshUniqueRoleAssignmentEnabled",
                    new Dictionary<string, object>()
                    {
                        { "Site", true },
                        { "Enabled", true }
                    }
                );
                var result5 = context.Runspace.InvokeCommand(
                    "Set-KshUniqueRoleAssignmentEnabled",
                    new Dictionary<string, object>()
                    {
                        { "Site", true },
                        { "Disabled", true }
                    }
                );
                var result6 = context.Runspace.InvokeCommand<Site>(
                    "Get-KshSite",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result3.ElementAt(0) }
                    }
                );
                var result7 = context.Runspace.InvokeCommand(
                    "Remove-KshSite",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result3.ElementAt(0) }
                    }
                );
                var actual = result6.ElementAt(0);
            }
        }

        [TestMethod()]
        public void DisableListUniqueRoleAssignment()
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
                    "New-KshList",
                    new Dictionary<string, object>()
                    {
                        { "Template", "GenericList" },
                        { "Title", "Test List 0" }
                    }
                );
                var result3 = context.Runspace.InvokeCommand(
                    "Set-KshUniqueRoleAssignmentEnabled",
                    new Dictionary<string, object>()
                    {
                        { "List", result2.ElementAt(0) },
                        { "Enabled", true }
                    }
                );
                var result4 = context.Runspace.InvokeCommand(
                    "Set-KshUniqueRoleAssignmentEnabled",
                    new Dictionary<string, object>()
                    {
                        { "List", result2.ElementAt(0) },
                        { "Disabled", true }
                    }
                );
                var result5 = context.Runspace.InvokeCommand<List>(
                    "Get-KshList",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result2.ElementAt(0) }
                    }
                );
                var result6 = context.Runspace.InvokeCommand(
                    "Remove-KshList",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result2.ElementAt(0) }
                    }
                );
                var actual = result5.ElementAt(0);
            }
        }

        [TestMethod()]
        public void DisableListItemUniqueRoleAssignment()
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
                    "New-KshListItem",
                    new Dictionary<string, object>()
                    {
                        { "List", result2.ElementAt(0) },
                        { "Value", new Hashtable() }
                    }
                );
                var result4 = context.Runspace.InvokeCommand(
                    "Set-KshUniqueRoleAssignmentEnabled",
                    new Dictionary<string, object>()
                    {
                        { "ListItem", result3.ElementAt(0) },
                        { "Enabled", true }
                    }
                );
                var result5 = context.Runspace.InvokeCommand(
                    "Set-KshUniqueRoleAssignmentEnabled",
                    new Dictionary<string, object>()
                    {
                        { "ListItem", result3.ElementAt(0) },
                        { "Disabled", true }
                    }
                );
                var result6 = context.Runspace.InvokeCommand<ListItem>(
                    "Get-KshListItem",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result3.ElementAt(0) }
                    }
                );
                var result7 = context.Runspace.InvokeCommand(
                    "Remove-KshListItem",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result3.ElementAt(0) }
                    }
                );
                var actual = result6.ElementAt(0);
            }
        }

        [TestMethod()]
        public void EnableSiteUniqueRoleAssignment()
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
                    "New-KshSite",
                    new Dictionary<string, object>()
                    {
                        { "ServerRelativeUrl", "TestSite0" }
                    }
                );
                var result3 = context.Runspace.InvokeCommand<Site>(
                    "Select-KshSite",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result2.ElementAt(0) },
                        { "PassThru", true }
                    }
                );
                var result4 = context.Runspace.InvokeCommand(
                    "Set-KshUniqueRoleAssignmentEnabled",
                    new Dictionary<string, object>()
                    {
                        { "Site", true },
                        { "Enabled", true },
                        { "CopyRoleAssignments", true },
                        { "ClearSubscopes", true }
                    }
                );
                var result5 = context.Runspace.InvokeCommand<Site>(
                    "Get-KshSite",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result3.ElementAt(0) }
                    }
                );
                var result6 = context.Runspace.InvokeCommand(
                    "Set-KshUniqueRoleAssignmentEnabled",
                    new Dictionary<string, object>()
                    {
                        { "Site", true },
                        { "Disabled", true }
                    }
                );
                var result7 = context.Runspace.InvokeCommand(
                    "Remove-KshSite",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result3.ElementAt(0) }
                    }
                );
                var actual = result5.ElementAt(0);
            }
        }

        [TestMethod()]
        public void EnableListUniqueRoleAssignment()
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
                    "New-KshList",
                    new Dictionary<string, object>()
                    {
                        { "Template", "GenericList" },
                        { "Title", "Test List 0" }
                    }
                );
                var result3 = context.Runspace.InvokeCommand(
                    "Set-KshUniqueRoleAssignmentEnabled",
                    new Dictionary<string, object>()
                    {
                        { "List", result2.ElementAt(0) },
                        { "Enabled", true },
                        { "CopyRoleAssignments", true },
                        { "ClearSubscopes", true }
                    }
                );
                var result4 = context.Runspace.InvokeCommand<List>(
                    "Get-KshList",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result2.ElementAt(0) }
                    }
                );
                var result5 = context.Runspace.InvokeCommand(
                    "Set-KshUniqueRoleAssignmentEnabled",
                    new Dictionary<string, object>()
                    {
                        { "List", result2.ElementAt(0) },
                        { "Disabled", true }
                    }
                );
                var result6 = context.Runspace.InvokeCommand(
                    "Remove-KshList",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result2.ElementAt(0) }
                    }
                );
                var actual = result4.ElementAt(0);
            }
        }

        [TestMethod()]
        public void EnableListItemUniqueRoleAssignment()
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
                    "New-KshListItem",
                    new Dictionary<string, object>()
                    {
                        { "List", result2.ElementAt(0) },
                        { "Value", new Hashtable() }
                    }
                );
                var result4 = context.Runspace.InvokeCommand(
                    "Set-KshUniqueRoleAssignmentEnabled",
                    new Dictionary<string, object>()
                    {
                        { "ListItem", result3.ElementAt(0) },
                        { "Enabled", true },
                        { "CopyRoleAssignments", true },
                        { "ClearSubscopes", true }
                    }
                );
                var result5 = context.Runspace.InvokeCommand<ListItem>(
                    "Get-KshListItem",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result3.ElementAt(0) }
                    }
                );
                var result6 = context.Runspace.InvokeCommand(
                    "Set-KshUniqueRoleAssignmentEnabled",
                    new Dictionary<string, object>()
                    {
                        { "ListItem", result3.ElementAt(0) },
                        { "Disabled", true }
                    }
                );
                var result7 = context.Runspace.InvokeCommand(
                    "Remove-KshListItem",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result3.ElementAt(0) }
                    }
                );
                var actual = result5.ElementAt(0);
            }
        }

    }

}
