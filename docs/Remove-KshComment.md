---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Remove-KshComment

## SYNOPSIS
Removes a comment.

## SYNTAX

```
Remove-KshComment [-Identity] <Comment> [<CommonParameters>]
```

## DESCRIPTION
The Remove-KshComment cmdlet removes a comment from the list item.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-KshComment -Identity (Get-KshComment -ListItem (Get-KshListItem -List (Get-KshList -ListTitle 'Site Pages') -ItemId 1) -CommentId 1)
```

Removes a comment.

## PARAMETERS

### -Identity
Specifies the comment.

```yaml
Type: Comment
Parameter Sets: (All)
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

### Karamem0.SharePoint.PowerShell.Models.Comment

## OUTPUTS

### None

## NOTES

## RELATED LINKS
