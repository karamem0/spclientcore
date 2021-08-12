---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Get-KshFileVersion

## SYNOPSIS
Retrieves one or more file versions.

## SYNTAX

### ParamSet1
```
Get-KshFileVersion [-Identity] <FileVersion> [<CommonParameters>]
```

### ParamSet2
```
Get-KshFileVersion [-File] <File> [-FileVersionId] <Int32> [<CommonParameters>]
```

### ParamSet3
```
Get-KshFileVersion [-File] <File> [-NoEnumerate] [<CommonParameters>]
```

## DESCRIPTION
The Get-KshFile cmdlet retrieves file versions of the specified file.

## EXAMPLES

### Example 1
```powershell
PS C:\> Get-KshFileVersion -File (Get-KshFile -FileUrl '/sites/japan/hr/Shared%20Documents/README.txt') -FileVersionId 1
```

Retrieves a file version by file version ID.

### Example 2
```powershell
PS C:\> Get-KshFileVersion -File (Get-KshFile -FileUrl '/sites/japan/hr/Shared%20Documents/README.txt')
```

Retrieves all file versions.

## PARAMETERS

### -File
Specifies the file.

```yaml
Type: File
Parameter Sets: ParamSet2, ParamSet3
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FileVersionId
Specifies the file version ID.

```yaml
Type: Int32
Parameter Sets: ParamSet2
Aliases:

Required: True
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Identity
Specifies the file version.

```yaml
Type: FileVersion
Parameter Sets: ParamSet1
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -NoEnumerate
If specified, suppresses to enumerate objects.

```yaml
Type: SwitchParameter
Parameter Sets: ParamSet3
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

### Karamem0.SharePoint.PowerShell.Models.FileVersion

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.FileVersion

## NOTES

## RELATED LINKS
