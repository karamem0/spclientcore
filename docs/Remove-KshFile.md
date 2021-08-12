---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Remove-KshFile

## SYNOPSIS
Removes a file.

## SYNTAX

### ParamSet1
```
Remove-KshFile [-Identity] <File> [-Force] [<CommonParameters>]
```

### ParamSet2
```
Remove-KshFile [-Identity] <File> [-RecycleBin] [<CommonParameters>]
```

## DESCRIPTION
The Remove-KshFile cmdlet removes a file from the parent folder.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-KshFile -Identity (Get-KshFile -FileUrl '/sites/japan/hr/Shared%20Documents/README.txt')
```

Removes a file.

### Example 2
```powershell
PS C:\> Remove-KshFile -Identity (Get-KshFile -FileUrl '/sites/japan/hr/Shared%20Documents/README.txt') -RecycleBin
```

Moves a file to the recycle bin.

## PARAMETERS

### -Force
If specified, removes the item bypassing shared lock.

```yaml
Type: SwitchParameter
Parameter Sets: ParamSet1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

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

### -RecycleBin
If specified, moves the item to the recycle bin.

```yaml
Type: SwitchParameter
Parameter Sets: ParamSet2
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

### Karamem0.SharePoint.PowerShell.Models.File

## OUTPUTS

### None

## NOTES

## RELATED LINKS
