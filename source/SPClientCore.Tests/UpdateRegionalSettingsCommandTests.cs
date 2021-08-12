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
    [TestCategory("Update-KshRegionalSettings")]
    public class UpdateRegionalSettingsCommandTests
    {

        [TestMethod()]
        public void UpdateRegionalSettings()
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
                        { "Description", "Test Site 0 Description" },
                        { "ServerRelativeUrl", "TestSite0" },
                        { "Title", "Test Site 0" }
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
                var result4 = context.Runspace.InvokeCommand<RegionalSettings>(
                    "Get-KshRegionalSettings",
                    new Dictionary<string, object>()
                    {
                    }
                );
                var result5 = context.Runspace.InvokeCommand<RegionalSettings>(
                    "Update-KshRegionalSettings",
                    new Dictionary<string, object>()
                    {
                        { "AdjustHijriDays", 1 },
                        { "AlternateCalendarType", 1 },
                        { "CalendarType", 1 },
                        { "Collation", 1 },
                        { "FirstDayOfWeek", 1 },
                        { "FirstWeekOfYear", 1 },
                        { "Lcid", 1041 },
                        { "ShowWeeks", true },
                        { "Time24", true },
                        { "TimeZone", result4.ElementAt(0).TimeZones.ElementAt(0) },
                        { "WorkDayEndHour", 60 },
                        { "WorkDays", 1 },
                        { "WorkDayStartHour", 60 },
                        { "PassThru", true }
                    }
                );
                var result6 = context.Runspace.InvokeCommand(
                    "Remove-KshSite",
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
