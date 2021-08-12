---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Save-KshAttachmentFile

## SYNOPSIS
Adds a new attachment file.

## SYNTAX

```
Save-KshAttachmentFile [-ListItem] <ListItem> -Content <Stream> -FileName <String> [-PassThru]
 [<CommonParameters>]
```

## DESCRIPTION
The Save-KshAttachmentFile cmdlet adds a new attachment file to the list item.

## EXAMPLES

### Example 1
```powershell
PS C:\> Save-KshAttachmentFile -ListItem (Get-KshListItem -List (Get-KshList -ListTitle 'Announcements') -ItemId 1) -Content ([System.IO.File]::OpenRead("C:\README.txt")) -FileName 'README.txt'
```

Adds a new attachment file.

## PARAMETERS

### -Content
Specifies the contents.

```yaml
Type: Stream
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FileName
Specifies the file name.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ListItem
Specifies the list item.

```yaml
Type: ListItem
Parameter Sets: (All)
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -PassThru
If specified, returns the updated object.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
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

### Karamem0.SharePoint.PowerShell.Models.ListItem

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.AttachmentFile

## NOTES

## RELATED LINKS
