---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Remove-KshSiteCollectionAppCatalog

## SYNOPSIS
Removes a site collection app catalog.

## SYNTAX

```
Remove-KshSiteCollectionAppCatalog [-Identity] <SiteCollectionAppCatalog> [<CommonParameters>]
```

## DESCRIPTION
The Remove-KshSiteCollectionAppCatalog cmdlet removes a site collection app catalog from the tenant.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-KshSiteCollectionAppCatalog -Identity (Get-KshSiteCollectionAppCatalog -SiteCollection (Get-KshCurrentSiteCollection))
```

Removes a site collection app catalog.

## PARAMETERS

### -Identity
Specifies the site collection app catalog.

```yaml
Type: SiteCollectionAppCatalog
Parameter Sets: (All)
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Karamem0.SharePoint.PowerShell.Models.SiteCollectionAppCatalog

## OUTPUTS

### None

## NOTES

## RELATED LINKS
