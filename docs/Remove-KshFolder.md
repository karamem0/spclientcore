---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Remove-KshFolder

## SYNOPSIS
Removes a folder.

## SYNTAX

### ParamSet1
```
Remove-KshFolder [-Identity] <Folder> [<CommonParameters>]
```

### ParamSet2
```
Remove-KshFolder [-Identity] <Folder> [-RecycleBin] [<CommonParameters>]
```

## DESCRIPTION
The Remove-KshFolder cmdlet removes a folder from the parent folder.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-KshFolder -Identity (Get-KshFolder -FolderUrl '/sites/japan/hr/Shared%20Documents/Templates')
```

Removes a folder.

### Example 2
```powershell
PS C:\> Remove-KshFolder -Identity (Get-KshFolder -FolderUrl '/sites/japan/hr/Shared%20Documents/Templates')-RecycleBin
```

Moves a folder to the recycle bin.

## PARAMETERS

### -Identity
Specifies the folder.

```yaml
Type: Folder
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

### Karamem0.SharePoint.PowerShell.Models.Folder

## OUTPUTS

### None

## NOTES

## RELATED LINKS
