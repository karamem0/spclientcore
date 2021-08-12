---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# New-KshListItem

## SYNOPSIS
Creates a new list item.

## SYNTAX

```
New-KshListItem [-List] <List> [-Value] <Hashtable> [<CommonParameters>]
```

## DESCRIPTION
The New-KshListItem cmdlet adds a new list item to the specified list.

## EXAMPLES

### Example 1
```powershell
PS C:\> New-KshListItem -List (Get-KshList -ListTitle 'Announcements') -Value @{ 'Title' = 'A Happy New Year' }
```

Creates a new list item.

## PARAMETERS

### -List
Specifies the list.

```yaml
Type: List
Parameter Sets: (All)
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Value
Specifies the column values.

```yaml
Type: Hashtable
Parameter Sets: (All)
Aliases:

Required: True
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Karamem0.SharePoint.PowerShell.Models.List

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.ListItem

## NOTES

## RELATED LINKS
