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
    [TestCategory("Add-KshSiteCollectionFeature")]
    public class AddSiteCollectionFeatureCommandTests
    {

        [TestMethod()]
        public void AddSiteCollectionFeature()
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
                var result2 = context.Runspace.InvokeCommand(
                    "Add-KshSiteCollectionFeature",
                    new Dictionary<string, object>()
                    {
                        { "FeatureId", "b21b090c-c796-4b0f-ac0f-7ef1659c20ae" },
                        { "Force", false },
                        { "Scope", "None" }
                    }
                );
                var result3 = context.Runspace.InvokeCommand<Feature>(
                    "Get-KshSiteCollectionFeature",
                    new Dictionary<string, object>()
                    {
                        { "FeatureId", "b21b090c-c796-4b0f-ac0f-7ef1659c20ae" }
                    }
                );
                var result4 = context.Runspace.InvokeCommand(
                    "Remove-KshSiteCollectionFeature",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result3.ElementAt(0) },
                        { "Force", false }
                    }
                );
            }
        }

    }

}
