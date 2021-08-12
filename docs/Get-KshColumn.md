---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Get-KshColumn

## SYNOPSIS
Retrieves one or more columns.

## SYNTAX

### ParamSet1
```
Get-KshColumn [-Identity] <Column> [<CommonParameters>]
```

### ParamSet2
```
Get-KshColumn [-ContentType] <ContentType> [-ColumnId] <Guid> [<CommonParameters>]
```

### ParamSet3
```
Get-KshColumn [-ContentType] <ContentType> [-ColumnTitle] <String> [<CommonParameters>]
```

### ParamSet4
```
Get-KshColumn [-ContentType] <ContentType> [-NoEnumerate] [<CommonParameters>]
```

### ParamSet5
```
Get-KshColumn [-List] <List> [-ColumnId] <Guid> [<CommonParameters>]
```

### ParamSet6
```
Get-KshColumn [-List] <List> [-ColumnTitle] <String> [<CommonParameters>]
```

### ParamSet7
```
Get-KshColumn [-List] <List> [-NoEnumerate] [<CommonParameters>]
```

### ParamSet8
```
Get-KshColumn [-ColumnId] <Guid> [<CommonParameters>]
```

### ParamSet9
```
Get-KshColumn [-ColumnTitle] <String> [<CommonParameters>]
```

### ParamSet10
```
Get-KshColumn [-NoEnumerate] [<CommonParameters>]
```

## DESCRIPTION
The Get-KshColumn cmdlet retrieves columns of the current site or the specified content type.

## EXAMPLES

### Example 1
```powershell
PS C:\> Get-KshColumn -ColumnId '35aa78a6-66d7-472c-ab6b-d534193842af'
```

Retrieves a column by column ID.

### Example 2
```powershell
PS C:\> Get-KshColumn -ColumnTitle 'Remarks'
```

Retrieves a column by column title.

### Example 3
```powershell
PS C:\> Get-KshColumn -ContentType (Get-KshContentType -List (Get-KshList -ListTitle 'Announcements') -ContentTypeId '0x0100EFB1758564C77D448177233D1199B912000A210B1C5CBC634C849328008B1CC306')
```

Retrieves all columns of the list content type.

### Example 4
```powershell
PS C:\> Get-KshColumn -ContentType (Get-KshContentType -ContentTypeId '0x0100EFB1758564C77D448177233D1199B912')
```

Retrieves all columns of the site content type.

### Example 5
```powershell
PS C:\> Get-KshColumn -List (Get-KshList -ListTitle 'Announcements')
```

Retrieves all columns of the list.

### Example 6
```powershell
PS C:\> Get-KshColumn
```

Retrieves all columns of the current site.

## PARAMETERS

### -ColumnId
Specifies the column ID.

```yaml
Type: Guid
Parameter Sets: ParamSet2, ParamSet5, ParamSet8
Aliases:

Required: True
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ColumnTitle
Specifies the column title.

```yaml
Type: String
Parameter Sets: ParamSet3, ParamSet6, ParamSet9
Aliases:

Required: True
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ContentType
Specifies the content type.

```yaml
Type: ContentType
Parameter Sets: ParamSet2, ParamSet3, ParamSet4
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Identity
Specifies the column.

```yaml
Type: Column
Parameter Sets: ParamSet1
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -List
Specifies the list.

```yaml
Type: List
Parameter Sets: ParamSet5, ParamSet6, ParamSet7
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
Parameter Sets: ParamSet4, ParamSet7, ParamSet10
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

### Karamem0.SharePoint.PowerShell.Models.Column

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.ContentType

## NOTES

## RELATED LINKS
