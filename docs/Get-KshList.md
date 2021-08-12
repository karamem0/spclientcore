---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Get-KshList

## SYNOPSIS
Retrieves one or more lists.

## SYNTAX

### ParamSet1
```
Get-KshList [-Identity] <List> [<CommonParameters>]
```

### ParamSet2
```
Get-KshList [-ListItem] <ListItem> [<CommonParameters>]
```

### ParamSet3
```
Get-KshList [-View] <View> [<CommonParameters>]
```

### ParamSet4
```
Get-KshList [-ListId] <Guid> [<CommonParameters>]
```

### ParamSet5
```
Get-KshList [-ListUrl] <Uri> [<CommonParameters>]
```

### ParamSet6
```
Get-KshList [-ListTitle] <String> [<CommonParameters>]
```

### ParamSet7
```
Get-KshList [-LibraryType] <LibraryType> [<CommonParameters>]
```

### ParamSet8
```
Get-KshList [-NoEnumerate] [<CommonParameters>]
```

## DESCRIPTION
The Get-KshList cmdlet retrieves lists of the current site.

## EXAMPLES

### Example 1
```powershell
PS C:\> Get-KshList -ListItem (Get-KshListItem -List (Get-KshList -ListTitle 'Announcements') -ItemId 1)
```

Retrieves a parent list of the list item.

### Example 2
```powershell
PS C:\> Get-KshList -View (Get-KshView -List (Get-KshList -ListTitle 'Announcements') -ViewId 'bae9f925-48d3-47f5-bb07-92927a82df7d')
```

Retrieves a parent list of the view.

### Example 3
```powershell
PS C:\> Get-KshList -ListId 'a01f8e07-290f-4644-9db8-85bb00b85e74'
```

Retrieves a list by list ID.

### Example 4
```powershell
PS C:\> Get-KshList -ListUrl '/sites/japan/hr/Announcements'
```

Retrieves a list by list URL.

### Example 5
```powershell
PS C:\> Get-KshList -ListTitle 'Announcements'
```

Retrieves a list by list title.

### Example 6
```powershell
PS C:\> Get-KshList -LibraryType 'SitePages'
```

Retrieves a list by library type.

### Example 7
```powershell
PS C:\> Get-KshList
```

Retrieves all lists.

## PARAMETERS

### -Identity
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

### -LibraryType
Specifies the library type.

```yaml
Type: LibraryType
Parameter Sets: ParamSet7
Aliases:
Accepted values: SitePages, ClientRenderedSitePages, SiteAssets

Required: True
Position: 0
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ListId
Specifies the list ID.

```yaml
Type: Guid
Parameter Sets: ParamSet4
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ListItem
Specifies the list item.

```yaml
Type: ListItem
Parameter Sets: ParamSet2
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ListTitle
Specifies the list title.

```yaml
Type: String
Parameter Sets: ParamSet6
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ListUrl
Specifies the list URL.

```yaml
Type: Uri
Parameter Sets: ParamSet5
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
Parameter Sets: ParamSet8
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -View
Specifies the view.

```yaml
Type: View
Parameter Sets: ParamSet3
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

### Karamem0.SharePoint.PowerShell.Models.List

### Karamem0.SharePoint.PowerShell.Models.ListItem

### Karamem0.SharePoint.PowerShell.Models.View

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.List

## NOTES

## RELATED LINKS
