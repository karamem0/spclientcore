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
    [TestCategory("Get-KshGroupMember")]
    public class GetGroupMemberCommandTests
    {

        [TestMethod()]
        public void GetGroupMembers()
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
                var result2 = context.Runspace.InvokeCommand<Group>(
                    "Get-KshGroup",
                    new Dictionary<string, object>()
                    {
                        { "GroupId", context.AppSettings["Group1Id"] }
                    }
                );
                var result3 = context.Runspace.InvokeCommand<User>(
                    "Get-KshGroupMember",
                    new Dictionary<string, object>()
                    {
                        { "Group", result2.ElementAt(0) }
                    }
                );
                var actual = result3.ToArray();
            }
        }

        [TestMethod()]
        public void GetGroupMemberByMemberId()
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
                var result2 = context.Runspace.InvokeCommand<Group>(
                    "Get-KshGroup",
                    new Dictionary<string, object>()
                    {
                        { "GroupId", context.AppSettings["Group1Id"] }
                    }
                );
                var result3 = context.Runspace.InvokeCommand<User>(
                    "Get-KshGroupMember",
                    new Dictionary<string, object>()
                    {
                        { "Group", result2.ElementAt(0) },
                        { "MemberId", context.AppSettings["User1Id"] }
                    }
                );
                var actual = result3.ElementAt(0);
            }
        }

        [TestMethod()]
        public void GetGroupMemberByMemberLoginName()
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
                var result2 = context.Runspace.InvokeCommand<Group>(
                    "Get-KshGroup",
                    new Dictionary<string, object>()
                    {
                        { "GroupId", context.AppSettings["Group1Id"] }
                    }
                );
                var result3 = context.Runspace.InvokeCommand<User>(
                    "Get-KshGroupMember",
                    new Dictionary<string, object>()
                    {
                        { "Group", result2.ElementAt(0) },
                        { "MemberName", context.AppSettings["User1LoginName"] }
                    }
                );
                var actual = result3.ElementAt(0);
            }
        }

        [TestMethod()]
        public void GetGroupMemberByMemberEmail()
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
                var result2 = context.Runspace.InvokeCommand<Group>(
                    "Get-KshGroup",
                    new Dictionary<string, object>()
                    {
                        { "GroupId", context.AppSettings["Group1Id"] }
                    }
                );
                var result3 = context.Runspace.InvokeCommand<User>(
                    "Get-KshGroupMember",
                    new Dictionary<string, object>()
                    {
                        { "Group", result2.ElementAt(0) },
                        { "MemberName", context.AppSettings["User1Email"] },
                    }
                );
                var actual = result3.ElementAt(0);
            }
        }

    }

}
