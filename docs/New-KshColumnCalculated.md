---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# New-KshColumnCalculated

## SYNOPSIS
Creates a new column of calculated type.

## SYNTAX

### ParamSet1
```
New-KshColumnCalculated [-List] <List> [-ClientSideComponentId <String>]
 [-ClientSideComponentProperties <String>] -Columns <Column[]> [-CurrencyLcid <UInt32>]
 [-CustomFormatter <String>] [-DateFormat <ColumnDateTimeFormatType>] [-Description <String>]
 [-Direction <String>] -Formula <String> [-Group <String>] [-Hidden <Boolean>] [-Id <Guid>] [-JSLink <String>]
 -Name <String> [-NoCrawl <Boolean>] [-NumberFormat <Int32>] -OutputType <ColumnType>
 [-ShowAsPercentage <Boolean>] [-StaticName <String>] [-Title <String>] [-AddToDefaultContentType]
 [-AddToNoContentType] [-AddToAllContentTypes] [-AddColumnInternalNameHint] [-AddColumnToDefaultView]
 [-AddColumnCheckDisplayName] [-AddToDefaultView] [<CommonParameters>]
```

### ParamSet2
```
New-KshColumnCalculated [-ClientSideComponentId <String>] [-ClientSideComponentProperties <String>]
 -Columns <Column[]> [-CurrencyLcid <UInt32>] [-CustomFormatter <String>]
 [-DateFormat <ColumnDateTimeFormatType>] [-Description <String>] [-Direction <String>] -Formula <String>
 [-Group <String>] [-Hidden <Boolean>] [-Id <Guid>] [-JSLink <String>] -Name <String> [-NoCrawl <Boolean>]
 [-NumberFormat <Int32>] -OutputType <ColumnType> [-ShowAsPercentage <Boolean>] [-StaticName <String>]
 [-Title <String>] [-AddToDefaultContentType] [-AddToNoContentType] [-AddToAllContentTypes]
 [-AddColumnInternalNameHint] [-AddColumnToDefaultView] [-AddColumnCheckDisplayName] [-AddToDefaultView]
 [<CommonParameters>]
```

### ParamSet3
```
New-KshColumnCalculated [-ClientSideComponentId <String>] [-ClientSideComponentProperties <String>]
 -Columns <Column[]> [-CurrencyLcid <UInt32>] [-CustomFormatter <String>]
 [-DateFormat <ColumnDateTimeFormatType>] [-Description <String>] [-Direction <String>] -Formula <String>
 [-Group <String>] [-Hidden <Boolean>] [-Id <Guid>] [-JSLink <String>] -Name <String> [-NoCrawl <Boolean>]
 [-NumberFormat <Int32>] -OutputType <ColumnType> [-ShowAsPercentage <Boolean>] [-StaticName <String>]
 [-Title <String>] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
The New-KshColumnCalculated adds creates new calculated column to the current site or the specified list.

## EXAMPLES

### Example 1
```powershell
PS C:\> New-KshColumnCalculated -Name 'CalculatedColumn' -Columns (Get-KshColumn -Identity 'TextColumn') -Formula '=TextColumn' -OutputType 'Text'
```

Creates a new column.

## PARAMETERS

### -AddColumnCheckDisplayName
Specifies whether to confirm that no other column has the same display name.

```yaml
Type: SwitchParameter
Parameter Sets: ParamSet1, ParamSet2
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AddColumnInternalNameHint
Specifies whether to add an internal column name hint for the purpose of avoiding possible database locking or column renaming operations.

```yaml
Type: SwitchParameter
Parameter Sets: ParamSet1, ParamSet2
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AddColumnToDefaultView
Specifies whether a new column that is added to the specified list is also be added to the default list view.

```yaml
Type: SwitchParameter
Parameter Sets: ParamSet1, ParamSet2
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AddToAllContentTypes
Specifies whether a new column that is added to the specified list is also be added to all content types in the site collection.

```yaml
Type: SwitchParameter
Parameter Sets: ParamSet1, ParamSet2
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AddToDefaultContentType
Specifies whether a new column that is added to the list is also be added to the default content type in the site collection.

```yaml
Type: SwitchParameter
Parameter Sets: ParamSet1, ParamSet2
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AddToDefaultView
Specifies whether to add a column to the default view.

```yaml
Type: SwitchParameter
Parameter Sets: ParamSet1, ParamSet2
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AddToNoContentType
Specifies whether a new column is not be added to any content type.

```yaml
Type: SwitchParameter
Parameter Sets: ParamSet1, ParamSet2
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ClientSideComponentId
Specifies the ID of the client-side component.

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

### -ClientSideComponentProperties
Specifies the JSON string that the propeties of the client-side component.

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

### -Columns
Specifies the columns

```yaml
Type: Column[]
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CurrencyLcid
Specifies the locale ID.
This parameter is used when OutputType is 'Currency'.
For more information, see reference (https://docs.microsoft.com/ja-jp/openspecs/windows_protocols/ms-lcid/70feba9f-294e-491e-b6eb-56532684c37f).

```yaml
Type: UInt32
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CustomFormatter
Specifies the JSON string of custom format.

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

### -DateFormat
Specifies the datetime display format.
This parameter is used when OutputType is 'DateTime'.

```yaml
Type: ColumnDateTimeFormatType
Parameter Sets: (All)
Aliases:
Accepted values: DateOnly, DateTime

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
Specifies the description.

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

### -Direction
Specifies the direction.

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

### -Formula
Specifies the formula.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Group
Specifies the name for grouping.

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

### -Hidden
Specifies whether to hide the column from users.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
Specifies the ID.

```yaml
Type: Guid
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -JSLink
Specifies the JSLink URL.

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

### -List
Specifies the list.

```yaml
Type: List
Parameter Sets: ParamSet1
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Name
Specifies the name.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NoCrawl
Specifies whether to suppress to search crawling.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NumberFormat
Specifies the number of decimals.
This parameter is used when OutputType is 'Currency' or 'Number'.

```yaml
Type: Int32
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OutputType
Specifies the data type of the return value.

```yaml
Type: ColumnType
Parameter Sets: (All)
Aliases:
Accepted values: Invalid, Integer, Text, Note, DateTime, Counter, Choice, Lookup, Boolean, Number, Currency, URL, Computed, Threading, Guid, MultiChoice, GridChoice, Calculated, File, Attachments, User, Recurrence, CrossProjectLink, ModStat, Error, ContentTypeId, PageSeparator, ThreadIndex, WorkflowStatus, AllDayEvent, WorkflowEventType, Geolocation, OutcomeChoice, Location, Thumbnail, MaxItems

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ShowAsPercentage
Specifies a value whether the column shows as percentage.
This parameter is used when OutputType is 'Number'.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StaticName
Specifies the static name.

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

### -Title
Specifies the title.

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

### -WhatIf
Shows what would happen if the cmdlet runs. The cmdlet is not run.

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

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Karamem0.SharePoint.PowerShell.Models.List

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.ColumnCalculated

## NOTES

## RELATED LINKS
