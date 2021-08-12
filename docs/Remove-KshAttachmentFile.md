---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Remove-KshAttachmentFile

## SYNOPSIS
Removes an attachment file.

## SYNTAX

### ParamSet1
```
Remove-KshAttachmentFile [-Identity] <AttachmentFile> [<CommonParameters>]
```

### ParamSet2
```
Remove-KshAttachmentFile [-Identity] <AttachmentFile> [-RecycleBin] [<CommonParameters>]
```

## DESCRIPTION
The Remove-KshAttachmentFile cmdlet removes an attachment file from the list item.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-KshAttachmentFile -Identity (Get-KshAttachmentFile -ListItem (Get-KshListItem -List (Get-KshList -ListTitle 'Announcements') -ItemId 1) -FileName 'README.txt')
```

Removes an attachment file.

### Example 2
```powershell
PS C:\> Remove-KshAttachmentFile -Identity (Get-KshAttachmentFile -ListItem (Get-KshListItem -List (Get-KshList -ListTitle 'Announcements') -ItemId 1) -FileName 'README.txt') -RecycleBin
```

Moves an attachment file to the recycle bin.

## PARAMETERS

### -Identity
Specifies the attachment file.

```yaml
Type: AttachmentFile
Parameter Sets: (All)
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -RecycleBin
If specified, moves the item to the recycle bin.

```yaml
Type: SwitchParameter
Parameter Sets: ParamSet2
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

### Karamem0.SharePoint.PowerShell.Models.AttachmentFile

## OUTPUTS

### None

## NOTES

## RELATED LINKS
