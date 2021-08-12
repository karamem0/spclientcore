---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Remove-KshListItem

## SYNOPSIS
Removes a list item.

## SYNTAX

### ParamSet1
```
Remove-KshListItem [-Identity] <ListItem> [<CommonParameters>]
```

### ParamSet2
```
Remove-KshListItem [-Identity] <ListItem> [-RecycleBin] [<CommonParameters>]
```

## DESCRIPTION
The Remove-KshListItem cmdlet removes a list item from the parent list.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-KshListItem -Identity (Get-KshListItem -List (Get-KshList -ListTitle 'Announcements') -ItemId 1)
```

Removes a list item.

### Example 2
```powershell
PS C:\> Remove-KshListItem -Identity (Get-KshListItem -List (Get-KshList -ListTitle 'Announcements') -ItemId 1) -RecycleBin
```

Moves a list item to the recycle bin.

## PARAMETERS

### -Identity
Specifies the list item.

```yaml
Type: ListItem
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

### Karamem0.SharePoint.PowerShell.Models.ListItem

## OUTPUTS

### None

## NOTES

## RELATED LINKS
