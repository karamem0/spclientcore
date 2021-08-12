---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Select-KshSite

## SYNOPSIS
Selects a site.

## SYNTAX

```
Select-KshSite [-Identity] <Site> [-PassThru] [<CommonParameters>]
```

## DESCRIPTION
The Select-KshSite cmdlet changes the current site.
In order to change the current site to a different site collections, invoke the Connect-KshSite cmdlet.

## EXAMPLES

### Example 1
```powershell
PS C:\> Select-KshSite -Identity (Get-KshSite -SiteId 'd298e576-6985-4119-9796-050b9f371872')
```

Selects the site.

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

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Karamem0.SharePoint.PowerShell.Models.Site

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.Site

## NOTES

## RELATED LINKS
