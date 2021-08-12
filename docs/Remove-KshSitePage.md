---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Remove-KshSitePage

## SYNOPSIS
Removes a site page.

## SYNTAX

### ParamSet1
```
Remove-KshSitePage [-List] <List> [-PageName] <String> [<CommonParameters>]
```

### ParamSet2
```
Remove-KshSitePage [-PageName] <String> [<CommonParameters>]
```

## DESCRIPTION
The Remove-KshSitePage cmdlet removes a site page from the site page library or the specified list.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-KshSitePage -PageName 'News'
```

Removes a site page.

## PARAMETERS

### -List
Specifies the list.

```yaml
Type: List
Parameter Sets: ParamSet1
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PageName
Specifies the page name.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: True
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Karamem0.SharePoint.PowerShell.Models.List

## OUTPUTS

### None

## NOTES

## RELATED LINKS
