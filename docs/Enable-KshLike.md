---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Enable-KshLike

## SYNOPSIS
Sets a "Like" to a list item or comment.

## SYNTAX

### ParamSet1
```
Enable-KshLike [-Comment] <Comment> [<CommonParameters>]
```

### ParamSet2
```
Enable-KshLike [-ListItem] <ListItem> [<CommonParameters>]
```

## DESCRIPTION
The Enable-KshLike cmdlet lets you "Like" the specified list item or comment.

## EXAMPLES

### Example 1
```powershell
PS C:\> Enable-KshLike -Comment (Get-KshComment -ListItem (Get-KshListItem -List (Get-KshList -ListTitle 'Site Pages') -ItemId 1) -CommentId 1)
```

Sets a "Like" to a comment.

### Example 1
```powershell
PS C:\> Enable-KshLike -ListItem (Get-KshListItem -List (Get-KshList -ListTitle 'Site Pages') -ItemId 1)
```

Sets a "Like" to a list item.

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
