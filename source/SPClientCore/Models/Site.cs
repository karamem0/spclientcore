//
// Copyright (c) 2021 karamem0
//
// This software is released under the MIT License.
//
// https://github.com/karamem0/spclientcore/blob/master/LICENSE
//

using Karamem0.SharePoint.PowerShell.Runtime.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Karamem0.SharePoint.PowerShell.Models
{

    [ClientObject(Name = "SP.Web", Id = "{a489add2-5d3a-4de8-9445-49259462dceb}")]
    [JsonObject()]
    public class Site : SecurableObject
    {

        public Site()
        {
        }

        [JsonProperty()]
        public virtual bool AllowAutomaticASPXPageIndexing { get; protected set; }

        [JsonProperty()]
        public virtual bool AllowCreateDeclarativeWorkflowForCurrentUser { get; protected set; }

        [JsonProperty()]
        public virtual bool AllowDesignerForCurrentUser { get; protected set; }

        [JsonProperty()]
        public virtual bool AllowMasterPageEditingForCurrentUser { get; protected set; }

        [JsonProperty()]
        public virtual bool AllowRevertFromTemplateForCurrentUser { get; protected set; }

        [JsonProperty()]
        public virtual bool AllowRssFeeds { get; protected set; }

        [JsonProperty()]
        public virtual bool AllowSaveDeclarativeWorkflowAsTemplateForCurrentUser { get; protected set; }

        [JsonProperty()]
        public virtual bool AllowSavePublishDeclarativeWorkflowForCurrentUser { get; protected set; }

        [JsonProperty()]
        public virtual string AlternateCssUrl { get; protected set; }

        [JsonProperty()]
        public virtual Guid AppInstanceId { get; protected set; }

        [JsonProperty()]
        public virtual User Author { get; protected set; }

        [JsonProperty()]
        public virtual string ClassicWelcomePage { get; protected set; }

        [JsonProperty()]
        public virtual bool CommentsOnSitePagesDisabled { get; protected set; }

        [JsonProperty()]
        public virtual int Configuration { get; protected set; }

        [JsonProperty()]
        public virtual bool ContainsConfidentialInfo { get; protected set; }

        [JsonProperty()]
        public virtual DateTime Created { get; protected set; }

        [JsonProperty()]
        public virtual ChangeToken CurrentChangeToken { get; protected set; }

        [JsonProperty()]
        public virtual string CustomMasterUrl { get; protected set; }

        [JsonProperty()]
        public virtual string Description { get; protected set; }

        [JsonProperty()]
        public virtual string DesignerDownloadUrlForCurrentUser { get; protected set; }

        [JsonProperty()]
        public virtual Guid DesignPackageId { get; protected set; }

        [JsonProperty()]
        public virtual bool DisableAppViews { get; protected set; }

        [JsonProperty()]
        public virtual bool DisableFlows { get; protected set; }

        [JsonProperty()]
        public virtual bool DocumentLibraryCalloutOfficeWebAppPreviewersDisabled { get; protected set; }

        [JsonProperty()]
        public virtual bool EnableMinimalDownload { get; protected set; }

        [JsonProperty()]
        public virtual bool ExcludeFromOfflineClient { get; protected set; }

        [JsonProperty()]
        public virtual FooterVariantThemeType FooterEmphasis { get; protected set; }

        [JsonProperty()]
        public virtual bool FooterEnabled { get; protected set; }

        [JsonProperty()]
        public virtual FooterLayoutType FooterLayout { get; protected set; }

        [JsonProperty()]
        public override bool HasUniqueRoleAssignments { get; protected set; }

        [JsonProperty()]
        public virtual VariantThemeType HeaderEmphasis { get; protected set; }

        [JsonProperty()]
        public virtual HeaderLayoutType HeaderLayout { get; protected set; }

        [JsonProperty()]
        public virtual bool HideTitleInHeader { get; protected set; }

        [JsonProperty()]
        public virtual bool HorizontalQuickLaunch { get; protected set; }

        [JsonProperty()]
        public virtual Guid Id { get; protected set; }

        [JsonProperty()]
        public virtual bool IsHomepageModernized { get; protected set; }

        [JsonProperty()]
        public virtual bool IsMultilingual { get; protected set; }

        [JsonProperty()]
        public virtual bool IsRevertHomepageLinkHidden { get; protected set; }

        [JsonProperty()]
        public virtual DateTime LastItemModifiedDate { get; protected set; }

        [JsonProperty()]
        public virtual DateTime LastItemUserModifiedDate { get; protected set; }

        [JsonProperty("Language")]
        public virtual uint Lcid { get; protected set; }

        [JsonProperty()]
        public virtual LogoAlignment LogoAlignment { get; protected set; }

        [JsonProperty()]
        public virtual string MasterUrl { get; protected set; }

        [JsonProperty()]
        public virtual bool MembersCanShare { get; protected set; }

        [JsonProperty()]
        public virtual bool MegaMenuEnabled { get; protected set; }

        [JsonProperty()]
        public virtual bool NavAudienceTargetingEnabled { get; protected set; }

        [JsonProperty()]
        public virtual bool NoCrawl { get; protected set; }

        [JsonProperty()]
        public virtual bool NotificationsInOneDriveForBusinessEnabled { get; protected set; }

        [JsonProperty()]
        public virtual bool NotificationsInSharePointEnabled { get; protected set; }

        [JsonProperty()]
        public virtual bool ObjectCacheEnabled { get; protected set; }

        [JsonProperty()]
        public virtual bool OverwriteTranslationsOnChange { get; protected set; }

        [JsonProperty()]
        public virtual bool QuickLaunchEnabled { get; protected set; }

        [JsonProperty()]
        public virtual bool RecycleBinEnabled { get; protected set; }

        [JsonProperty()]
        public virtual ResourcePath ResourcePath { get; protected set; }

        [JsonProperty()]
        public virtual string RequestAccessEmail { get; protected set; }

        [JsonProperty()]
        public virtual bool SaveSiteAsTemplateEnabled { get; protected set; }

        [JsonProperty()]
        public virtual SearchScopeType SearchScope { get; protected set; }

        [JsonProperty()]
        public virtual string ServerRelativeUrl { get; protected set; }

        [JsonProperty()]
        public virtual bool ShowUrlStructureForCurrentUser { get; protected set; }

        [JsonProperty()]
        public virtual string SiteLogoDescription { get; protected set; }

        [JsonProperty()]
        public virtual string SiteLogoUrl { get; protected set; }

        [JsonProperty()]
        public virtual IReadOnlyCollection<int> SupportedUILanguageIds { get; protected set; }

        [JsonProperty()]
        public virtual bool SyndicationEnabled { get; protected set; }

        [JsonProperty("WebTemplate")]
        public virtual string Template { get; protected set; }

        [JsonProperty()]
        public virtual bool TenantTagPolicyEnabled { get; protected set; }

        [JsonProperty()]
        public virtual bool TenantAdminMembersCanShare { get; protected set; }

        [JsonProperty()]
        public virtual string ThemedCssFolderUrl { get; protected set; }

        [JsonProperty()]
        public virtual bool ThirdPartyMdmEnabled { get; protected set; }

        [JsonProperty()]
        public virtual string Title { get; protected set; }

        [JsonProperty()]
        public virtual bool TreeViewEnabled { get; protected set; }

        [JsonProperty()]
        public virtual int UIVersion { get; protected set; }

        [JsonProperty()]
        public virtual bool UIVersionConfigurationEnabled { get; protected set; }

        [JsonProperty()]
        public virtual string Url { get; protected set; }

        [JsonProperty()]
        public virtual string WelcomePage { get; protected set; }

    }

}
