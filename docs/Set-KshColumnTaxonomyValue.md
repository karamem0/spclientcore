---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Set-KshColumnTaxonomyValue

## SYNOPSIS
Changes a taxonomy column value.

## SYNTAX

```
Set-KshColumnTaxonomyValue [-Column] <ColumnTaxonomy> [-ListItem] <ListItem> -Value <Term[]> -Lcid <UInt32>
 [<CommonParameters>]
```

## DESCRIPTION
Set-KshColumnTaxonomyValue changes the taxonomy column value of the specified list item.

## EXAMPLES

### Example 1
```powershell
PS C:\> Set-KshColumnTaxonomyValue -Column (Get-KshColumn -ColumnId '35aa78a6-66d7-472c-ab6b-d534193842af' -List (Get-KshList -ListTitle 'Announcements')) -ListItem (Get-KshListItem -List (Get-KshList -ListTitle 'Announcements') -ItemId 1) -Value (Get-KshTerm -TermSet (Get-KshTermSet -TermGroup (Get-KshTermGroup -TermGroupName 'Company') -TermSetName 'Department') -TermId '4e45662f-c021-41fd-b413-967bf413d369') -Lcid 1033
```

Changes a taxonomy column value.

## PARAMETERS

### -Column
Specifies the taxonomy column.

```yaml
Type: ColumnTaxonomy
Parameter Sets: (All)
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Lcid
Specifies the locale ID.
For more information, see [reference](https://docs.microsoft.com/ja-jp/openspecs/windows_protocols/ms-lcid/70feba9f-294e-491e-b6eb-56532684c37f).

```yaml
Type: UInt32
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ListItem
Specifies the list item.

```yaml
Type: ListItem
Parameter Sets: (All)
Aliases:

Required: True
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Value
Specifies the terms.

```yaml
Type: Term[]
Parameter Sets: (All)
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

### None

## OUTPUTS

### None

## NOTES

## RELATED LINKS
