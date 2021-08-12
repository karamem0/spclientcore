---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Get-KshLike

## SYNOPSIS
Retrieves users who have liked.

## SYNTAX

### ParamSet1
```
Get-KshLike [-Comment] <Comment> [-NoEnumerate] [<CommonParameters>]
```

### ParamSet2
```
Get-KshLike [-ListItem] <ListItem> [-NoEnumerate] [<CommonParameters>]
```

## DESCRIPTION
The Get-KshLike cmdlet retrieves users who have liked to the specified comment or list item.

## EXAMPLES

### Example 1
```powershell
PS C:\> Get-KshLike -Comment (Get-KshComment -ListItem (Get-KshListItem -List (Get-KshList -ListTitle 'Site Pages') -ItemId 1)  -CommentId 1)
```

Retrieves liked by users from a comment.

### Example 1
```powershell
PS C:\> Get-KshLike -ListItem (Get-KshListItem -List (Get-KshList -ListTitle 'Site Pages') -ItemId 1)
```

Retrieves liked by users from a list item.

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

### -NoEnumerate
If specified, suppresses to enumerate objects.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
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

### Karamem0.SharePoint.PowerShell.Models.ListItem

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.LikedUser

## NOTES

## RELATED LINKS
