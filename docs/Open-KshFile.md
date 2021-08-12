---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Open-KshFile

## SYNOPSIS
Opens a file.

## SYNTAX

```
Open-KshFile [-Identity] <File> [<CommonParameters>]
```

## DESCRIPTION
The Open-KshFile cmdlet retrieves contents of the file.

## EXAMPLES

### Example 1
```powershell
PS C:\> Open-KshFile -Identity (Get-KshFile -FileUrl '/sites/japan/hr/Shared%20Documents/README.txt')
```

Retrieves contents of the file.

## PARAMETERS

### -Identity
Specifies the file.

```yaml
Type: File
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

### Karamem0.SharePoint.PowerShell.Models.File

## OUTPUTS

### System.IO.Stream

## NOTES

## RELATED LINKS
