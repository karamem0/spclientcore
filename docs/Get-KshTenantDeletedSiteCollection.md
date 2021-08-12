---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Get-KshTenantDeletedSiteCollection

## SYNOPSIS
Retrieves one or more deleted site collections.

## SYNTAX

### ParamSet1
```
Get-KshTenantDeletedSiteCollection [-Identity] <TenantDeletedSiteCollection> [<CommonParameters>]
```

### ParamSet2
```
Get-KshTenantDeletedSiteCollection [-SiteCollectionUrl] <Uri> [<CommonParameters>]
```

### ParamSet3
```
Get-KshTenantDeletedSiteCollection [-NoEnumerate] [<CommonParameters>]
```

## DESCRIPTION
The Get-KshTenantDeletedSiteCollection cmdlet retrieves deleted site collections.
This cmdlet can be used only when connected to the SharePoint admin center.

## EXAMPLES

### Example 1
```powershell
PS C:\> Get-KshTenantDeletedSiteCollection -SiteCollectionUrl 'https://example.sharepoint.com/sites/hub'
```

Retrieves a deleted site collection by site collection URL.

### Example 2
```powershell
PS C:\> Get-KshTenantDeletedSiteCollection
```

Retrieves all deleted site collections.

## PARAMETERS

### -Identity
Specifies the deleted site collection.

```yaml
Type: TenantDeletedSiteCollection
Parameter Sets: ParamSet1
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByValue)
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

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Karamem0.SharePoint.PowerShell.Models.TenantDeletedSiteCollection

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.TenantDeletedSiteCollection

## NOTES

## RELATED LINKS
