---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Get-KshSiteCollection

## SYNOPSIS
Retrieves a site collection.

## SYNTAX

### ParamSet1
```
Get-KshSiteCollection [-Identity] <SiteCollection> [<CommonParameters>]
```

### ParamSet2
```
Get-KshSiteCollection [-SiteCollectionUrl] <Uri> [<CommonParameters>]
```

## DESCRIPTION
The Get-KshSiteCollection cmdlet retrieves a site collection.
This cmdlet can be used only when connected to the SharePoint admin center.

## EXAMPLES

### Example 1
```powershell
PS C:\> Get-KshSiteCollection -SiteCollectionUrl 'https://example.sharepoint.com/sites/hub'
```

Retrieves a site collection by site collection URL.

## PARAMETERS

### -Identity
Specifies the site collection.

```yaml
Type: SiteCollection
Parameter Sets: ParamSet1
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByValue)
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

### Karamem0.SharePoint.PowerShell.Models.SiteCollection

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.SiteCollection

## NOTES

## RELATED LINKS
