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
    [TestCategory("Update-KshSite")]
    public class UpdateSiteCommandTests
    {

        [TestMethod()]
        public void UpdateSite()
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
                        { "ServerRelativeUrl", "TestSite0" },
                        { "Title", "Test Site 0" }
                    }
                );
                var result3 = context.Runspace.InvokeCommand<Site>(
                    "Update-KshSite",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result2.ElementAt(0) },
                        { "AllowAutomaticASPXPageIndexing", true },
                        { "AlternateCssUrl", "style.css" },
                        //{ "AssociatedMemberGroup", null },
                        //{ "AssociatedOwnerGroup", null },
                        //{ "AssociatedVisitorGroup", null },
                        { "CommentsOnSitePagesDisabled", true },
                        { "ContainsConfidentialInfo", true },
                        { "CustomMasterUrl", result2.ElementAt(0).ServerRelativeUrl + "/_catalogs/masterpage/oslo.master" },
                        { "DisableAppViews", true },
                        { "DisableFlows", true },
                        { "Description", "Test Site 9 Description" },
                        { "EnableMinimalDownload", true },
                        { "ExcludeFromOfflineClient", true },
                        { "FooterEnabled", true },
                        { "FooterLayout", "Simple" },
                        { "HeaderEmphasis", "Neutral" },
                        { "HeaderLayout", "Standard" },
                        { "HorizontalQuickLaunch", true },
                        { "LogoAlignment", "Left" },
                        { "MasterUrl", result2.ElementAt(0).ServerRelativeUrl + "/_catalogs/masterpage/oslo.master" },
                        { "MembersCanShare", true },
                        { "MegaMenuEnabled", true },
                        { "NavAudienceTargetingEnabled", true },
                        { "NoCrawl", true },
                        { "ObjectCacheEnabled", true },
                        { "QuickLaunchEnabled", true },
                        { "OverwriteTranslationsOnChange", true },
                        { "RequestAccessEmail", "someone@example.com" },
                        { "SaveSiteAsTemplateEnabled", true },
                        { "SearchScope", "DefaultScope" },
                        { "ServerRelativeUrl", "TestSite9" },
                        { "SiteLogoDescription", "Test Site 9 Description" },
                        { "SiteLogoUrl", result2.ElementAt(0).ServerRelativeUrl + "/_layouts/15/images/siteicon.png" },
                        { "SyndicationEnabled", true },
                        { "ThemedCssFolderUrl", result2.ElementAt(0).ServerRelativeUrl + "/SiteAssets/theme.css" },
                        { "Title", "Test Site 9" },
                        { "TreeViewEnabled", true },
                        { "UIVersion", 15 },
                        { "UIVersionConfigurationEnabled", true },
                        { "PassThru", true }
                    }
                );
                var result4 = context.Runspace.InvokeCommand(
                    "Remove-KshSite",
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
