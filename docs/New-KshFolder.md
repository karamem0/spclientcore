---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# New-KshFolder

## SYNOPSIS
Creates a new folder.

## SYNTAX

```
New-KshFolder [-Folder] <Folder> -FolderName <String> [<CommonParameters>]
```

## DESCRIPTION
The New-KshFolder cmdlet adds a new folder to the specified folder.

## EXAMPLES

### Example 1
```powershell
PS C:\> New-KshFolder -Folder (Get-KshFolder -FolderUrl '/sites/japan/hr/Shared%20Documents') -FolderName 'Templates'
```

Creates a new folder.

## PARAMETERS

### -Folder
Specifies the folder.

```yaml
Type: Folder
Parameter Sets: (All)
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -FolderName
Specifies the folder name.

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

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Karamem0.SharePoint.PowerShell.Models.Folder

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.Folder

## NOTES

## RELATED LINKS
