---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Add-KshSiteCollectionAppCatalog

## SYNOPSIS
Adds a site collection app catalog.

## SYNTAX

### ParamSet1
```
Add-KshSiteCollectionAppCatalog -SiteCollection <SiteCollection> [<CommonParameters>]
```

### ParamSet2
```
Add-KshSiteCollectionAppCatalog -TenantSiteCollection <TenantSiteCollection> [<CommonParameters>]
```

### ParamSet3
```
Add-KshSiteCollectionAppCatalog -SiteCollectionUrl <Uri> [<CommonParameters>]
```

## DESCRIPTION
The Add-KshSiteCollectionAppCatalog cmdlet adds a site collection app catalog to the tenant.

## EXAMPLES

### Example 1
```powershell
PS C:\> Add-KshSiteCollectionAppCatalog -SiteCollection (Get-KshCurrentSiteCollection)
```

Adds a site collection app catalog.

## PARAMETERS

### -SiteCollection
Specifies the site collection.

```yaml
Type: SiteCollection
Parameter Sets: ParamSet1
Aliases:

Required: True
Position: Named
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
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TenantSiteCollection
Specifies the tenant site collection.

```yaml
Type: TenantSiteCollection
Parameter Sets: ParamSet2
Aliases:

Required: True
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

### None

## NOTES

## RELATED LINKS
