---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Get-KshTenantSiteCollection

## SYNOPSIS
Retrieves one or more active site collections.

## SYNTAX

### ParamSet1
```
Get-KshTenantSiteCollection [-Identity] <TenantSiteCollection> [<CommonParameters>]
```

### ParamSet2
```
Get-KshTenantSiteCollection [-SiteCollectionUrl] <Uri> [<CommonParameters>]
```

### ParamSet3
```
Get-KshTenantSiteCollection [-GroupIdDefined] [-IncludePersonalSite] [-Template <String>] [-NoEnumerate]
 [<CommonParameters>]
```

## DESCRIPTION
The Get-KshTenantSiteCollection cmdlet retrieves active site collections.
This cmdlet can be used only when connected to the SharePoint admin center.

## EXAMPLES

### Example 1
```powershell
PS C:\> Get-KshTenantSiteCollection -SiteCollectionUrl 'https://example.sharepoint.com/sites/hub'
```

Retrieves a site collection by site collection URL.

### Example 2
```powershell
PS C:\> Get-KshTenantSiteCollection
```

Retrieves site collections excludes personal site collections.

### Example 3
```powershell
PS C:\> Get-KshTenantSiteCollection -GroupIdDefined
```

Retrieves Office 365 Groups site collections.

### Example 4
```powershell
PS C:\> Get-KshTenantSiteCollection -IncludePersonalSite
```

Retrieves site collections includes personal sites.

### Example 5
```powershell
PS C:\> Get-KshTenantSiteCollection -Template 'STS#0'
```

Retrieves team site (classic experience) site collections.

## PARAMETERS

### -GroupIdDefined
If specified, returns only Office 365 Groups site collections.

```yaml
Type: SwitchParameter
Parameter Sets: ParamSet3
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
Parameter Sets: ParamSet1
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -IncludePersonalSite
If specified, returns personal sites.

```yaml
Type: SwitchParameter
Parameter Sets: ParamSet3
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NoEnumerate
If specified, suppresses to enumerate objects.

```yaml
Type: SwitchParameter
Parameter Sets: ParamSet3
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SiteCollectionUrl
Specifies the site collection URL.

```yaml
Type: Uri
Parameter Sets: ParamSet2
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Template
Specifies the site template ID.

```yaml
Type: String
Parameter Sets: ParamSet3
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
