---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Disable-KshLike

## SYNOPSIS
Sets a "Unlike" to a list item or comment.

## SYNTAX

### ParamSet1
```
Disable-KshLike [-Comment] <Comment> [<CommonParameters>]
```

### ParamSet2
```
Disable-KshLike [-ListItem] <ListItem> [<CommonParameters>]
```

## DESCRIPTION
The Disable-KshLike cmdlet lets you "Unlike" the specified list item or comment.

## EXAMPLES

### Example 1
```powershell
PS C:\> Disable-KshLike -Comment (Get-KshComment -ListItem (Get-KshListItem -List (Get-KshList -ListTitle 'Site Pages') -ItemId 1) -CommentId 1)
```

Sets a "Unlike" to a comment.

### Example 1
```powershell
PS C:\> Disable-KshLike -ListItem (Get-KshListItem -List (Get-KshList -ListTitle 'Site Pages') -ItemId 1)
```

Sets a "Unlike" to a list item.

## PARAMETERS

### -Comment
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
Parameter Sets: ParamSet2
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

### None

## OUTPUTS

### System.Void

## NOTES

## RELATED LINKS
