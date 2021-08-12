---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Restore-KshRecycleBinItem

## SYNOPSIS
Restore a recycle bin item.

## SYNTAX

### ParamSet1
```
Restore-KshRecycleBinItem [-Identity] <RecycleBinItem> [<CommonParameters>]
```

### ParamSet2
```
Restore-KshRecycleBinItem [-All] [<CommonParameters>]
```

## DESCRIPTION
The Restore-KshRecycleBinItem cmdlet moves a recycle bin item to its original location.

## EXAMPLES

### Example 1
```powershell
PS C:\> Restore-KshRecycleBinItem -Identity (Get-KshRecycleBinItem -ItemId '77566246-6e0d-4bc7-8360-689b8743265f')
```

Restores a recycle bin item.

### Example 2
```powershell
PS C:\> Restore-KshRecycleBinItem -All
```

Restores all recycle bin items.

## PARAMETERS

### -All
If specified, restores all recycle bin items.

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

### -Identity
Specifies the recycle bin item.

```yaml
Type: RecycleBinItem
Parameter Sets: ParamSet1
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

### Karamem0.SharePoint.PowerShell.Models.RecycleBinItem

## OUTPUTS

### None

## NOTES

## RELATED LINKS
