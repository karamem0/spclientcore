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
    [TestCategory("Remove-KshRoleDefinition")]
    public class RemoveRoleDefinitionCommandTests
    {

        [TestMethod()]
        public void RemoveRoleDefinition()
        {
            using (var context = new PSCmdletContext())
            {
                var result1 = context.Runspace.InvokeCommand(
                    "Connect-KshSite",
                    new Dictionary<string, object>()
                    {
                        { "Url", context.AppSettings["BaseUrl"] },
                        { "Credential", PSCredentialFactory.CreateCredential(
                            context.AppSettings["LoginUserName"],
                            context.AppSettings["LoginPassword"])
                        }
                    }
                );
                var result2 = context.Runspace.InvokeCommand<BasePermission>(
                    "Initialize-KshBasePermission",
                    new Dictionary<string, object>()
                    {
                        { "Permission", "EmptyMask" },
                    }
                );
                var result3 = context.Runspace.InvokeCommand<RoleDefinition>(
                    "New-KshRoleDefinition",
                    new Dictionary<string, object>()
                    {
                        { "BasePermission", result2.ElementAt(0) },
                        { "Name", "Test Role Definition 0" }
                    }
                );
                var result4 = context.Runspace.InvokeCommand(
                    "Remove-KshRoleDefinition",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result3.ElementAt(0) }
                    }
                );
            }
        }

    }

}
