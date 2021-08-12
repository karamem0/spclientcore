---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Restore-KshFileVersion

## SYNOPSIS
Restore a file version.

## SYNTAX

```
Restore-KshFileVersion [-Identity] <FileVersion> [<CommonParameters>]
```

## DESCRIPTION
The Restore-KshFileVersion cmdlet creates a new file version from the specified file version.

## EXAMPLES

### Example 1
```powershell
PS C:\> Restore-KshFileVersion -Identity (Get-KshFileVersion -File (Get-KshFile -FileUrl '/sites/japan/hr/Shared%20Documents/README.txt') -FileVersionId 1)
```

Restores a file version.

## PARAMETERS

### -Identity
Specifies the file version.

```yaml
Type: FileVersion
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

### Karamem0.SharePoint.PowerShell.Models.FileVersion

## OUTPUTS

### None

## NOTES

## RELATED LINKS
