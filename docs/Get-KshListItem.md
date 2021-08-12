---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Get-KshListItem

## SYNOPSIS
Retrieves one or more list items.

## SYNTAX

### ParamSet1
```
Get-KshListItem [-Identity] <ListItem> [<CommonParameters>]
```

### ParamSet2
```
Get-KshListItem [-Folder] <Folder> [<CommonParameters>]
```

### ParamSet3
```
Get-KshListItem [-File] <File> [<CommonParameters>]
```

### ParamSet4
```
Get-KshListItem [-ItemUrl] <String> [<CommonParameters>]
```

### ParamSet5
```
Get-KshListItem [-List] <List> [-ItemId] <Int32> [<CommonParameters>]
```

### ParamSet6
```
Get-KshListItem [-List] <List> [-All] [-NoEnumerate] [<CommonParameters>]
```

### ParamSet7
```
Get-KshListItem [-List] <List> [-FolderServerRelativeUrl <String>]
 [-ListItemCollectionPosition <ListItemCollectionPosition>] [-ViewXml <String>] [-NoEnumerate]
 [<CommonParameters>]
```

## DESCRIPTION
The Get-KshListItem cmdlet retrieves list items of the specified list.

## EXAMPLES

### Example 1
```powershell
PS C:\> Get-KshListItem -Folder (Get-KshFolder -FolderUrl '/sites/japan/hr/Shared%20Documents/Templates')
```

Retrieves a list item from the folder.

### Example 2
```powershell
PS C:\> Get-KshListItem -File (Get-KshFile -FileUrl '/sites/japan/hr/Shared%20Documents/README.txt')
```

Retrieves a list item from the file.

### Example 3
```powershell
PS C:\> Get-KshListItem -List (Get-KshList -ListTitle 'Announcements') -ItemId 1
```

Retrieves a list item by list item ID.

### Example 4
```powershell
PS C:\> Get-KshListItem -List (Get-KshList -ListTitle 'Announcements') -All
```

Retrieves all list items.

### Example 5
```powershell
PS C:\> Get-KshListItem -List (Get-KshList -ListTitle 'Announcements') -ViewXml '<View><RowLimit>10</RowLimit><View>'
```

Retrieves list items by CAML query.

## PARAMETERS

### -All
if specified, returns all items.
This parameter is effective if there are more than 5000 items.

```yaml
Type: SwitchParameter
Parameter Sets: ParamSet6
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -File
Specifies the file.

```yaml
Type: File
Parameter Sets: ParamSet3
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Folder
Specifies the folder.

```yaml
Type: Folder
Parameter Sets: ParamSet2
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -FolderServerRelativeUrl
Specifies the site relative URL of folder.

```yaml
Type: String
Parameter Sets: ParamSet7
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Identity
Specifies the list item.

```yaml
Type: ListItem
Parameter Sets: ParamSet1
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ItemId
Specifies the list item ID.

```yaml
Type: Int32
Parameter Sets: ParamSet5
Aliases:

Required: True
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ItemUrl
Specifies the list item URL.

```yaml
Type: String
Parameter Sets: ParamSet4
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: False
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

### -ListItemCollectionPosition
Specifies the starting position.

```yaml
Type: ListItemCollectionPosition
Parameter Sets: ParamSet7
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NoEnumerate
If specified, suppresses to enumerate objects.

```yaml
Type: SwitchParameter
Parameter Sets: ParamSet6, ParamSet7
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ViewXml
Specifies the CAML query XML representation.
For more information, see [reference](https://docs.microsoft.com/en-us/sharepoint/dev/schema/query-schema).

```yaml
Type: String
Parameter Sets: ParamSet7
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

### Karamem0.SharePoint.PowerShell.Models.ListItem

### Karamem0.SharePoint.PowerShell.Models.Folder

### Karamem0.SharePoint.PowerShell.Models.File

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.ListItem

## NOTES

## RELATED LINKS
