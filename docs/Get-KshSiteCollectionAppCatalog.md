---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Get-KshSiteCollectionAppCatalog

## SYNOPSIS
Retrieves one or more site collection app catalogs.

## SYNTAX

### ParamSet1
```
Get-KshSiteCollectionAppCatalog [-Identity] <SiteCollectionAppCatalog> [<CommonParameters>]
```

### ParamSet2
```
Get-KshSiteCollectionAppCatalog [-SiteCollection] <SiteCollection> [-NoEnumerate] [<CommonParameters>]
```

### ParamSet3
```
Get-KshSiteCollectionAppCatalog [-SiteCollectionUrl] <Uri> [-NoEnumerate] [<CommonParameters>]
```

### ParamSet4
```
Get-KshSiteCollectionAppCatalog [-SiteCollectionId] <Guid> [-NoEnumerate] [<CommonParameters>]
```

### ParamSet5
```
Get-KshSiteCollectionAppCatalog [-NoEnumerate] [<CommonParameters>]
```

## DESCRIPTION
The Get-KshSiteCollectionAppCatalog cmdlet retrieves site collection app catalogs in the tenant.

## EXAMPLES

### Example 1
```powershell
PS C:\> Get-KshSiteCollectionAppCatalog -SiteCollection (Get-KshCurrentSiteCollection)
```

Retrieves a site collection app catalog.

### Example 2
```powershell
PS C:\> Get-KshSiteCollectionAppCatalog
```

Retrieves all site collection app catalogs.

## PARAMETERS

### -Identity
Specifies the site collection app catalog.

```yaml
Type: SiteCollectionAppCatalog
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
Parameter Sets: ParamSet2, ParamSet3, ParamSet4, ParamSet5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SiteCollection
Specifies the site collection.

```yaml
Type: SiteCollection
Parameter Sets: ParamSet2
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SiteCollectionId
Specifies the site collection ID.

```yaml
Type: Guid
Parameter Sets: ParamSet4
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SiteCollectionUrl
Specifies the site collection URL.

```yaml
Type: Uri
Parameter Sets: ParamSet3
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

### Karamem0.SharePoint.PowerShell.Models.SiteCollectionAppCatalog

## NOTES

## RELATED LINKS
