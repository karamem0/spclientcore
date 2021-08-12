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
    [TestCategory("Get-KshSubscription")]
    public class GetSubscriptionCommandTests
    {

        [TestMethod()]
        public void GetSubscriptions()
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
                var result3 = context.Runspace.InvokeCommand<Subscription>(
                    "Get-KshSubscription",
                    new Dictionary<string, object>()
                    {
                        { "List", result2.ElementAt(0) }
                    }
                );
                var actual = result3.ToArray();
            }
        }

        [TestMethod()]
        public void GetSubscriptionByIdentity()
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
                var result3 = context.Runspace.InvokeCommand<Subscription>(
                    "New-KshSubscription",
                    new Dictionary<string, object>()
                    {
                        { "List", result2.ElementAt(0) },
                        { "NotificationUrl", "https://prod-20.southeastasia.logic.azure.com/workflows/dd8e16aab0a94a3392b6fcc14ea83c1a/triggers/manual/paths/invoke?api-version=2016-10-01&sp=%2Ftriggers%2Fmanual%2Frun&sv=1.0&sig=SmQKf3e89WOOdQ_hPjV2MHY8X35n61EqXBJIvHLPoBg" },
                        { "ExpirationDateTime", DateTime.UtcNow.AddDays(1) }
                    }
                );
                var result4 = context.Runspace.InvokeCommand<Subscription>(
                    "Get-KshSubscription",
                    new Dictionary<string, object>()
                    {
                        { "List", result2.ElementAt(0) },
                        { "SubscriptionId", result3.ElementAt(0).Id }
                    }
                );
                var result5 = context.Runspace.InvokeCommand<Subscription>(
                    "Get-KshSubscription",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result4.ElementAt(0) }
                    }
                );
                var result6 = context.Runspace.InvokeCommand(
                    "Remove-KshSubscription",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result5.ElementAt(0) }
                    }
                );
                var actual = result5.ElementAt(0);
            }
        }

        [TestMethod()]
        public void GetSubscriptionBySubscriptionId()
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
                var result3 = context.Runspace.InvokeCommand<Subscription>(
                    "New-KshSubscription",
                    new Dictionary<string, object>()
                    {
                        { "List", result2.ElementAt(0) },
                        { "NotificationUrl", "https://prod-20.southeastasia.logic.azure.com/workflows/dd8e16aab0a94a3392b6fcc14ea83c1a/triggers/manual/paths/invoke?api-version=2016-10-01&sp=%2Ftriggers%2Fmanual%2Frun&sv=1.0&sig=SmQKf3e89WOOdQ_hPjV2MHY8X35n61EqXBJIvHLPoBg" },
                        { "ExpirationDateTime", DateTime.UtcNow.AddDays(1) }
                    }
                );
                var result4 = context.Runspace.InvokeCommand<Subscription>(
                    "Get-KshSubscription",
                    new Dictionary<string, object>()
                    {
                        { "List", result2.ElementAt(0) },
                        { "SubscriptionId", result3.ElementAt(0).Id }
                    }
                );
                var result5 = context.Runspace.InvokeCommand(
                    "Remove-KshSubscription",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result4.ElementAt(0) }
                    }
                );
                var actual = result4.ElementAt(0);
            }
        }

    }

}
