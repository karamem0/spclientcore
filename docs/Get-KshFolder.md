---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Get-KshFolder

## SYNOPSIS
Retrieves one or more folders.

## SYNTAX

### ParamSet1
```
Get-KshFolder [-Identity] <Folder> [<CommonParameters>]
```

### ParamSet2
```
Get-KshFolder [-List] <List> [<CommonParameters>]
```

### ParamSet3
```
Get-KshFolder [-FolderId] <Guid> [<CommonParameters>]
```

### ParamSet4
```
Get-KshFolder [-FolderUrl] <Uri> [<CommonParameters>]
```

### ParamSet5
```
Get-KshFolder [-Folder] <Folder> [-FolderName] <String> [<CommonParameters>]
```

### ParamSet6
```
Get-KshFolder [-Folder] <Folder> [-NoEnumerate] [<CommonParameters>]
```

### ParamSet7
```
Get-KshFolder [-NoEnumerate] [<CommonParameters>]
```

## DESCRIPTION
The Get-KshFolder cmdlet retrieves folders of the specified folder.

## EXAMPLES

### Example 1
```powershell
PS C:\> Get-KshFolder -FolderId 'ca511d76-828d-4c86-a16c-c3a544eef5da'
```

Retrieves a folder by folder ID.

### Example 2
```powershell
PS C:\> Get-KshFolder -FolderUrl '/sites/japan/hr/Shared%20Documents/Templates'
```

Retrieves a folder by folder URL.

### Example 3
```powershell
PS C:\> Get-KshFolder -Folder (Get-KshFolder -FolderUrl '/sites/japan/hr/Shared%20Documents') -FolderName 'Templates'
```

Retrieves a folder by folder and folder name.

### Example 4
```powershell
PS C:\> Get-KshFolder -Folder (Get-KshFolder -FolderUrl '/sites/japan/hr/Shared%20Documents')
```

Retrieves all folders.

## PARAMETERS

### -Folder
Specifies the parent folder.

```yaml
Type: Folder
Parameter Sets: ParamSet5, ParamSet6
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FolderId
Specifies the folder ID.

```yaml
Type: Guid
Parameter Sets: ParamSet3
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FolderName
Specifies the folder name.

```yaml
Type: String
Parameter Sets: ParamSet5
Aliases:

Required: True
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FolderUrl
Specifies the folder URL.

```yaml
Type: Uri
Parameter Sets: ParamSet4
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Identity
Specifies the folder.

```yaml
Type: Folder
Parameter Sets: ParamSet1
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -List
Specifies the list.

```yaml
Type: List
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
Parameter Sets: ParamSet6, ParamSet7
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

### Karamem0.SharePoint.PowerShell.Models.Folder

### Karamem0.SharePoint.PowerShell.Models.List

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.Folder

## NOTES

## RELATED LINKS
