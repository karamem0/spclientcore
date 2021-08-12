---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Open-KshAttachmentFile

## SYNOPSIS
Opens an attachment file.

## SYNTAX

```
Open-KshAttachmentFile [-Identity] <AttachmentFile> [<CommonParameters>]
```

## DESCRIPTION
The Open-KshAttachmentFile cmdlet retrieves contents of the attachment file.

## EXAMPLES

### Example 1
```powershell
PS C:\> Open-KshAttachmentFile -Identity (Get-KshAttachmentFile -ListItem (Get-KshListItem -List (Get-KshList -ListTitle 'Announcements') -ItemId 1) -FileName 'README.txt')
```

Retrieves contents of the attachment file.

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

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Karamem0.SharePoint.PowerShell.Models.AttachmentFile

## OUTPUTS

### System.IO.Stream

## NOTES

## RELATED LINKS
