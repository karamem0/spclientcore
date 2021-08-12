---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Get-KshDrive

## SYNOPSIS
Retrieves one or more drives.

## SYNTAX

### ParamSet1
```
Get-KshDrive [-Identity] <Drive> [<CommonParameters>]
```

### ParamSet2
```
Get-KshDrive [-DriveId] <String> [<CommonParameters>]
```

### ParamSet3
```
Get-KshDrive [-NoEnumerate] [<CommonParameters>]
```

## DESCRIPTION
The Get-KshDrive cmdlet retrieves drives of the current site.
The drive represents a logical container of files, like a document library or a user's OneDrive.

## EXAMPLES

### Example 1
```powershell
PS C:\> Get-KshDrive -DriveId 'b!vpvKq3kXeEaww1z6NPnGbKhvcv2QlkNIoGE112ESrYtKvAhAPsWLSLhCqJy8wVDu'
```

Retrieves a drive by drive ID.

### Example 2
```powershell
PS C:\> Get-KshDrive
```

Retrieves all drives.

## PARAMETERS

### -DriveId
Specifies the drive ID.

```yaml
Type: String
Parameter Sets: ParamSet2
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Identity
Specifies the drive.

```yaml
Type: Drive
Parameter Sets: ParamSet1
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

### Karamem0.SharePoint.PowerShell.Models.Drive

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.Drive

## NOTES

## RELATED LINKS
