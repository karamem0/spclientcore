---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Copy-KshFolder

## SYNOPSIS
Copies a folder.

## SYNTAX

```
Copy-KshFolder [-Identity] <Folder> [-NewUrl] <Uri> [-KeepBoth] [-ResetAuthorAndCreatedOnCopy]
 [-RetainEditorAndModifiedOnMove] [-ShouldBypassSharedLocks] [<CommonParameters>]
```

## DESCRIPTION
The Copy-KshFolder cmdlet creates a copy from the folder.

## EXAMPLES

### Example 1
```powershell
PS C:\> Copy-KshFolder -Identity (Get-KshFolder -FolderUrl '/sites/japan/hr/Shared%20Documents/Templates') -NewUrl 'https://example.sharepoint.com/Shared%20Documents/Templates'
```

Copies a folder.

## PARAMETERS

### -Identity
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

### -KeepBoth
If specified, both folder should be kept if a folder already exists at the specified destination.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NewUrl
Specifies the URL.

```yaml
Type: Uri
Parameter Sets: (All)
Aliases:

Required: True
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResetAuthorAndCreatedOnCopy
If specified, resets author and created datetime on the copied folder.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RetainEditorAndModifiedOnMove
If specified, retains editor and modified datetime on the moved folder.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ShouldBypassSharedLocks
If specified, the shared locks on the source folder should be by passed.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
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

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.Folder

## NOTES

## RELATED LINKS
