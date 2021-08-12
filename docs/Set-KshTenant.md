---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Set-KshTenant

## SYNOPSIS
Changes the tenant.

## SYNTAX

```
Set-KshTenant [-AddressbarLinkPermission <AddressbarLinkPermissions>]
 [-AllowCommentsTextOnEmailEnabled <Boolean>] [-AllowDownloadingNonWebViewableFiles <Boolean>]
 [-AllowedDomainListForSyncClient <Guid[]>] [-AllowEditing <Boolean>]
 [-AllowLimitedAccessOnUnmanagedDevices <Boolean>] [-AllowOverrideForBlockUserInfoVisibility <Boolean>]
 [-AnyoneLinkTrackUsers <Boolean>] [-ApplyAppEnforcedRestrictionsToAdHocRecipients <Boolean>]
 [-BccExternalSharingInvitations <Boolean>] [-BccExternalSharingInvitationsList <String>]
 [-BlockAccessOnUnmanagedDevices <Boolean>] [-BlockDownloadLinksFileType <BlockDownloadLinksFileType>]
 [-BlockMacSync <Boolean>] [-BlockSendLabelMismatchEmail <Boolean>] [-BlockUserInfoVisibility <String>]
 [-BlockUserInfoVisibilityInOneDrive <TenantBrowseUserInfoPolicyValue>]
 [-BlockUserInfoVisibilityInSharePoint <TenantBrowseUserInfoPolicyValue>] [-CommentsOnFilesDisabled <Boolean>]
 [-CommentsOnListItemsDisabled <Boolean>] [-CommentsOnSitePagesDisabled <Boolean>]
 [-CompatibilityRange <String>] [-ConditionalAccessPolicy <ConditionalAccessPolicyType>]
 [-ConditionalAccessPolicyErrorHelpLink <String>] [-ContentTypeSyncSiteTemplatesList <String[]>]
 [-CustomizedExternalSharingServiceUrl <String>] [-DefaultContentCenterSite <SiteInfoForSitePicker>]
 [-DefaultLinkPermission <SharingPermissionType>] [-DefaultOneDriveMode <String>]
 [-DefaultSharingLinkType <SharingLinkType>] [-DisableAddToOneDrive <Boolean>]
 [-DisableBackToClassic <Boolean>] [-DisableCustomAppAuthentication <Boolean>]
 [-DisabledModernListTemplateIds <Guid[]>] [-DisabledWebPartIds <Guid[]>]
 [-DisableOutlookPSTVersionTrimming <Boolean>] [-DisablePersonalListCreation <Boolean>]
 [-DisableReportProblemDialog <Boolean>] [-DisableSpacesActivation <Boolean>]
 [-DisallowInfectedFileDownload <Boolean>] [-DisplayNamesOfFileViewers <Boolean>]
 [-DisplayNamesOfFileViewersInSharePoint <Boolean>] [-DisplayStartASiteOption <Boolean>]
 [-EmailAttestationEnabled <Boolean>] [-EmailAttestationReAuthDays <Int32>]
 [-EmailAttestationRequired <Boolean>] [-EnableAIPIntegration <Boolean>] [-EnableAutoNewsDigest <Boolean>]
 [-EnableAzureAdB2BIntegration <Boolean>] [-EnableGuestSignInAcceleration <Boolean>]
 [-EnableMinimumVersionRequirement <Boolean>] [-EnableMipSiteLabel <Boolean>]
 [-EnablePromotedFileHandlers <Boolean>] [-ExcludedFileExtensionsForSyncClient <String[]>]
 [-ExternalServicesEnabled <Boolean>] [-ExternalUserExpirationRequired <Boolean>]
 [-ExternalUserExpireInDays <Int32>] [-FileAnonymousLinkType <AnonymousLinkType>]
 [-FilePickerExternalImageSearchEnabled <Boolean>] [-FolderAnonymousLinkType <AnonymousLinkType>]
 [-GuestSharingGroupAllowListInTenant <String>]
 [-GuestSharingGroupAllowListInTenantByPrincipalIdentity <String[]>]
 [-HasAdminCompletedCUConfiguration <Boolean>] [-HideDefaultThemes <Boolean>]
 [-HideSyncButtonOnDocLib <Boolean>] [-HideSyncButtonOnOneDrive <Boolean>]
 [-ImageTaggingOption <ImageTaggingChoice>] [-IncludeAtAGlanceInShareEmails <Boolean>]
 [-InformationBarriersSuspension <Boolean>] [-IPAddressAllowList <String>] [-IPAddressEnforcement <Boolean>]
 [-IPAddressWacTokenLifetime <Int32>] [-IsAppBarTemporarilyDisabled <Boolean>]
 [-IsCollabMeetingNotesFluidEnabled <Boolean>] [-IsFluidEnabled <Boolean>]
 [-IsUnmanagedSyncClientForTenantRestricted <Boolean>] [-IsWhiteboardFluidEnabled <Boolean>]
 [-LabelMismatchEmailHelpLink <String>] [-LegacyAuthProtocolsEnabled <Boolean>]
 [-LimitedAccessFileType <LimitedAccessFileType>] [-MachineLearningCaptureEnabled <Boolean>]
 [-MarkNewFilesSensitiveByDefault <SensitiveByDefaultState>]
 [-MediaTranscription <MediaTranscriptionPolicyType>] [-MobileFriendlyUrlEnabledInTenant <Boolean>]
 [-NoAccessRedirectUrl <String>] [-NotificationsInOneDriveEnabled <Boolean>]
 [-NotificationsInSharePointEnabled <Boolean>] [-NotifyOwnersWhenInvitationsAccepted <Boolean>]
 [-NotifyOwnersWhenItemsReshared <Boolean>] [-OfficeClientAdalDisabled <Boolean>]
 [-OneDriveAccessRequests <SharingState>] [-OneDriveForGuestsEnabled <Boolean>]
 [-OneDriveMembersCanShare <SharingState>] [-OneDriveSharingCapability <SharingCapabilities>]
 [-OneDriveStorageQuota <Int64>] [-OptOutOfGrooveBlock <Boolean>] [-OptOutOfGrooveSoftBlock <Boolean>]
 [-OrphanedPersonalSitesRetentionPeriod <Int32>] [-OwnerAnonymousNotification <Boolean>]
 [-PermissiveBrowserFileHandlingOverride <Boolean>] [-PreventExternalUsersFromResharing <Boolean>]
 [-ProvisionSharedWithEveryoneFolder <Boolean>] [-RequireAcceptingAccountMatchInvitedAccount <Boolean>]
 [-RequireAnonymousLinksExpireInDays <Int32>] [-SearchResolveExactEmailOrUpn <Boolean>]
 [-SharingAllowedDomainList <String>] [-SharingBlockedDomainList <String>]
 [-SharingCapability <SharingCapabilities>] [-SharingDomainRestrictionMode <SharingDomainRestrictionMode>]
 [-ShowAllUsersClaim <Boolean>] [-ShowEveryoneClaim <Boolean>]
 [-ShowEveryoneExceptExternalUsersClaim <Boolean>] [-SignInAccelerationDomain <String>]
 [-SocialBarOnSitePagesDisabled <Boolean>] [-SpecialCharactersStateInFileFolderNames <SpecialCharactersState>]
 [-StartASiteFormUrl <String>] [-StopNew2010Workflows <Boolean>] [-StopNew2013Workflows <Boolean>]
 [-SyncAzureAdB2BManagementPolicy <Boolean>] [-SyncPrivacyProfileProperties <Boolean>]
 [-UseFindPeopleInPeoplePicker <Boolean>] [-UsePersistentCookiesForExplorerView <Boolean>]
 [-WhoCanShareAllowListInTenant <String>] [-WhoCanShareAllowListInTenantByPrincipalIdentity <String[]>]
 [-Workflow2010Disabled <Boolean>] [<CommonParameters>]
```

