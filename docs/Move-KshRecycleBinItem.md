---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Move-KshRecycleBinItem

## SYNOPSIS
Moves a recycle bin item to the second stage.

## SYNTAX

### ParamSet1
```
Move-KshRecycleBinItem [-Identity] <RecycleBinItem> [<CommonParameters>]
```

### ParamSet2
```
Move-KshRecycleBinItem [-All] [<CommonParameters>]
```

## DESCRIPTION
The Move-KshRecycleBinItem cmdlet moves a recycle bin item to the second stage.

## EXAMPLES

### Example 1
```powershell
PS C:\> Move-KshRecycleBinItem -Identity (Get-KshRecycleBinItem -ItemId '77566246-6e0d-4bc7-8360-689b8743265f')
```

Moves a recycle bin item to the second stage.

### Example 1
```powershell
PS C:\> Move-KshRecycleBinItem -All
```

Moves all recycle bin item to the second stage.

## PARAMETERS

### -All
If specified, removes all recycle bin items.

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
