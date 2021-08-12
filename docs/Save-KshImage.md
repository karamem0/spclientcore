---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Save-KshImage

## SYNOPSIS
Adds a new image.

## SYNTAX

### ParamSet1
```
Save-KshImage -List <List> -Content <Stream> -FileName <String> [<CommonParameters>]
```

### ParamSet2
```
Save-KshImage -ListItem <ListItem> -Content <Stream> -FileName <String> [<CommonParameters>]
```

## DESCRIPTION
The Save-KshImage cmdlet adds a new image to the Site Assets library for create or update the image column of the list item.

## EXAMPLES

### Example 1
```powershell
PS C:\> Save-KshImage -List (Get-KshList -ListTitle 'Announcements') -Content ([System.IO.File]::OpenRead('C:\Profile.png')) -FileName 'Profile.png'
```

Adds a new image for create the list item.

### Example 2
```powershell
PS C:\> Save-KshImage -ListItem (Get-KshListItem -List (Get-KshList -ListTitle 'Announcements') -ItemId 1) -Content ([System.IO.File]::OpenRead('C:\Profile.png')) -FileName 'Profile.png'
```

Adds a new image for update the list item.

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

### -List
Specifies the list.

```yaml
Type: List
Parameter Sets: ParamSet1
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

### None

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.ImageItem

## NOTES

## RELATED LINKS
