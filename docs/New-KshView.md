---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# New-KshView

## SYNOPSIS
Creates a new view.

## SYNTAX

```
New-KshView [-List] <List> [-BaseViewId <Int32>] [-Paged <Boolean>] [-PersonalView <Boolean>]
 [-RowLimit <Int32>] [-SetAsDefaultView <Boolean>] -Title <String> [-ViewColumns <String[]>]
 [-ViewQuery <String>] [-ViewType <ViewType>] [<CommonParameters>]
```

## DESCRIPTION
The New-KshUser cmdlet adds a new view to the specified list.

## EXAMPLES

### Example 1
```powershell
PS C:\> New-KshView -List (Get-KshList -ListTitle 'Announcements') -Title 'My Items' -ViewColumns @('Id', 'Title')
```

Creates a new view to the list.

## PARAMETERS

### -BaseViewId
Specifies the base view ID.

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

### -Paged
Specifies whether the view is a paged view.

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

### -PersonalView
Specifies whether the view is a personal view.

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

### -RowLimit
Specifies the number of items.

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

### -SetAsDefaultView
Specifies whether to set as default view.

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

### -Title
Specifies the title.

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

### -ViewColumns
Specifies the view column names.

```yaml
Type: String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ViewQuery
Specifies the view query XML.

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

### -ViewType
Specifies the view type.

```yaml
Type: ViewType
Parameter Sets: (All)
Aliases:
Accepted values: None, Html, Grid, Recurrence, Chart, Calendar, Gantt

Required: False
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

### Karamem0.SharePoint.PowerShell.Models.View

## NOTES

## RELATED LINKS
