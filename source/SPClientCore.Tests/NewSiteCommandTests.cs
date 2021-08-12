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
    [TestCategory("New-KshSite")]
    public class NewSiteCommandTests
    {

        [TestMethod()]
        public void CreateSite()
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
                var result2 = context.Runspace.InvokeCommand<Site>(
                    "New-KshSite",
                    new Dictionary<string, object>()
                    {
                        { "Description", "Test Site 0 Description" },
                        { "Lcid", 1033 },
                        { "ServerRelativeUrl", "TestSite0" },
                        { "Template", "SITEPAGEPUBLISHING#0" },
                        { "Title", "Test Site 0" },
                        { "UseSamePermissionsAsParentSite", true }
                    }
                );
                var result3 = context.Runspace.InvokeCommand(
                    "Remove-KshSite",
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
