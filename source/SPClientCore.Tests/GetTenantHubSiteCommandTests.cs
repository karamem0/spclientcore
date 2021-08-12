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
    [TestCategory("Get-KshTenantHubSite")]
    public class GetTenantHubSiteCommandTests
    {

        [TestMethod()]
        public void GetHubSites()
        {
            using (var context = new PSCmdletContext())
            {
                var result1 = context.Runspace.InvokeCommand(
                    "Connect-KshSite",
                    new Dictionary<string, object>()
                    {
                        { "Url", context.AppSettings["AdminUrl"] },
                        { "Credential", PSCredentialFactory.CreateCredential(
                            context.AppSettings["LoginUserName"],
                            context.AppSettings["LoginPassword"])
                        }
                    }
                );
                var result2 = context.Runspace.InvokeCommand<TenantSiteCollection>(
                    "New-KshTenantSiteCollection",
                    new Dictionary<string, object>()
                    {
                        { "Owner", context.AppSettings["LoginUserName"] },
                        { "Template", "SITEPAGEPUBLISHING#0" },
                        { "Url", context.AppSettings["AuthorityUrl"] + "/sites/TestSite0" }
                    }
                );
                var result3 = context.Runspace.InvokeCommand<SiteCollection>(
                    "Get-KshSiteCollection",
                    new Dictionary<string, object>()
                    {
                        { "SiteCollectionUrl", result2.ElementAt(0).Url }
                    }
                );
                var result4 = context.Runspace.InvokeCommand<HubSite>(
                    "New-KshTenantHubSite",
                    new Dictionary<string, object>()
                    {
                        { "SiteCollectionId", result3.ElementAt(0).Id },
                        { "SiteCollectionUrl", result3.ElementAt(0).Url },
                        { "Title", "Test Hub Site 0" }
                    }
                );
                var result5 = context.Runspace.InvokeCommand<HubSite>(
                    "Get-KshTenantHubSite",
                    new Dictionary<string, object>()
                    {
                    }
                );
                var result6 = context.Runspace.InvokeCommand(
                    "Remove-KshTenantHubSite",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result4.ElementAt(0) }
                    }
                );
                var result7 = context.Runspace.InvokeCommand(
                    "Remove-KshTenantSiteCollection",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result2.ElementAt(0) }
                    }
                );
                var result8 = context.Runspace.InvokeCommand<TenantDeletedSiteCollection>(
                    "Get-KshTenantDeletedSiteCollection",
                    new Dictionary<string, object>()
                    {
                        { "SiteCollectionUrl", result2.ElementAt(0).Url }
                    }
                );
                var result9 = context.Runspace.InvokeCommand(
                    "Remove-KshTenantDeletedSiteCollection",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result8.ElementAt(0) }
                    }
                );
                var actual = result5.ToArray();
            }
        }

        [TestMethod()]
        public void GetHubSiteByHubSiteId()
        {
            using (var context = new PSCmdletContext())
            {
                var result1 = context.Runspace.InvokeCommand(
                    "Connect-KshSite",
                    new Dictionary<string, object>()
                    {
                        { "Url", context.AppSettings["AdminUrl"] },
                        { "Credential", PSCredentialFactory.CreateCredential(
                            context.AppSettings["LoginUserName"],
                            context.AppSettings["LoginPassword"])
                        }
                    }
                );
                var result2 = context.Runspace.InvokeCommand<TenantSiteCollection>(
                    "New-KshTenantSiteCollection",
                    new Dictionary<string, object>()
                    {
                        { "Owner", context.AppSettings["LoginUserName"] },
                        { "Template", "SITEPAGEPUBLISHING#0" },
                        { "Url", context.AppSettings["AuthorityUrl"] + "/sites/TestSite0" }
                    }
                );
                var result3 = context.Runspace.InvokeCommand<SiteCollection>(
                    "Get-KshSiteCollection",
                    new Dictionary<string, object>()
                    {
                        { "SiteCollectionUrl", result2.ElementAt(0).Url }
                    }
                );
                var result4 = context.Runspace.InvokeCommand<HubSite>(
                    "New-KshTenantHubSite",
                    new Dictionary<string, object>()
                    {
                        { "SiteCollectionId", result3.ElementAt(0).Id },
                        { "SiteCollectionUrl", result3.ElementAt(0).Url },
                        { "Title", "Test Hub Site 0" }
                    }
                );
                var result5 = context.Runspace.InvokeCommand<HubSite>(
                    "Get-KshTenantHubSite",
                    new Dictionary<string, object>()
                    {
                        { "HubSiteId", result4.ElementAt(0).Id }
                    }
                );
                var result6 = context.Runspace.InvokeCommand(
                    "Remove-KshTenantHubSite",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result4.ElementAt(0) }
                    }
                );
                var result7 = context.Runspace.InvokeCommand(
                    "Remove-KshTenantSiteCollection",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result2.ElementAt(0) }
                    }
                );
                var result8 = context.Runspace.InvokeCommand<TenantDeletedSiteCollection>(
                    "Get-KshTenantDeletedSiteCollection",
                    new Dictionary<string, object>()
                    {
                        { "SiteCollectionUrl", result2.ElementAt(0).Url }
                    }
                );
                var result9 = context.Runspace.InvokeCommand(
                    "Remove-KshTenantDeletedSiteCollection",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result8.ElementAt(0) }
                    }
                );
                var actual = result5.ElementAt(0);
            }
        }

        [TestMethod()]
        public void GetHubSiteByHubSiteUrl()
        {
            using (var context = new PSCmdletContext())
            {
                var result1 = context.Runspace.InvokeCommand(
                    "Connect-KshSite",
                    new Dictionary<string, object>()
                    {
                        { "Url", context.AppSettings["AdminUrl"] },
                        { "Credential", PSCredentialFactory.CreateCredential(
                            context.AppSettings["LoginUserName"],
                            context.AppSettings["LoginPassword"])
                        }
                    }
                );
                var result2 = context.Runspace.InvokeCommand<TenantSiteCollection>(
                    "New-KshTenantSiteCollection",
                    new Dictionary<string, object>()
                    {
                        { "Owner", context.AppSettings["LoginUserName"] },
                        { "Template", "SITEPAGEPUBLISHING#0" },
                        { "Url", context.AppSettings["AuthorityUrl"] + "/sites/TestSite0" }
                    }
                );
                var result3 = context.Runspace.InvokeCommand<SiteCollection>(
                    "Get-KshSiteCollection",
                    new Dictionary<string, object>()
                    {
                        { "SiteCollectionUrl", result2.ElementAt(0).Url }
                    }
                );
                var result4 = context.Runspace.InvokeCommand<HubSite>(
                    "New-KshTenantHubSite",
                    new Dictionary<string, object>()
                    {
                        { "SiteCollectionId", result3.ElementAt(0).Id },
                        { "SiteCollectionUrl", result3.ElementAt(0).Url },
                        { "Title", "Test Hub Site 0" }
                    }
                );
                var result5 = context.Runspace.InvokeCommand<HubSite>(
                    "Get-KshTenantHubSite",
                    new Dictionary<string, object>()
                    {
                        { "HubSiteUrl", result3.ElementAt(0).Url }
                    }
                );
                var result6 = context.Runspace.InvokeCommand(
                    "Remove-KshTenantHubSite",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result4.ElementAt(0) }
                    }
                );
                var result7 = context.Runspace.InvokeCommand(
                    "Remove-KshTenantSiteCollection",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result2.ElementAt(0) }
                    }
                );
                var result8 = context.Runspace.InvokeCommand<TenantDeletedSiteCollection>(
                    "Get-KshTenantDeletedSiteCollection",
                    new Dictionary<string, object>()
                    {
                        { "SiteCollectionUrl", result2.ElementAt(0).Url }
                    }
                );
                var result9 = context.Runspace.InvokeCommand(
                    "Remove-KshTenantDeletedSiteCollection",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result8.ElementAt(0) }
                    }
                );
                var actual = result5.ElementAt(0);
            }
        }

    }

}
