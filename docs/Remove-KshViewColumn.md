---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Remove-KshViewColumn

## SYNOPSIS
Removes a view column.

## SYNTAX

### ParamSet1
```
Remove-KshViewColumn [-View] <View> [-Column] <Column> [<CommonParameters>]
```

### ParamSet2
```
Remove-KshViewColumn [-View] <View> [-ColumnName] <String> [<CommonParameters>]
```

### ParamSet3
```
Remove-KshViewColumn [-View] <View> [-All] [<CommonParameters>]
```

## DESCRIPTION
The Remove-KshViewColumn cmdlet removes a column from the specified view.

## EXAMPLES

### Example 1
```powershell
PS C:> Remove-KshViewColumn -View (Get-KshView -List (Get-KshList -ListTitle 'Announcements') -ViewTitle 'My Items') -Column (Get-KshColumn -List (Get-KshList -ListTitle 'Announcements') -ColumnName 'Remarks')
```

Removes a view column.

### Example 2
```powershell
PS C:> Remove-KshViewColumn -View (Get-KshView -List (Get-KshList -ListTitle 'Announcements') -ViewTitle 'My Items') -All
```

Removes all view columns.

## PARAMETERS

### -All
If specified, removes all columns.

```yaml
Type: SwitchParameter
Parameter Sets: ParamSet3
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Column
Specifies the column.

```yaml
Type: Column
Parameter Sets: ParamSet1
Aliases:

Required: True
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ColumnName
Specifies the column name.

```yaml
Type: String
Parameter Sets: ParamSet2
Aliases:

Required: True
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -View
Specifies the view.

```yaml
Type: View
Parameter Sets: (All)
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Karamem0.SharePoint.PowerShell.Models.View

## OUTPUTS

### None

## NOTES

## RELATED LINKS
