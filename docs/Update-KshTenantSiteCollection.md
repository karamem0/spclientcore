---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Update-KshTenantSiteCollection

## SYNOPSIS
Updates a site collection.

## SYNTAX

### ParamSet1
```
Update-KshTenantSiteCollection [-Identity] <TenantSiteCollection>
 [-AllowDownloadingNonWebViewableFiles <Boolean>] [-AllowEditing <Boolean>]
 [-AnonymousLinkExpirationInDays <Int32>] [-BlockDownloadLinksFileType <BlockDownloadLinksFileType>]
 [-CommentsOnSitePagesDisabled <Boolean>] [-ConditionalAccessPolicy <ConditionalAccessPolicyType>]
 [-DefaultLinkPermission <SharingPermissionType>] [-DefaultLinkToExistingAccess <Boolean>]
 [-DefaultSharingLinkType <SharingLinkType>] [-DenyAddAndCustomizePages <DenyAddAndCustomizePagesStatus>]
 [-DisableAppViews <AppViewsPolicy>] [-DisableCompanyWideSharingLinks <CompanyWideSharingLinksPolicy>]
 [-DisableFlows <FlowsPolicy>] [-ExternalUserExpirationInDays <Int32>]
 [-LimitedAccessFileType <LimitedAccessFileType>] [-Owner <String>] [-PWAEnabled <PWAEnabledStatus>]
 [-RestrictedToRegion <RestrictedToRegion>]
 [-SandboxedCodeActivationCapability <SandboxedCodeActivationCapabilities>]
 [-SharingAllowedDomainList <String>] [-SharingBlockedDomainList <String>]
 [-SharingCapability <SharingCapabilities>] [-SharingDomainRestrictionMode <SharingDomainRestrictionMode>]
 [-ShowPeoplePickerSuggestionsForGuestUsers <Boolean>] [-SocialBarOnSitePagesDisabled <Boolean>]
 [-StorageMaxLevel <Int64>] [-StorageWarningLevel <Int64>] [-Title <String>] [-UserCodeMaxLevel <Double>]
 [-UserCodeWarningLevel <Double>] [-PassThru] [<CommonParameters>]
```

### ParamSet2
```
Update-KshTenantSiteCollection [-Identity] <TenantSiteCollection>
 [-AllowDownloadingNonWebViewableFiles <Boolean>] [-AllowEditing <Boolean>]
 [-AnonymousLinkExpirationInDays <Int32>] [-BlockDownloadLinksFileType <BlockDownloadLinksFileType>]
 [-CommentsOnSitePagesDisabled <Boolean>] [-ConditionalAccessPolicy <ConditionalAccessPolicyType>]
 [-DefaultLinkPermission <SharingPermissionType>] [-DefaultLinkToExistingAccess <Boolean>]
 [-DefaultSharingLinkType <SharingLinkType>] [-DenyAddAndCustomizePages <DenyAddAndCustomizePagesStatus>]
 [-DisableAppViews <AppViewsPolicy>] [-DisableCompanyWideSharingLinks <CompanyWideSharingLinksPolicy>]
 [-DisableFlows <FlowsPolicy>] [-ExternalUserExpirationInDays <Int32>]
 [-LimitedAccessFileType <LimitedAccessFileType>] [-Owner <String>] [-PWAEnabled <PWAEnabledStatus>]
 [-RestrictedToRegion <RestrictedToRegion>]
 [-SandboxedCodeActivationCapability <SandboxedCodeActivationCapabilities>]
 [-SharingAllowedDomainList <String>] [-SharingBlockedDomainList <String>]
 [-SharingCapability <SharingCapabilities>] [-SharingDomainRestrictionMode <SharingDomainRestrictionMode>]
 [-ShowPeoplePickerSuggestionsForGuestUsers <Boolean>] [-SocialBarOnSitePagesDisabled <Boolean>]
 [-StorageMaxLevel <Int64>] [-StorageWarningLevel <Int64>] [-Title <String>] [-UserCodeMaxLevel <Double>]
 [-UserCodeWarningLevel <Double>] [-NoWait] [<CommonParameters>]
```

