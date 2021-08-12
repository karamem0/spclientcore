---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Get-KshDocumentLibrary

## SYNOPSIS
Retrieves one or more document libraries.

## SYNTAX

### ParamSet1
```
Get-KshDocumentLibrary [-Default] [<CommonParameters>]
```

### ParamSet2
```
Get-KshDocumentLibrary [-IncludeMediaLibraries] [-IncludePageLibraries] [-NoEnumerate] [<CommonParameters>]
```

## DESCRIPTION
The Get-KshDocumentLibrary cmdlet retrieves document libraries of the current site.

## EXAMPLES

### Example 1
```powershell
PS C:\> Get-KshDocumentLibrary -Default
```

Retrieves the default document library.

### Example 2
```powershell
PS C:\> Get-KshDocumentLibrary -IncludeMediaLibraries -IncludePageLibraries
```

Retrieves document libraries includes media libraries and page libraries.

## PARAMETERS

### -Default
If specified, returns default document library.

```yaml
Type: SwitchParameter
Parameter Sets: ParamSet1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IncludeMediaLibraries
If specified, includes media libraries.

```yaml
Type: SwitchParameter
Parameter Sets: ParamSet2
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IncludePageLibraries
If specified, includes page libraries.
This parameter is ignored if the IncludeMediaLibraries parameter is set to false.

```yaml
Type: SwitchParameter
Parameter Sets: ParamSet2
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NoEnumerate
If specified, suppresses to enumerate objects.

```yaml
Type: SwitchParameter
Parameter Sets: ParamSet2
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

### None

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.DocumentLibraryInformation

## NOTES

## RELATED LINKS
