---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Lock-KshFile

## SYNOPSIS
Checks out a file.

## SYNTAX

```
Lock-KshFile [-Identity] <File> [-PassThru] [<CommonParameters>]
```

## DESCRIPTION
The Lock-KshFile cmdlet checks out a file.

## EXAMPLES

### Example 1
```powershell
PS C:\> Lock-KshFile -Identity (Get-KshFile -FolderUrl '/sites/japan/hr/Shared%20Documents/README.txt')
```

Checks out the file.

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

### Karamem0.SharePoint.PowerShell.Models.File

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.File

## NOTES

## RELATED LINKS
