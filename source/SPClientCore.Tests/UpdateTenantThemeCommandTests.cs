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
    [TestCategory("Update-KshTenantTheme")]
    public class UpdateTenantThemeCommandTests
    {

        [TestMethod()]
        public void UpdateTenantTheme()
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
                var result2 = context.Runspace.InvokeCommand<TenantTheme>(
                    "New-KshTenantTheme",
                    new Dictionary<string, object>()
                    {
                        { "IsInverted", false },
                        { "Name", "Test Theme 0" },
                        { "Palette", new Hashtable() }
                    }
                );
                var result3 = context.Runspace.InvokeCommand<TenantTheme>(
                    "Update-KshTenantTheme",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result2.ElementAt(0) },
                        { "IsInverted", true },
                        { "Palette", new Hashtable()
                            {
                                { "themePrimary", "#0078d4" },
                                { "themeLighterAlt", "#eff6fc" },
                                { "themeLighter", "#deecf9" },
                                { "themeLight", "#c7e0f4" },
                                { "themeTertiary", "#71afe5" },
                                { "themeSecondary", "#2b88d8" },
                                { "themeDarkAlt", "#106ebe" },
                                { "themeDark", "#005a9e" },
                                { "themeDarker", "#004578" },
                                { "neutralLighterAlt", "#f8f8f8" },
                                { "neutralLighter", "#f4f4f4" },
                                { "neutralLight", "#eaeaea" },
                                { "neutralQuaternaryAlt", "#dadada" },
                                { "neutralQuaternary", "#d0d0d0" },
                                { "neutralTertiaryAlt", "#c8c8c8" },
                                { "neutralTertiary", "#c2c2c2" },
                                { "neutralSecondary", "#858585" },
                                { "neutralPrimaryAlt", "#4b4b4b" },
                                { "neutralPrimary", "#333" },
                                { "neutralDark", "#272727" },
                                { "black", "#1d1d1d" },
                                { "white", "#fff" }
                            }
                        },
                        { "PassThru", true }
                    }
                );
                var result4 = context.Runspace.InvokeCommand(
                    "Remove-KshTenantTheme",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result3.ElementAt(0) }
                    }
                );
                var actual = result3.ElementAt(0);
            }
        }

    }

}
