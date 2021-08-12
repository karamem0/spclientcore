---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Get-KshTenantDeletedPersonalSiteCollection

## SYNOPSIS
Retrieves one or more deleted personal site collections.

## SYNTAX

### ParamSet1
```
Get-KshTenantDeletedPersonalSiteCollection [-SiteCollectionUrl] <Uri> [-NoEnumerate] [<CommonParameters>]
```

### ParamSet2
```
Get-KshTenantDeletedPersonalSiteCollection [-NoEnumerate] [<CommonParameters>]
```

## DESCRIPTION
The Get-KshTenantDeletedPersonalSiteCollection cmdlet retrieves deleted personal site collections.
This cmdlet can be used only when connected to the SharePoint admin center.

## EXAMPLES

### Example 1
```powershell
PS C:\> Get-KshTenantDeletedPersonalSiteCollection -SiteCollectionUrl 'https://example-my.sharepoint.com/personal/admin_example_onmicrosoft_com'
```

Retrieves deleted personal site collections by site collection URL.

### Example 2
```powershell
PS C:\> Get-KshTenantDeletedPersonalSiteCollection
```

Retrieves all deleted personal site collections.

## PARAMETERS

### -NoEnumerate
If specified, suppresses to enumerate objects.

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

### -SiteCollectionUrl
Specifies the site collection URL.

```yaml
Type: Uri
Parameter Sets: ParamSet1
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

### None

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.TenantDeletedSiteCollection

## NOTES

## RELATED LINKS