## DESCRIPTION
The Update-KshTenantSiteCollection cmdlet updates properties of the site collection.
This cmdlet can be used only when connected to the SharePoint admin center.

## EXAMPLES

### Example 1
```powershell
PS C:\> Update-KshTenantSiteCollection -Identity (Get-KshTenantSiteCollection -SiteCollectionUrl 'https://example.sharepoint.com/sites/hub') -Owner 'admin@example.onmicrosoft.com'
```

Updates property values of the site collection.

## PARAMETERS

### -AllowDownloadingNonWebViewableFiles
Specifies whether to allow to download files.

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
Specifies whether to allow editing Office files in the browser.

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

### -AnonymousLinkExpirationInDays
Specifies the days that anonymous link to be expired.

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

### -BlockDownloadLinksFileType
Specifies the block download links file type.

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

### -CommentsOnSitePagesDisabled
Specifies whether to disable comments on the site.

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

### -ConditionalAccessPolicy
Specifies the conditional access policy.

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

### -DefaultLinkPermission
Specifies the default link permission.

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

### -DefaultLinkToExistingAccess
Specifies whether to override default sharing link as existing access link.

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

### -DefaultSharingLinkType
Specifies the default sharing link type.

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

### -DenyAddAndCustomizePages
Specifies whether to deny to add and customize pages.

```yaml
Type: DenyAddAndCustomizePagesStatus
Parameter Sets: (All)
Aliases:
Accepted values: Unknown, Disabled, Enabled

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisableAppViews
Specifies the app views policy.

```yaml
Type: AppViewsPolicy
Parameter Sets: (All)
Aliases:
Accepted values: Unknown, Disabled, NotDisabled

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisableCompanyWideSharingLinks
Specifies the company-wide sharing links policy.

```yaml
Type: CompanyWideSharingLinksPolicy
Parameter Sets: (All)
Aliases:
Accepted values: Unknown, Disabled, NotDisabled

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisableFlows
Specifies the Microsoft Flow policy.

```yaml
Type: FlowsPolicy
Parameter Sets: (All)
Aliases:
Accepted values: Unknown, Disabled, NotDisabled

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExternalUserExpirationInDays
Specifies the days that external user to be expired.

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

### -Identity
Specifies the site collection.

```yaml
Type: TenantSiteCollection
Parameter Sets: (All)
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByValue)
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

### -NoWait
If specified, continue executing script immediately.

```yaml
Type: SwitchParameter
Parameter Sets: ParamSet2
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Owner
Specifies the owner.

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

### -PWAEnabled
Specifies the Project Web App status.

```yaml
Type: PWAEnabledStatus
Parameter Sets: (All)
Aliases:
Accepted values: Unknown, Disabled, Enabled

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PassThru
If specified, returns the updated object.

```yaml
Type: SwitchParameter
Parameter Sets: ParamSet1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RestrictedToRegion
Specifies the region restriction.

```yaml
Type: RestrictedToRegion
Parameter Sets: (All)
Aliases:
Accepted values: NoRestriction, BlockMoveOnly, BlockFull, Unknown

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SandboxedCodeActivationCapability
Specifies the sandboxed code capability.

```yaml
Type: SandboxedCodeActivationCapabilities
Parameter Sets: (All)
Aliases:
Accepted values: Unknown, Check, Disabled, Enabled

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SharingAllowedDomainList
Specifies the list of domain to allow sharing.

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
Specifies the list of domain to block sharing.

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
Specifies the sharing domain restriction mode.

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

### -ShowPeoplePickerSuggestionsForGuestUsers
Specifies whether to show people picker suggestions for guest users.

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

### -SocialBarOnSitePagesDisabled
Specifies whether to disable social bar on site.

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

### -StorageMaxLevel
Specifies the maximum quota of the storage.

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

### -StorageWarningLevel
Specifies the warning quota of the storage.

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

### -Title
Specifies the title.

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

### -UserCodeMaxLevel
Specifies the maximum quota of the server resource.

```yaml
Type: Double
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserCodeWarningLevel
Specifies the warning quota of the server resource.

```yaml
Type: Double
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

### Karamem0.SharePoint.PowerShell.Models.TenantSiteCollection

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.TenantSiteCollection

## NOTES

## RELATED LINKS
