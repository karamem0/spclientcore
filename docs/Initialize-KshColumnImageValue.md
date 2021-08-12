---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Initialize-KshColumnImageValue

## SYNOPSIS
Creates a image column value.

## SYNTAX

### ParamSet1
```
Initialize-KshColumnImageValue -ImageItem <ImageItem> [-ColumnName <String>] [<CommonParameters>]
```

### ParamSet2
```
Initialize-KshColumnImageValue [-ColumnName <String>] [-FileName <String>] [-ServerUrl <String>]
 [-ServerRelativeUrl <String>] [-Id <Guid>] [<CommonParameters>]
```

## DESCRIPTION
The Initialize-KshColumnImageValue cmdlet creates a new image column value from image information.
This is provided for the [New-KshListItem](New-KshListItem.md) cmdlet and [Update-KshListItem](Update-KshListItem.md) cmdlet.

## EXAMPLES

### Example 1
```powershell
PS C:\> Initialize-KshColumnImageValue -ImageItem (Save-KshImage -List (Get-KshList -ListTitle 'Announcements') -Content ([System.IO.File]::OpenRead('C:\Profile.png')) -FileName 'Profile.png') -ColumnName 'ImageColumn'
```

Creates a new image column value from saved image.

### Example 1
```powershell
PS C:\> Initialize-KshColumnImageValue -ServerRelativeUrl '/sites/japan/hr/SiteAssets/Profile.png'
```

Creates a new image column value from server relative URL.

## PARAMETERS

### -ColumnName
Specifies the column name.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FileName
Specifies the file name.

```yaml
Type: String
Parameter Sets: ParamSet2
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
Specifies the ID.

```yaml
Type: Guid
Parameter Sets: ParamSet2
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ImageItem
Specifies the image item.

```yaml
Type: ImageItem
Parameter Sets: ParamSet1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ServerRelativeUrl
Specifies the server relative URL.

```yaml
Type: String
Parameter Sets: ParamSet2
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ServerUrl
Specifies the root URL.

```yaml
Type: String
Parameter Sets: ParamSet2
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

### None

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.ColumnImageValue

## NOTES

## RELATED LINKS
