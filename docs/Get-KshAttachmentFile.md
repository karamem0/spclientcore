---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Get-KshAttachmentFile

## SYNOPSIS
Retrieves one or more attachment files.

## SYNTAX

### ParamSet1
```
Get-KshAttachmentFile [-Identity] <AttachmentFile> [<CommonParameters>]
```

### ParamSet2
```
Get-KshAttachmentFile [-ListItem] <ListItem> [-FileName] <String> [<CommonParameters>]
```

### ParamSet3
```
Get-KshAttachmentFile [-ListItem] <ListItem> [-NoEnumerate] [<CommonParameters>]
```

## DESCRIPTION
The Get-KshAttachmentFile cmdlet retrieves attachment files of the specified list item.

## EXAMPLES

### Example 1
```powershell
PS C:\> Get-KshAttachmentFile -ListItem (Get-KshListItem -List (Get-KshList -ListTitle 'Announcements') -ItemId 1) -FileName 'README.txt'
```

Retrieves an attachment file by file name.

### Example 2
```powershell
PS C:\> Get-KshAttachmentFile -ListItem (Get-KshListItem -List (Get-KshList -ListTitle 'Announcements') -ItemId 1)
```

Retrieves all attachment files.

## PARAMETERS

### -FileName
Specifies the file name.

```yaml
Type: String
Parameter Sets: ParamSet2
Aliases:

Required: True
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Identity
Specifies the attachment file.

```yaml
Type: AttachmentFile
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

### Karamem0.SharePoint.PowerShell.Models.AttachmentFile

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.AttachmentFile

## NOTES

## RELATED LINKS
