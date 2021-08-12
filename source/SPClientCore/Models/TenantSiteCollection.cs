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

    [ClientObject(Name = "Microsoft.Online.SharePoint.TenantAdministration.SiteProperties", Id = "{fe9ac193-96fa-4090-b460-5dbf1d5fbdf1}")]
    [JsonObject()]
    public class TenantSiteCollection : ClientObject
    {

        public TenantSiteCollection()
        {
        }

        [JsonProperty()]
        public virtual bool AllowDownloadingNonWebViewableFiles { get; protected set; }

        [JsonProperty()]
        public virtual bool AllowEditing { get; protected set; }

        [JsonProperty()]
        public virtual bool AllowSelfServiceUpgrade { get; protected set; }

        [JsonProperty()]
        public virtual int AnonymousLinkExpirationInDays { get; protected set; }

        // [JsonProperty()]
        // public virtual string AuthContextStrength { get; protected set; }

        [JsonProperty()]
        public virtual int AverageResourceUsage { get; protected set; }

        [JsonProperty()]
        public virtual BlockDownloadLinksFileType BlockDownloadLinksFileType { get; protected set; }

        [JsonProperty()]
        public virtual bool CommentsOnSitePagesDisabled { get; protected set; }

        [JsonProperty()]
        public virtual int CompatibilityLevel { get; protected set; }

        [JsonProperty()]
        public virtual ConditionalAccessPolicyType ConditionalAccessPolicy { get; protected set; }

        [JsonProperty()]
        public virtual double CurrentResourceUsage { get; protected set; }

        [JsonProperty()]
        public virtual SharingPermissionType DefaultLinkPermission { get; protected set; }

        [JsonProperty()]
        public virtual bool DefaultLinkToExistingAccess { get; protected set; }

        [JsonProperty()]
        public virtual bool DefaultLinkToExistingAccessReset { get; protected set; }

        [JsonProperty()]
        public virtual SharingLinkType DefaultSharingLinkType { get; protected set; }

        [JsonProperty()]
        public virtual DenyAddAndCustomizePagesStatus DenyAddAndCustomizePages { get; protected set; }

        [JsonProperty()]
        public virtual string Description { get; protected set; }

        [JsonProperty()]
        public virtual AppViewsPolicy DisableAppViews { get; protected set; }

        [JsonProperty()]
        public virtual CompanyWideSharingLinksPolicy DisableCompanyWideSharingLinks { get; protected set; }

        [JsonProperty()]
        public virtual FlowsPolicy DisableFlows { get; protected set; }

        [JsonProperty()]
        public virtual int ExternalUserExpirationInDays { get; protected set; }

        [JsonProperty()]
        public virtual Guid GroupId { get; protected set; }

        [JsonProperty()]
        public virtual string GroupOwnerLoginName { get; protected set; }

        [JsonProperty()]
        public virtual bool HasHolds { get; protected set; }

        [JsonProperty()]
        public virtual Guid HubSiteId { get; protected set; }

        [JsonProperty("IsGroupOwnerSiteAdmin")]
        public virtual bool IsGroupOwnerSiteCollectionAdmin { get; protected set; }

        [JsonProperty()]
        public virtual bool IsHubSite { get; protected set; }

        [JsonProperty()]
        public virtual DateTime LastContentModifiedDate { get; protected set; }

        [JsonProperty()]
        public virtual uint Lcid { get; protected set; }

        [JsonProperty()]
        public virtual int LimitedAccessFileType { get; protected set; }

        [JsonProperty()]
        public virtual string LockIssue { get; protected set; }

        [JsonProperty()]
        public virtual string LockState { get; protected set; }

        // [JsonProperty()]
        // public virtual string NewUrl { get; protected set; }

        [JsonProperty()]
        public virtual bool OverrideTenantAnonymousLinkExpirationPolicy { get; protected set; }

        [JsonProperty()]
        public virtual bool OverrideTenantExternalUserExpirationPolicy { get; protected set; }

        [JsonProperty()]
        public virtual string Owner { get; protected set; }

        [JsonProperty()]
        public virtual string OwnerEmail { get; protected set; }

        [JsonProperty()]
        public virtual string OwnerLoginName { get; protected set; }

        [JsonProperty()]
        public virtual string OwnerName { get; protected set; }

        [JsonProperty()]
        public virtual PWAEnabledStatus PWAEnabled { get; protected set; }

        [JsonProperty()]
        public virtual Guid RelatedGroupId { get; protected set; }

        [JsonProperty()]
        public virtual RestrictedToRegion RestrictedToRegion { get; protected set; }

        [JsonProperty()]
        public virtual SandboxedCodeActivationCapabilities SandboxedCodeActivationCapability { get; protected set; }

        [JsonProperty()]
        public virtual Guid SensitivityLabel { get; protected set; }

        [JsonProperty()]
        public virtual bool SetOwnerWithoutUpdatingSecondaryAdmin { get; protected set; }

        [JsonProperty()]
        public virtual string SharingAllowedDomainList { get; protected set; }

        [JsonProperty()]
        public virtual string SharingBlockedDomainList { get; protected set; }

        [JsonProperty()]
        public virtual SharingCapabilities SharingCapability { get; protected set; }

        [JsonProperty()]
        public virtual SharingDomainRestrictionMode SharingDomainRestrictionMode { get; protected set; }

        [JsonProperty()]
        public virtual bool ShowPeoplePickerSuggestionsForGuestUsers { get; protected set; }

        [JsonProperty()]
        public virtual SharingCapabilities SiteDefinedSharingCapability { get; protected set; }

        [JsonProperty()]
        public virtual bool SocialBarOnSitePagesDisabled { get; protected set; }

        [JsonProperty()]
        public virtual string Status { get; protected set; }

        [JsonProperty()]
        public virtual int StorageMaximumLevel { get; protected set; }

        [JsonProperty()]
        public virtual string StorageQuotaType { get; protected set; }

        [JsonProperty()]
        public virtual int StorageUsage { get; protected set; }

        [JsonProperty()]
        public virtual int StorageWarningLevel { get; protected set; }

        [JsonProperty()]
        public virtual string Template { get; protected set; }

        [JsonProperty()]
        public virtual int TimeZoneId { get; protected set; }

        [JsonProperty()]
        public virtual string Title { get; protected set; }

        [JsonProperty()]
        public virtual string Url { get; protected set; }

        [JsonProperty()]
        public virtual int UserCodeMaximumLevel { get; protected set; }

        [JsonProperty()]
        public virtual int UserCodeWarningLevel { get; protected set; }

        [JsonProperty()]
        public virtual int WebsCount { get; protected set; }

    }

}
