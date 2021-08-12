---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Copy-KshFile

## SYNOPSIS
Copies a file.

## SYNTAX

### ParamSet1
```
Copy-KshFile [-Identity] <File> [-NewUrl] <Uri> [-Overwrite] [-KeepBoth] [-ResetAuthorAndCreatedOnCopy]
 [-RetainEditorAndModifiedOnMove] [-ShouldBypassSharedLocks] [<CommonParameters>]
```

### ParamSet2
```
Copy-KshFile [-Identity] <File> [-NewUrl] <Uri> [-Overwrite] [-Legacy] [-PassThru] [<CommonParameters>]
```

## DESCRIPTION
The Copy-KshFile cmdlet creates a copy from the file.

## EXAMPLES

### Example 1
```powershell
PS C:\> Copy-KshFile -Identity (Get-KshFile -FolderUrl '/sites/japan/hr/Shared%20Documents/README.txt') -NewUrl 'https://example.sharepoint.com/Shared%20Documents/README.txt'
```

Copies a file.

### Example 2
```powershell
PS C:\> Copy-KshFile -Identity (Get-KshFile -FolderUrl '/sites/japan/hr/Shared%20Documents/README.txt') -NewUrl '/sites/japan/hr/Shared%20Documents/README_old.txt' -Legacy
```

Copies a file. (Use legacy API)

## PARAMETERS

### -Identity
Specifies the file.

```yaml
Type: File
Parameter Sets: (All)
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -KeepBoth
If specified, both file should be kept if a file already exists at the specified destination.

```yaml
Type: SwitchParameter
Parameter Sets: ParamSet1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Legacy
If specified, uses legacy API.

```yaml
Type: SwitchParameter
Parameter Sets: ParamSet2
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

### -Overwrite
If specified, overwrites the existing file.

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

### -PassThru
If specified, returns the updated object.

```yaml
Type: SwitchParameter
Parameter Sets: ParamSet2
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResetAuthorAndCreatedOnCopy
If specified, resets author and created datetime on the copied file.

```yaml
Type: SwitchParameter
Parameter Sets: ParamSet1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RetainEditorAndModifiedOnMove
If specified, retains editor and modified datetime on the moved file.

```yaml
Type: SwitchParameter
Parameter Sets: ParamSet1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ShouldBypassSharedLocks
If specified, the shared locks on the source file should be by passed.

```yaml
Type: SwitchParameter
Parameter Sets: ParamSet1
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

### Karamem0.SharePoint.PowerShell.Models.File

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.File

## NOTES

## RELATED LINKS
