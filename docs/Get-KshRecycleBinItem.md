---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Get-KshRecycleBinItem

## SYNOPSIS
Retrieves one or more recycle bin items.

## SYNTAX

### ParamSet1
```
Get-KshRecycleBinItem [-Identity] <RecycleBinItem> [<CommonParameters>]
```

### ParamSet2
```
Get-KshRecycleBinItem [-ItemId] <Guid> [-SecondStage] [<CommonParameters>]
```

### ParamSet3
```
Get-KshRecycleBinItem [-SecondStage] [-NoEnumerate] [<CommonParameters>]
```

## DESCRIPTION
The Get-KshRecycleBinItem cmdlet retrieves recycle bin items of the current site.

## EXAMPLES

### Example 1
```powershell
PS C:\> Get-KshRecycleBinItem -ItemId '77566246-6e0d-4bc7-8360-689b8743265f'
```

Retrieves a recycle bin item by recycle bin item ID.

### Example 2
```powershell
PS C:\> Get-KshRecycleBinItem
```

Retrieves all recycle bin items.

## PARAMETERS

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

### -ItemId
Specifies the recycle bin item ID.

```yaml
Type: Guid
Parameter Sets: ParamSet2
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: False
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

### -SecondStage
If specified, retrieves the second stage recycle bin items.

```yaml
Type: SwitchParameter
Parameter Sets: ParamSet2, ParamSet3
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

### Karamem0.SharePoint.PowerShell.Models.RecycleBinItem

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.RecycleBinItem

## NOTES

## RELATED LINKS