## DESCRIPTION
The Set-KshTermDescription cmdlet changes properties of the tenant.

## EXAMPLES

### Example 1
```powershell
PS C:\> Set-KshTenant -SharingCapability Disabled
```

Changes properties of the tenant.

## PARAMETERS

### -AddressbarLinkPermission
Specifies the address bar link permission.

```yaml
Type: AddressbarLinkPermissions
Parameter Sets: (All)
Aliases:
Accepted values: None, View, Edit, Owner, LimitedView, LimitedEdit, Review, RestrictedView, Submit, ManageList

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AllowCommentsTextOnEmailEnabled
Specifies whether to allow enabling comments text on e-mail.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AllowDownloadingNonWebViewableFiles
Specifies whether to allow downloading of files that cannot be viewed on the web.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AllowEditing
Specifies whether to allow editing.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AllowLimitedAccessOnUnmanagedDevices
Specifies whether to allow limited access on unmanaged devices.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AllowOverrideForBlockUserInfoVisibility
Specifies whether to allow overrides for block user information visibility.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AllowedDomainListForSyncClient
Specifies the allowed domain list for sync client.

```yaml
Type: Guid[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AnyoneLinkTrackUsers
Specifies whether anyone links track users.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ApplyAppEnforcedRestrictionsToAdHocRecipients
Specifies whether to apply app enforced restrictions to ad-hoc recipients.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BccExternalSharingInvitations
Specifies whether to allow external sharing invitations to be sent as Bcc.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BccExternalSharingInvitationsList
Specifies the e-mail addresses external sharing invitations to be sent as Bcc.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BlockAccessOnUnmanagedDevices
Specifies whether to block access on unmanaged devices.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BlockDownloadLinksFileType
Specifies the file type of block download links.

```yaml
Type: BlockDownloadLinksFileType
Parameter Sets: (All)
Aliases:
Accepted values: WebPreviewableFiles, ServerRenderedFilesOnly

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BlockMacSync
Specifies whether to block synchronization from Mac.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BlockSendLabelMismatchEmail
Specifies whether to block to send e-mail when a sensitivity label mismatch.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BlockUserInfoVisibility
Specifies the block user info visibility.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BlockUserInfoVisibilityInOneDrive
Specifies whether to enable block the user info visibility in OneDrive.

```yaml
Type: TenantBrowseUserInfoPolicyValue
Parameter Sets: (All)
Aliases:
Accepted values: ApplyToNoUsers, ApplyToGuestAndExternalUsers

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BlockUserInfoVisibilityInSharePoint
Specifies whether to enable block the user info visibility in SharePoint.

```yaml
Type: TenantBrowseUserInfoPolicyValue
Parameter Sets: (All)
Aliases:
Accepted values: ApplyToNoUsers, ApplyToGuestAndExternalUsers

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CommentsOnFilesDisabled
Specifies whether to diable comment on files.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CommentsOnListItemsDisabled
Specifies whether to diable comment on lists.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CommentsOnSitePagesDisabled
Specifies whether to diable comment on site pages.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CompatibilityRange
Specifies the compatibility range.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ConditionalAccessPolicy
Specifies the conditional access policy type.

```yaml
Type: ConditionalAccessPolicyType
Parameter Sets: (All)
Aliases:
Accepted values: AllowFullAccess, AllowLimitedAccess, BlockAccess

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ConditionalAccessPolicyErrorHelpLink
Specifies the help link when conditional access policy error has occurred.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ContentTypeSyncSiteTemplatesList
Specifies the list of site template that synchronize content types.

```yaml
Type: String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CustomizedExternalSharingServiceUrl
Specifies whether to customize the external sharing service URL.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultContentCenterSite
Specifies the default content center site.

```yaml
Type: SiteInfoForSitePicker
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultLinkPermission
Specifies the default link permission type.

```yaml
Type: SharingPermissionType
Parameter Sets: (All)
Aliases:
Accepted values: None, View, Edit

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultOneDriveMode
Specifies the default OneDrive mode.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultSharingLinkType
Specifies the sharing link type.

```yaml
Type: SharingLinkType
Parameter Sets: (All)
Aliases:
Accepted values: None, Direct, Internal, AnonymousAccess

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisableAddToOneDrive
Specifies whether to disable \[Add to OneDrive\] shortcut.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisableBackToClassic
Specifies whether to disable \[Back to classic\] shortcut.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisableCustomAppAuthentication
Specifies whether to disable authentication of custom app via Azure ACS.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisableOutlookPSTVersionTrimming
Specifies whether to disable Outlook PST version trimming.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisablePersonalListCreation
Specifies whether to disable list creation to the personal site.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisableReportProblemDialog
Specifies whether to disable showing the dialog for reporting a problem.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisableSpacesActivation
Specifies whether to disable SharePoint spaces activation.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisabledModernListTemplateIds
Specifies whether to disable modern list template IDs.

```yaml
Type: Guid[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisabledWebPartIds
Specifies the web part IDs to disable.

```yaml
Type: Guid[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisallowInfectedFileDownload
Specifies whether to disallow download infected file.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayNamesOfFileViewers
Specifies whether to display names of file viewers.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayNamesOfFileViewersInSharePoint
Specifies whether to display names of file viewers in SharePoint.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayStartASiteOption
Specifies whether to display \[Start a site\] option.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EmailAttestationEnabled
Specifies whether to enable e-mail attestation.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EmailAttestationReAuthDays
Specifies the re-authentication days of e-mail attestation.

```yaml
Type: Int32
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EmailAttestationRequired
Specifies whether to require e-mail attestation.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EnableAIPIntegration
Specifies whether to enable Azure Information Protection intergration.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EnableAutoNewsDigest
Specifies whether to enable automate news digest.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EnableAzureAdB2BIntegration
Specifies whether to enable Azure AD B2B intergration.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EnableGuestSignInAcceleration
Specifies whether to enable sign-in acceleration for guest users.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EnableMinimumVersionRequirement
Specifies whether to enable minimum versio requirement.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EnableMipSiteLabel
Specifies whether to enable Microsoft Information Protection site label.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EnablePromotedFileHandlers
Specifies whether to enable promoted file handlers.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExcludedFileExtensionsForSyncClient
Specifies the file extensions that excluded for sync client.

```yaml
Type: String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExternalServicesEnabled
Specifies whether to enable external services.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExternalUserExpirationRequired
Specifies whether to require external user expiration.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExternalUserExpireInDays
Specifies the days that external user will be expire.

```yaml
Type: Int32
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FileAnonymousLinkType
Specifies the file anonymous link type.

```yaml
Type: AnonymousLinkType
Parameter Sets: (All)
Aliases:
Accepted values: None, View, Edit

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FilePickerExternalImageSearchEnabled
Specifies whether to enable file picker external image search.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FolderAnonymousLinkType
Specifies the folder anonymous link type.

```yaml
Type: AnonymousLinkType
Parameter Sets: (All)
Aliases:
Accepted values: None, View, Edit

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GuestSharingGroupAllowListInTenant
Specifies the allowed list of guest sharing groups in tenant.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GuestSharingGroupAllowListInTenantByPrincipalIdentity
Specifies the allowed list of guest sharing groups by principal identity in tenant.

```yaml
Type: String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -HasAdminCompletedCUConfiguration
Specifies whether the administrator has completed the CU configuration.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -HideDefaultThemes
Specifies whether to hide default themes.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -HideSyncButtonOnDocLib
Specifies whether to hide \[Sync\] button on document library.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -HideSyncButtonOnOneDrive
Specifies whether to \[Sync\] button on OneDrive.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IPAddressAllowList
Specifies the allowed list of IP address.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IPAddressEnforcement
Specifies whether to enforce IP addesses.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IPAddressWacTokenLifetime
Specifies the minites that werb access control token will be expired.

```yaml
Type: Int32
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ImageTaggingOption
Specifies the image tagging option.

```yaml
Type: ImageTaggingChoice
Parameter Sets: (All)
Aliases:
Accepted values: Disabled, Basic, Enhanced

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IncludeAtAGlanceInShareEmails
Specifies whether sharing emails include "At a glance" content.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InformationBarriersSuspension
Specifies whether to suppress information barriers.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsAppBarTemporarilyDisabled
Specifies whether the app bar is temprarily disabled. 

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsCollabMeetingNotesFluidEnabled
Specifies whether to enable Fluid Framework to collaboration meeting notes.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsFluidEnabled
Specifies whether to enable Fluid Framework.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsUnmanagedSyncClientForTenantRestricted
Specifies whether unmanaged sync client for client is restricted.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsWhiteboardFluidEnabled
Specifies whether to enable Fluid Framework to Microsoft Whiteboard.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LabelMismatchEmailHelpLink
Specifies the help link when the sensitivity label mismatch.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LegacyAuthProtocolsEnabled
Specifies whether to enable the legacy authentication protocols.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LimitedAccessFileType
Specifies the limited access file type.

```yaml
Type: LimitedAccessFileType
Parameter Sets: (All)
Aliases:
Accepted values: OfficeOnlineFilesOnly, WebPreviewableFiles, OtherFiles

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MachineLearningCaptureEnabled
Specifies whether to enable the machine learning capturing.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MarkNewFilesSensitiveByDefault
Specifies the to mark as sensitive to new files by default.

```yaml
Type: SensitiveByDefaultState
Parameter Sets: (All)
Aliases:
Accepted values: AllowExternalSharing, BlockExternalSharing

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MediaTranscription
Specifies the media transcription policy type.

```yaml
Type: MediaTranscriptionPolicyType
Parameter Sets: (All)
Aliases:
Accepted values: Enabled, Disabled

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MobileFriendlyUrlEnabledInTenant
Specifies whether to enable mobile friendly URL in tenant.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NoAccessRedirectUrl
Specifies the redirect URL when users cannot access.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NotificationsInOneDriveEnabled
Specifies whether to enable notifications in OneDrive.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NotificationsInSharePointEnabled
Specifies whether to enable notifications in SharePoint.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NotifyOwnersWhenInvitationsAccepted
Specifies whether to notify the owner when an invitation is accepted.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NotifyOwnersWhenItemsReshared
Specifies whether to notify the owner when an item is reshared.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OfficeClientAdalDisabled
Specifies whether to disable to using ADAL when sign in with Office client.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OneDriveAccessRequests
Specifies the policy on access requests to share in OneDrive.

```yaml
Type: SharingState
Parameter Sets: (All)
Aliases:
Accepted values: Unspecified, On, Off

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OneDriveForGuestsEnabled
Specifies whether to enable OneDrive creation for guest users.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OneDriveMembersCanShare
Specifies the policy on re-sharing behavior in OneDrive.

```yaml
Type: SharingState
Parameter Sets: (All)
Aliases:
Accepted values: Unspecified, On, Off

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OneDriveSharingCapability
Specifies the sharing capability for OneDrive.

```yaml
Type: SharingCapabilities
Parameter Sets: (All)
Aliases:
Accepted values: Disabled, ExternalUserSharingOnly, ExternalUserAndGuestSharing, ExistingExternalUserSharingOnly

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OneDriveStorageQuota
Specifies the storage quota for OneDrive.

```yaml
Type: Int64
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OptOutOfGrooveBlock
Specifies wheter to opt out of blocking legacy synchronization tools (Groove).

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OptOutOfGrooveSoftBlock
Specifies wheter to opt out of soft blocking legacy synchronization tools (Groove).

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OrphanedPersonalSitesRetentionPeriod
Specifies the days that orphaned personal sites will be retained.

```yaml
Type: Int32
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OwnerAnonymousNotification
Specifies wheter to enable owner anonymous notification.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PermissiveBrowserFileHandlingOverride
Specifies whether to override the permissive browser file handling.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PreventExternalUsersFromResharing
Specifies whether to prevent re-sharing by external users. 

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ProvisionSharedWithEveryoneFolder
Specifies whether to provision \[Shared with Everyone\] folder.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RequireAcceptingAccountMatchInvitedAccount
Specifies whether to require the accepting account to match the invited account.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RequireAnonymousLinksExpireInDays
Specifies the days that requires tha anonymous links will be expired.

```yaml
Type: Int32
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SearchResolveExactEmailOrUpn
Specifies whether to resolve the exact e-mail or UPN when searching.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SharingAllowedDomainList
Specifies the domain list that are allowed sharing.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SharingBlockedDomainList
Specifies the domain list that are blocked sharing.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SharingCapability
Specifies the sharing capability.

```yaml
Type: SharingCapabilities
Parameter Sets: (All)
Aliases:
Accepted values: Disabled, ExternalUserSharingOnly, ExternalUserAndGuestSharing, ExistingExternalUserSharingOnly

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SharingDomainRestrictionMode
Specifies the mode of the domain restriction of sharing.

```yaml
Type: SharingDomainRestrictionMode
Parameter Sets: (All)
Aliases:
Accepted values: None, AllowList, BlockList

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ShowAllUsersClaim
Specifies whether to show \[All users\] claim.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ShowEveryoneClaim
Specifies whether to show \[Everyone\] claim.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ShowEveryoneExceptExternalUsersClaim
Specifies whether to show \[Everyone except external users\] claim.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SignInAccelerationDomain
Specifies the sign-in acceleration domain.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SocialBarOnSitePagesDisabled
Specifies whether to disble the social bar on site pages.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SpecialCharactersStateInFileFolderNames
Specifies the state that indicating whether special characters to be used in file and folder names.

```yaml
Type: SpecialCharactersState
Parameter Sets: (All)
Aliases:
Accepted values: NoPreference, Allowed, Disallowed

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StartASiteFormUrl
Specifies the \[Start a site\] form URL.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StopNew2010Workflows
Specifies whether to stop the new SharePoint 2010 workflows.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StopNew2013Workflows
Specifies whether to stop the new SharePoint 2013 workflows.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SyncAzureAdB2BManagementPolicy
Specifies whether to synchronize Azure AD management policy.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SyncPrivacyProfileProperties
Specifies whether to synchronize privacy profile properties.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UseFindPeopleInPeoplePicker
Specifies whether to use Exchange supports Address Book Policy in people picker.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UsePersistentCookiesForExplorerView
Specifies whether to use persistent cookies for the explorer view.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhoCanShareAllowListInTenant
Specifies the list of users who are allowed to share in tenant.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhoCanShareAllowListInTenantByPrincipalIdentity
Specifies the list of users who are allowed to share in tenant by princpal ID.

```yaml
Type: String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Workflow2010Disabled
Specifies whether to disable SharePoint 2010 workflows.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### None

## OUTPUTS

### System.Void

## NOTES

## RELATED LINKS
