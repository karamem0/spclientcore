---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Get-KshView

## SYNOPSIS
Retrieves one or more views.

## SYNTAX

### ParamSet1
```
Get-KshView [-Identity] <View> [<CommonParameters>]
```

### ParamSet2
```
Get-KshView [-List] <List> [-ViewId] <Guid> [<CommonParameters>]
```

### ParamSet3
```
Get-KshView [-List] <List> [-ViewTitle] <String> [<CommonParameters>]
```

### ParamSet4
```
Get-KshView [-List] <List> [-NoEnumerate] [<CommonParameters>]
```

## DESCRIPTION
The Get-KshView cmdlet retrieves views of the specified list.

## EXAMPLES

### Example 1
```powershell
PS C:\> Get-KshView -List (Get-KshList -ListTitle 'Announcements') -ViewId 'bae9f925-48d3-47f5-bb07-92927a82df7d'
```

Retrieves a view by view ID.

### Example 2
```powershell
PS C:\> Get-KshView -List (Get-KshList -ListTitle 'Announcements') -ViewTitle 'All Items'
```

Retrieves a view by view title.

### Example 3
```powershell
PS C:\> Get-KshView -List (Get-KshList -ListTitle 'Announcements')
```

Retrieves all views of the list.

## PARAMETERS

### -Identity
Specifies the view.

```yaml
Type: View
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
Parameter Sets: ParamSet2, ParamSet3, ParamSet4
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
Parameter Sets: ParamSet4
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ViewId
Specifies the view ID.

```yaml
Type: Guid
Parameter Sets: ParamSet2
Aliases:

Required: True
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ViewTitle
Specifies the view title.

```yaml
Type: String
Parameter Sets: ParamSet3
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

### Karamem0.SharePoint.PowerShell.Models.View

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.View

## NOTES

## RELATED LINKS
