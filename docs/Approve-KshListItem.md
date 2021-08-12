---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Approve-KshListItem

## SYNOPSIS
Approves an approval request for the list item.

## SYNTAX

```
Approve-KshListItem [-Identity] <ListItem> [-Comment <String>] [-PassThru] [<CommonParameters>]
```

## DESCRIPTION
The Approve-KshListItem cmdlet approves an approval request for the list item. The approval status to be 'Approved'.

## EXAMPLES

### Example 1
```powershell
PS C:\> Approve-KshListItem -Identity (Get-KshListItem -List (Get-KshList -ListTitle 'Announcements') -ItemId 1)
```

Approves an approval request for the list item.

## PARAMETERS

### -Comment
Specifies the comment.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

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

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Karamem0.SharePoint.PowerShell.Models.ListItem

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.ListItem

## NOTES

## RELATED LINKS
