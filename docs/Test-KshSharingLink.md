---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Test-KshSharingLink

## SYNOPSIS
Checks the sharing link kind for the URL.

## SYNTAX

```
Test-KshSharingLink -Url <String> [<CommonParameters>]
```

## DESCRIPTION
The Test-KshSharingLink cmdlet returns a value that indicates the kind of sharing link.

## EXAMPLES

### Example 1
```powershell
PS C:\> Test-KshSharingLink -Url 'https://example.sharepoint.com/:t:/s/sites/hub/EVBeuV4c9jlDgXhzIYX9kaQBOAEhx90hSL_n0A-yQcGZyA'
```

Checks the sharing link.

## PARAMETERS

### -Url
Specifies the URL.

```yaml
Type: String
Parameter Sets: (All)
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

### Karamem0.SharePoint.PowerShell.Models.SharingLinkKind

## NOTES

## RELATED LINKS
