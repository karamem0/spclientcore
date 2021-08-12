---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Unlock-KshFile

## SYNOPSIS
Checks in a file.

## SYNTAX

### ParamSet1
```
Unlock-KshFile [-Identity] <File> [-Comment <String>] [-CheckInType <CheckInType>] [-PassThru]
 [<CommonParameters>]
```

### ParamSet2
```
Unlock-KshFile [-Identity] <File> [-Undo] [-PassThru] [<CommonParameters>]
```

## DESCRIPTION
The Unlock-KshFile cmdlet checks in a file or discards a check-out file.

## EXAMPLES

### Example 1
```powershell
PS C:\> Unlock-KshFile -Identity (Get-KshFile -FolderUrl '/sites/japan/hr/Shared%20Documents/README.txt') -Comment 'Changed e-mail address'
```

Checks in the file.

### Example 2
```powershell
PS C:\> Unlock-KshFile -Identity (Get-KshFile -FolderUrl '/sites/japan/hr/Shared%20Documents/README.txt') -Undo
```

Discards the check-out file.

## PARAMETERS

### -CheckInType
Specifies the check-in type.

```yaml
Type: CheckInType
Parameter Sets: ParamSet1
Aliases:
Accepted values: MinorCheckIn, MajorCheckIn, OverwriteCheckIn

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Comment
Specifies the comment.

```yaml
Type: String
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

### -Undo
If specified, discards changes.

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

### Karamem0.SharePoint.PowerShell.Models.File

## NOTES

## RELATED LINKS
