---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Move-KshViewColumn

## SYNOPSIS
Moves a view column.

## SYNTAX

### ParamSet1
```
Move-KshViewColumn [-View] <View> [-Column] <Column> [-NewIndex] <Int32> [<CommonParameters>]
```

### ParamSet2
```
Move-KshViewColumn [-View] <View> [-ColumnName] <String> [-NewIndex] <Int32> [<CommonParameters>]
```

## DESCRIPTION
The Move-KshViewColumn cmdlet moves a view column to the specified index.

## EXAMPLES

### Example 1
```powershell
PS C:> Move-KshViewColumn -View (Get-KshView -List (Get-KshList -ListTitle 'Announcements') -ViewTitle 'My Items') -Column (Get-KshColumn -List (Get-KshList -ListTitle 'Announcements') -ColumnName 'Remarks') -NewIndex 0
```

Moves a view column.

## PARAMETERS

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

### -NewIndex
Specifies the index.

```yaml
Type: Int32
Parameter Sets: (All)
Aliases:

Required: True
Position: 2
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

### None

## OUTPUTS

### None

## NOTES

## RELATED LINKS
