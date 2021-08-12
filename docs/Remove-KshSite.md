---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Remove-KshSite

## SYNOPSIS
Removes a site.

## SYNTAX

```
Remove-KshSite [-Identity] <Site> [<CommonParameters>]
```

## DESCRIPTION
The Remove-KshSite cmdlet removes a site from the current site collection.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-KshSite (Get-KshSite -SiteId 'd298e576-6985-4119-9796-050b9f371872')
```

Removes a site.

## PARAMETERS

### -Identity
Specifies the site.

```yaml
Type: Site
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

### Karamem0.SharePoint.PowerShell.Models.Site

## OUTPUTS

### None

## NOTES

## RELATED LINKS
