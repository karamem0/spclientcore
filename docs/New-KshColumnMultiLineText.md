---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# New-KshColumnMultiLineText

## SYNOPSIS
Creates a new column of mutiple line text type.

## SYNTAX

### ParamSet1
```
New-KshColumnMultiLineText [-List] <List> [-ClientSideComponentId <String>]
 [-ClientSideComponentProperties <String>] [-CustomFormatter <String>] [-DefaultFormula <String>]
 [-DefaultValue <String>] [-Description <String>] [-Direction <String>] [-Group <String>] [-Hidden <Boolean>]
 [-Id <Guid>] [-JSLink <String>] -Name <String> [-NoCrawl <Boolean>] [-NumberOfLines <Int32>]
 [-ReadOnly <Boolean>] [-Required <Boolean>] [-RestrictedMode <Boolean>] [-RichText <Boolean>]
 [-RichTextMode <RichTextMode>] [-StaticName <String>] [-Title <String>]
 [-UnlimitedLengthInDocumentLibrary <Boolean>] [-AddToDefaultContentType] [-AddToNoContentType]
 [-AddToAllContentTypes] [-AddColumnInternalNameHint] [-AddColumnToDefaultView] [-AddColumnCheckDisplayName]
 [-AddToDefaultView] [<CommonParameters>]
```

### ParamSet2
```
New-KshColumnMultiLineText [-ClientSideComponentId <String>] [-ClientSideComponentProperties <String>]
 [-CustomFormatter <String>] [-DefaultFormula <String>] [-DefaultValue <String>] [-Description <String>]
 [-Direction <String>] [-Group <String>] [-Hidden <Boolean>] [-Id <Guid>] [-JSLink <String>] -Name <String>
 [-NoCrawl <Boolean>] [-NumberOfLines <Int32>] [-ReadOnly <Boolean>] [-Required <Boolean>]
 [-RestrictedMode <Boolean>] [-RichText <Boolean>] [-RichTextMode <RichTextMode>] [-StaticName <String>]
 [-Title <String>] [-UnlimitedLengthInDocumentLibrary <Boolean>] [-AddToDefaultContentType]
 [-AddToNoContentType] [-AddToAllContentTypes] [-AddColumnInternalNameHint] [-AddColumnToDefaultView]
 [-AddColumnCheckDisplayName] [-AddToDefaultView] [<CommonParameters>]
```

### ParamSet3
```
New-KshColumnMultiLineText [-ClientSideComponentId <String>] [-ClientSideComponentProperties <String>]
 [-CustomFormatter <String>] [-DefaultFormula <String>] [-DefaultValue <String>] [-Description <String>]
 [-Direction <String>] [-Group <String>] [-Hidden <Boolean>] [-Id <Guid>] [-JSLink <String>] -Name <String>
 [-NoCrawl <Boolean>] [-NumberOfLines <Int32>] [-ReadOnly <Boolean>] [-Required <Boolean>]
 [-RestrictedMode <Boolean>] [-RichText <Boolean>] [-RichTextMode <RichTextMode>] [-StaticName <String>]
 [-Title <String>] [-UnlimitedLengthInDocumentLibrary <Boolean>] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
The New-KshColumnMultiLineText cmdlet adds new multi-line text column to the current site or the specified list.

## EXAMPLES

### Example 1
```powershell
PS C:\> New-KshColumnMultiLineText -Name 'MultiLineTextColumn' -RichText $true -RichTextMode 'FullHtml'
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

### -DefaultFormula
Specifies the default formula.

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

### -DefaultValue
Specifies the default value.

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

### -NumberOfLines
Specifies the number of lines.

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

### -ReadOnly
Specifies whether changes to the column properties are denied.

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

### -Required
Specifies whether a value is required.

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

### -RestrictedMode
Specifies whether the column is restricted mode.

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

### -RichText
Specifies whether the column supports rich formatting.

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

### -RichTextMode
Specifies whether rich text mode.

```yaml
Type: RichTextMode
Parameter Sets: (All)
Aliases:
Accepted values: Compatible, FullHtml, HtmlAsXml, ThemeHtml

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

### -UnlimitedLengthInDocumentLibrary
Specifies whether to allow values with unlimited text.

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

### Karamem0.SharePoint.PowerShell.Models.ColumnMultiLineText

## NOTES

## RELATED LINKS
