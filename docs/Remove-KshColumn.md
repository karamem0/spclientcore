---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Remove-KshColumn

## SYNOPSIS
Removes a column.

## SYNTAX

```
Remove-KshColumn [-Identity] <Column> [<CommonParameters>]
```

## DESCRIPTION
The Remove-KshColumn cmdlet removes a column from the current site or the specified group.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-KshColumn -Identity (Get-KshColumn -ColumnId '35aa78a6-66d7-472c-ab6b-d534193842af')
```

Removes a column from the current site.

### Example 2
```powershell
PS C:\> Remove-KshColumn -Identity (Get-KshColumn -List (Get-KshList -ListTitle 'Announcements') -ColumnId '35aa78a6-66d7-472c-ab6b-d534193842af')
```

Removes a column from the list.

## PARAMETERS

### -Identity
Specifies the column.

```yaml
Type: Column
Parameter Sets: (All)
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

### Karamem0.SharePoint.PowerShell.Models.Column

## OUTPUTS

### None

## NOTES

## RELATED LINKS
