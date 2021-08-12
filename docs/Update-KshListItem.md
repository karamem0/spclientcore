---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Update-KshListItem

## SYNOPSIS
Updates a list item.

## SYNTAX

```
Update-KshListItem [-Identity] <ListItem> [-Value <Hashtable>] [-SystemUpdate] [-PassThru] [<CommonParameters>]
```

## DESCRIPTION
The Update-KshListItem cmdlet updates column values of the list item.

## EXAMPLES

### Example 1
```powershell
PS C:\> Update-KshListItem -Identity (Get-KshListItem -List (Get-KshList -ListTitle 'Announcements') -ItemId 1) -Value @{ 'Title' = 'A Happy New Year' }
```

Updates column values of the list item.

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

### -SystemUpdate
If specified, uses system update.

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

### -Value
Specifies the column values.

```yaml
Type: Hashtable
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

### Karamem0.SharePoint.PowerShell.Models.ListItem

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.ListItem

## NOTES

## RELATED LINKS
