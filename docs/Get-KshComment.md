---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Get-KshComment

## SYNOPSIS
Retrieves one or more comments.

## SYNTAX

### ParamSet1
```
Get-KshComment [-Identity] <Comment> [<CommonParameters>]
```

### ParamSet2
```
Get-KshComment [-ListItem] <ListItem> [-CommentId] <Int32> [<CommonParameters>]
```

### ParamSet3
```
Get-KshComment [-ListItem] <ListItem> [-NoEnumerate] [<CommonParameters>]
```

## DESCRIPTION
The Get-KshComment cmdlet retrieves comments of the specified list item.

## EXAMPLES

### Example 1
```powershell
PS C:\> Get-KshComment -ListItem (Get-KshListItem -List (Get-KshList -ListTitle 'Site Pages') -ItemId 1) -CommentId 1
```

Retrieves a comment by comment ID.

### Example 2
```powershell
PS C:\> Get-KshComment -ListItem (Get-KshListItem -List (Get-KshList -ListTitle 'Site Pages') -ItemId 1)
```

Retrieves all comments.

## PARAMETERS

### -CommentId
Specifies the comment ID.

```yaml
Type: Int32
Parameter Sets: ParamSet2
Aliases:

Required: True
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Identity
Specifies the comment.

```yaml
Type: Comment
Parameter Sets: ParamSet1
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ListItem
Specifies the list item.

```yaml
Type: ListItem
Parameter Sets: ParamSet2, ParamSet3
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
Parameter Sets: ParamSet3
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

### Karamem0.SharePoint.PowerShell.Models.Comment

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.Comment

## NOTES

## RELATED LINKS
