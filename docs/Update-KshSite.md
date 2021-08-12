---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Update-KshSite

## SYNOPSIS
Updates a site.

## SYNTAX

```
Update-KshSite [[-Identity] <Site>] [-AllowAutomaticASPXPageIndexing <Boolean>] [-AlternateCssUrl <String>]
 [-CommentsOnSitePagesDisabled <Boolean>] [-ContainsConfidentialInfo <Boolean>] [-CustomMasterUrl <String>]
 [-DisableAppViews <Boolean>] [-DisableFlows <Boolean>] [-Description <String>]
 [-EnableMinimalDownload <Boolean>] [-ExcludeFromOfflineClient <Boolean>] [-FooterEnabled <Boolean>]
 [-FooterLayout <FooterLayoutType>] [-HeaderEmphasis <VariantThemeType>] [-HeaderLayout <HeaderLayoutType>]
 [-HorizontalQuickLaunch <Boolean>] [-LogoAlignment <LogoAlignment>] [-MasterUrl <String>]
 [-MembersCanShare <Boolean>] [-MegaMenuEnabled <Boolean>] [-NavAudienceTargetingEnabled <Boolean>]
 [-NoCrawl <Boolean>] [-ObjectCacheEnabled <Boolean>] [-OverwriteTranslationsOnChange <Boolean>]
 [-QuickLaunchEnabled <Boolean>] [-RequestAccessEmail <String>] [-SaveSiteAsTemplateEnabled <Boolean>]
 [-SearchScope <SearchScopeType>] [-ServerRelativeUrl <String>] [-SiteLogoDescription <String>]
 [-SiteLogoUrl <String>] [-SyndicationEnabled <Boolean>] [-ThemedCssFolderUrl <String>] [-Title <String>]
 [-TreeViewEnabled <Boolean>] [-UIVersion <Int32>] [-UIVersionConfigurationEnabled <Boolean>] [-PassThru]
 [<CommonParameters>]
```

## DESCRIPTION
The Update-KshSite cmdlet updates properties of the site.

## EXAMPLES

### Example 1
```powershell
PS C:\> Update-KshSite -Identity (Get-KshSite -SiteId 'd298e576-6985-4119-9796-050b9f371872') -NoCrawl $true
```

Updates property values of the site.

## PARAMETERS

### -AllowAutomaticASPXPageIndexing
Specifies whether to allow automatic indexing of ASPX pages.

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

### -AlternateCssUrl
Specifies the alternate CSS URL.

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

### -CommentsOnSitePagesDisabled
Specifies whether to disable comment on site pages.

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

### -ContainsConfidentialInfo
Specifies whether to allow to contain confidential information.

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

### -CustomMasterUrl
Specifies the custom master URL.

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

### -Description
Specifies the description.

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

### -DisableAppViews
Specifies whether to disable the app views.

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

### -DisableFlows
Specifies whether to disable the Microsoft Flow.

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

### -EnableMinimalDownload
Specifies whether to enable minimal download.

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

### -ExcludeFromOfflineClient
Specifies whether to exclude from offline client.

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

### -FooterEnabled
Specifies whether to enable footer.

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

### -FooterLayout
Specifies the footer layout type.

```yaml
Type: FooterLayoutType
Parameter Sets: (All)
Aliases:
Accepted values: Simple, Extended, Stacked

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -HeaderEmphasis
Specifies the header emphasis type.

```yaml
Type: VariantThemeType
Parameter Sets: (All)
Aliases:
Accepted values: None, Neutral, Soft, Strong

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -HeaderLayout
Specifies the header layout type.

```yaml
Type: HeaderLayoutType
Parameter Sets: (All)
Aliases:
Accepted values: None, Standard, Compact, Minimal

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -HorizontalQuickLaunch
Specifies whether to show horizontal quick launch.

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

### -Identity
Specifies the site.

```yaml
Type: Site
Parameter Sets: (All)
Aliases:

Required: False
Position: 0
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -LogoAlignment
Specifies the logo alignment.

```yaml
Type: LogoAlignment
Parameter Sets: (All)
Aliases:
Accepted values: Left, Middle, Right

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MasterUrl
Specifies the master URL.

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

### -MegaMenuEnabled
Specifies whether to enable mega menu.

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

### -MembersCanShare
Specify whether members are allowed to share.

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

### -NavAudienceTargetingEnabled
Specify whether to enable navigation audience targeting.

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

### -NoCrawl
Specifies whether to suppress to search crawling.

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

### -ObjectCacheEnabled
Specifies whether to enable object cache.

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

### -OverwriteTranslationsOnChange
Specifies whether to overwrite translations.

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

### -PassThru
If specified, returns the updated object.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -QuickLaunchEnabled
Specifies whether to enable quick launch.

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

### -RequestAccessEmail
Specifies the e-mail address for access request.

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

### -SaveSiteAsTemplateEnabled
Specifies whether to enable saving the site as a template.

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

### -SearchScope
Specifies the search scope.

```yaml
Type: SearchScopeType
Parameter Sets: (All)
Aliases:
Accepted values: DefaultScope, Tenant, Hub, Site

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ServerRelativeUrl
Specifies the site relative URL.

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

### -SiteLogoDescription
Specifies the site logo description.

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

### -SiteLogoUrl
Specifies the site logo URL.

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

### -SyndicationEnabled
Specifies whether to enable syndication.

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

### -ThemedCssFolderUrl
Specifies the themed CSS folder URL.

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

### -TreeViewEnabled
Specifies whether to enable tree view.

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

### -UIVersion
Specifies the UI Version.

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

### -UIVersionConfigurationEnabled
Specifies whether to enable UI version configuration.

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

### Karamem0.SharePoint.PowerShell.Models.Site

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.Site

## NOTES

## RELATED LINKS
