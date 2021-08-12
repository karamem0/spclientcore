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

    [ClientObject(Name = "Microsoft.Online.SharePoint.TenantAdministration.Tenant", Id = "{268004ae-ef6b-4e9b-8425-127220d84719}")]
    [JsonObject()]
    public class Tenant : ClientObject
    {

        public Tenant()
        {
        }

        [JsonProperty()]
        public virtual AddressbarLinkPermissions AddressbarLinkPermission { get; protected set; }

        [JsonProperty()]
        public virtual string AIBuilderDefaultPowerAppsEnvironment { get; protected set; }

        [JsonProperty()]
        public virtual bool AIBuilderEnabled { get; protected set; }

        [JsonProperty()]
        public virtual IReadOnlyCollection<SiteInfoForSitePicker> AIBuilderSiteInfoList { get; protected set; }

        [JsonProperty()]
        public virtual IReadOnlyCollection<Guid> AIBuilderSiteList { get; protected set; }

        [JsonProperty()]
        public virtual string AIBuilderSiteListFileName { get; protected set; }

        [JsonProperty()]
        public virtual bool AllowCommentsTextOnEmailEnabled { get; protected set; }

        [JsonProperty()]
        public virtual bool AllowDownloadingNonWebViewableFiles { get; protected set; }

        [JsonProperty()]
        public virtual IReadOnlyCollection<Guid> AllowedDomainListForSyncClient { get; protected set; }

        [JsonProperty()]
        public virtual bool AllowEditing { get; protected set; }

        [JsonProperty()]
        public virtual bool AllowGuestUserShareToUsersNotInSiteCollection { get; protected set; }

        [JsonProperty()]
        public virtual bool AllowLimitedAccessOnUnmanagedDevices { get; protected set; }

        [JsonProperty()]
        public virtual bool AllowOverrideForBlockUserInfoVisibility { get; protected set; }

        [JsonProperty("AllowSelectSGsInODBListInTenant")]
        public virtual IReadOnlyCollection<string> AllowSelectSharingGroupsInOneDriveListInTenant { get; protected set; }

        [JsonProperty()]
        public virtual bool AnyoneLinkTrackUsers { get; protected set; }

        [JsonProperty()]
        public virtual bool ApplyAppEnforcedRestrictionsToAdHocRecipients { get; protected set; }

        [JsonProperty()]
        public virtual bool BccExternalSharingInvitations { get; protected set; }

        [JsonProperty()]
        public virtual string BccExternalSharingInvitationsList { get; protected set; }

        [JsonProperty()]
        public virtual bool BlockAccessOnUnmanagedDevices { get; protected set; }

        [JsonProperty()]
        public virtual BlockDownloadLinksFileType BlockDownloadLinksFileType { get; protected set; }

        [JsonProperty()]
        public virtual bool BlockDownloadOfAllFilesForGuests { get; protected set; }

        [JsonProperty()]
        public virtual bool BlockDownloadOfAllFilesOnUnmanagedDevices { get; protected set; }

        [JsonProperty()]
        public virtual bool BlockDownloadOfViewableFilesForGuests { get; protected set; }

        [JsonProperty()]
        public virtual bool BlockDownloadOfViewableFilesOnUnmanagedDevices { get; protected set; }

        [JsonProperty()]
        public virtual bool BlockMacSync { get; protected set; }

        [JsonProperty()]
        public virtual bool BlockSendLabelMismatchEmail { get; protected set; }

        [JsonProperty()]
        public virtual string BlockUserInfoVisibility { get; protected set; }

        [JsonProperty()]
        public virtual TenantBrowseUserInfoPolicyValue BlockUserInfoVisibilityInOneDrive { get; protected set; }

        [JsonProperty()]
        public virtual TenantBrowseUserInfoPolicyValue BlockUserInfoVisibilityInSharePoint { get; protected set; }

        [JsonProperty()]
        public virtual ChannelMeetingRecordingPermissionType ChannelMeetingRecordingPermission { get; protected set; }

        [JsonProperty()]
        public virtual bool CommentsOnFilesDisabled { get; protected set; }

        [JsonProperty()]
        public virtual bool CommentsOnListItemsDisabled { get; protected set; }

        [JsonProperty()]
        public virtual bool CommentsOnSitePagesDisabled { get; protected set; }

        [JsonProperty()]
        public virtual string CompatibilityRange { get; protected set; }

        [JsonProperty()]
        public virtual ConditionalAccessPolicyType ConditionalAccessPolicy { get; protected set; }

        [JsonProperty()]
        public virtual string ConditionalAccessPolicyErrorHelpLink { get; protected set; }

        [JsonProperty()]
        public virtual IReadOnlyCollection<string> ContentTypeSyncSiteTemplatesList { get; protected set; }

        [JsonProperty()]
        public virtual string CustomizedExternalSharingServiceUrl { get; protected set; }

        [JsonProperty()]
        public virtual SiteInfoForSitePicker DefaultContentCenterSite { get; protected set; }

        [JsonProperty()]
        public virtual SharingPermissionType DefaultLinkPermission { get; protected set; }

        [JsonProperty("DefaultODBMode")]
        public virtual string DefaultOneDriveMode { get; protected set; }

        [JsonProperty()]
        public virtual SharingLinkType DefaultSharingLinkType { get; protected set; }

        [JsonProperty()]
        public virtual bool DisableAddToOneDrive { get; protected set; }

        [JsonProperty()]
        public virtual bool DisableBackToClassic { get; protected set; }

        [JsonProperty()]
        public virtual bool DisableCustomAppAuthentication { get; protected set; }

        [JsonProperty()]
        public virtual IReadOnlyCollection<Guid> DisabledModernListTemplateIds { get; protected set; }

        [JsonProperty()]
        public virtual IReadOnlyCollection<Guid> DisabledWebPartIds { get; protected set; }

        [JsonProperty()]
        public virtual bool DisableOutlookPSTVersionTrimming { get; protected set; }

        [JsonProperty()]
        public virtual bool DisablePersonalListCreation { get; protected set; }

        [JsonProperty()]
        public virtual bool DisableReportProblemDialog { get; protected set; }

        [JsonProperty()]
        public virtual bool DisableSpacesActivation { get; protected set; }

        [JsonProperty()]
        public virtual bool DisallowInfectedFileDownload { get; protected set; }

        [JsonProperty()]
        public virtual bool DisplayNamesOfFileViewers { get; protected set; }

        [JsonProperty("DisplayNamesOfFileViewersInSpo")]
        public virtual bool DisplayNamesOfFileViewersInSharePoint { get; protected set; }

        [JsonProperty()]
        public virtual bool DisplayStartASiteOption { get; protected set; }

        [JsonProperty()]
        public virtual bool EmailAttestationEnabled { get; protected set; }

        [JsonProperty()]
        public virtual int EmailAttestationReAuthDays { get; protected set; }

        [JsonProperty()]
        public virtual bool EmailAttestationRequired { get; protected set; }

        [JsonProperty()]
        public virtual bool EnableAIPIntegration { get; protected set; }

        [JsonProperty()]
        public virtual bool EnableAutoNewsDigest { get; protected set; }

        [JsonProperty("EnableAzureADB2BIntegration")]
        public virtual bool EnableAzureAdB2BIntegration { get; protected set; }

        // [JsonProperty("EnabledFlightAllowAADB2BSkipCheckingOTP")]
        // public virtual bool EnabledFlightAllowAzureAdB2BSkipCheckingOneTimePassword { get; protected set; }

        [JsonProperty()]
        public virtual bool EnableGuestSignInAcceleration { get; protected set; }

        [JsonProperty()]
        public virtual bool EnableMinimumVersionRequirement { get; protected set; }

        [JsonProperty()]
        public virtual bool EnableMipSiteLabel { get; protected set; }

        [JsonProperty()]
        public virtual bool EnablePromotedFileHandlers { get; protected set; }

        [JsonProperty()]
        public virtual IReadOnlyCollection<string> ExcludedFileExtensionsForSyncClient { get; protected set; }

        [JsonProperty()]
        public virtual bool ExternalServicesEnabled { get; protected set; }

        [JsonProperty()]
        public virtual bool ExternalUserExpirationRequired { get; protected set; }

        [JsonProperty()]
        public virtual int ExternalUserExpireInDays { get; protected set; }

        [JsonProperty()]
        public virtual AnonymousLinkType FileAnonymousLinkType { get; protected set; }

        [JsonProperty()]
        public virtual bool FilePickerExternalImageSearchEnabled { get; protected set; }

        [JsonProperty()]
        public virtual AnonymousLinkType FolderAnonymousLinkType { get; protected set; }

        [JsonProperty()]
        public virtual string GuestSharingGroupAllowListInTenant { get; protected set; }

        [JsonProperty()]
        public virtual IReadOnlyCollection<string> GuestSharingGroupAllowListInTenantByPrincipalIdentity { get; protected set; }

        [JsonProperty()]
        public virtual bool HasAdminCompletedCUConfiguration { get; protected set; }

        [JsonProperty()]
        public virtual bool HasIntelligentContentServicesCapability { get; protected set; }

        [JsonProperty()]
        public virtual bool HasTopicExperiencesCapability { get; protected set; }

        [JsonProperty()]
        public virtual bool HideDefaultThemes { get; protected set; }

        [JsonProperty()]
        public virtual bool HideSyncButtonOnDocLib { get; protected set; }

        [JsonProperty("HideSyncButtonOnODB")]
        public virtual bool HideSyncButtonOnOneDrive { get; protected set; }

        [JsonProperty()]
        public virtual ImageTaggingChoice ImageTaggingOption { get; protected set; }

        [JsonProperty()]
        public virtual bool IncludeAtAGlanceInShareEmails { get; protected set; }

        [JsonProperty()]
        public virtual bool InformationBarriersSuspension { get; protected set; }

        [JsonProperty()]
        public virtual string IPAddressAllowList { get; protected set; }

        [JsonProperty()]
        public virtual bool IPAddressEnforcement { get; protected set; }

        [JsonProperty("IPAddressWACTokenLifetime")]
        public virtual int IPAddressWacTokenLifetime { get; protected set; }

        [JsonProperty()]
        public virtual bool IsAppBarTemporarilyDisabled { get; protected set; }

        [JsonProperty()]
        public virtual bool IsCollabMeetingNotesFluidEnabled { get; protected set; }

        [JsonProperty()]
        public virtual bool IsFluidEnabled { get; protected set; }

        [JsonProperty()]
        public virtual bool IsHubSitesMultiGeoFlightEnabled { get; protected set; }

        [JsonProperty()]
        public virtual bool IsMnAFlightEnabled { get; protected set; }

        [JsonProperty()]
        public virtual bool IsMultiGeo { get; protected set; }

        [JsonProperty()]
        public virtual bool IsUnmanagedSyncClientForTenantRestricted { get; protected set; }

        [JsonProperty()]
        public virtual bool IsUnmanagedSyncClientRestrictionFlightEnabled { get; protected set; }

        [JsonProperty("IsWBFluidEnabled")]
        public virtual bool IsWhiteboardFluidEnabled { get; protected set; }

        [JsonProperty()]
        public virtual string LabelMismatchEmailHelpLink { get; protected set; }

        [JsonProperty()]
        public virtual bool LegacyAuthProtocolsEnabled { get; protected set; }

        [JsonProperty()]
        public virtual LimitedAccessFileType LimitedAccessFileType { get; protected set; }

        [JsonProperty()]
        public virtual bool MachineLearningCaptureEnabled { get; protected set; }

        [JsonProperty()]
        public virtual SensitiveByDefaultState MarkNewFilesSensitiveByDefault { get; protected set; }

        [JsonProperty()]
        public virtual MediaTranscriptionPolicyType MediaTranscription { get; protected set; }

        [JsonProperty()]
        public virtual bool MobileFriendlyUrlEnabledInTenant { get; protected set; }

        [JsonProperty()]
        public virtual string NoAccessRedirectUrl { get; protected set; }

        [JsonProperty("NotificationsInOneDriveForBusinessEnabled")]
        public virtual bool NotificationsInOneDriveEnabled { get; protected set; }

        [JsonProperty()]
        public virtual bool NotificationsInSharePointEnabled { get; protected set; }

        [JsonProperty()]
        public virtual bool NotifyOwnersWhenInvitationsAccepted { get; protected set; }

        [JsonProperty()]
        public virtual bool NotifyOwnersWhenItemsReshared { get; protected set; }

        [JsonProperty("OfficeClientADALDisabled")]
        public virtual bool OfficeClientAdalDisabled { get; protected set; }

        [JsonProperty("ODBAccessRequests")]
        public virtual SharingState OneDriveAccessRequests { get; protected set; }

        [JsonProperty()]
        public virtual bool OneDriveForGuestsEnabled { get; protected set; }

        [JsonProperty("ODBMembersCanShare")]
        public virtual SharingState OneDriveMembersCanShare { get; protected set; }

        [JsonProperty("ODBSharingCapability")]
        public virtual SharingCapabilities OneDriveSharingCapability { get; protected set; }

        [JsonProperty()]
        public virtual long OneDriveStorageQuota { get; protected set; }

        [JsonProperty()]
        public virtual bool OptOutOfGrooveBlock { get; protected set; }

        [JsonProperty()]
        public virtual bool OptOutOfGrooveSoftBlock { get; protected set; }

        [JsonProperty()]
        public virtual string OrgNewsSiteUrl { get; protected set; }

        [JsonProperty()]
        public virtual int OrphanedPersonalSitesRetentionPeriod { get; protected set; }

        [JsonProperty()]
        public virtual bool OwnerAnonymousNotification { get; protected set; }

        [JsonProperty()]
        public virtual bool PermissiveBrowserFileHandlingOverride { get; protected set; }

        [JsonProperty()]
        public virtual bool PreventExternalUsersFromResharing { get; protected set; }

        [JsonProperty()]
        public virtual bool ProvisionSharedWithEveryoneFolder { get; protected set; }

        [JsonProperty()]
        public virtual string PublicCdnAllowedFileTypes { get; protected set; }

        [JsonProperty()]
        public virtual bool PublicCdnEnabled { get; protected set; }

        [JsonProperty()]
        public virtual IReadOnlyCollection<string> PublicCdnOrigins { get; protected set; }

        [JsonProperty()]
        public virtual bool RequireAcceptingAccountMatchInvitedAccount { get; protected set; }

        [JsonProperty()]
        public virtual int RequireAnonymousLinksExpireInDays { get; protected set; }

        [JsonProperty()]
        public virtual bool RestrictedOneDriveLicense { get; protected set; }

        [JsonProperty()]
        public virtual double ResourceQuota { get; protected set; }

        [JsonProperty()]
        public virtual double ResourceQuotaAllocated { get; protected set; }

        [JsonProperty()]
        public virtual string RootSiteUrl { get; protected set; }

        [JsonProperty("SearchResolveExactEmailOrUPN")]
        public virtual bool SearchResolveExactEmailOrUpn { get; protected set; }

        [JsonProperty()]
        public virtual string SharingAllowedDomainList { get; protected set; }

        [JsonProperty()]
        public virtual string SharingBlockedDomainList { get; protected set; }

        [JsonProperty()]
        public virtual SharingCapabilities SharingCapability { get; protected set; }

        [JsonProperty()]
        public virtual SharingDomainRestrictionMode SharingDomainRestrictionMode { get; protected set; }

        [JsonProperty()]
        public virtual bool ShowAllUsersClaim { get; protected set; }

        [JsonProperty()]
        public virtual bool ShowEveryoneClaim { get; protected set; }

        [JsonProperty()]
        public virtual bool ShowEveryoneExceptExternalUsersClaim { get; protected set; }

        [JsonProperty("ShowNGSCDialogForSyncOnODB")]
        public virtual bool ShowNextGenerationSyncClientDialogForSyncOnOneDrive { get; protected set; }

        [JsonProperty()]
        public virtual bool ShowPeoplePickerSuggestionsForGuestUsers { get; protected set; }

        [JsonProperty()]
        public virtual string SignInAccelerationDomain { get; protected set; }

        [JsonProperty()]
        public virtual bool SocialBarOnSitePagesDisabled { get; protected set; }

        [JsonProperty()]
        public virtual SpecialCharactersState SpecialCharactersStateInFileFolderNames { get; protected set; }

        [JsonProperty()]
        public virtual string StartASiteFormUrl { get; protected set; }

        [JsonProperty()]
        public virtual bool StopNew2010Workflows { get; protected set; }

        [JsonProperty()]
        public virtual bool StopNew2013Workflows { get; protected set; }

        [JsonProperty()]
        public virtual int StreamLaunchConfig { get; protected set; }

        [JsonProperty()]
        public virtual DateTime StreamLaunchConfigLastUpdated { get; protected set; }

        [JsonProperty()]
        public virtual long StorageQuota { get; protected set; }

        [JsonProperty()]
        public virtual long StorageQuotaAllocated { get; protected set; }

        [JsonProperty("SyncAadB2BManagementPolicy")]
        public virtual bool SyncAzureAdB2BManagementPolicy { get; protected set; }

        [JsonProperty()]
        public virtual bool SyncPrivacyProfileProperties { get; protected set; }

        [JsonProperty()]
        public virtual bool UseFindPeopleInPeoplePicker { get; protected set; }

        [JsonProperty()]
        public virtual bool UsePersistentCookiesForExplorerView { get; protected set; }

        [JsonProperty()]
        public virtual bool UserVoiceForFeedbackEnabled { get; protected set; }

        [JsonProperty()]
        public virtual bool ViewersCanCommentOnMediaDisabled { get; protected set; }

        [JsonProperty()]
        public virtual bool ViewInFileExplorerEnabled { get; protected set; }

        [JsonProperty()]
        public virtual string WhoCanShareAllowListInTenant { get; protected set; }

        [JsonProperty()]
        public virtual IReadOnlyCollection<string> WhoCanShareAllowListInTenantByPrincipalIdentity { get; protected set; }

        [JsonProperty()]
        public virtual bool Workflow2010Disabled { get; protected set; }

        [JsonProperty()]
        public virtual Workflows2013State Workflows2013State { get; protected set; }

    }

}
