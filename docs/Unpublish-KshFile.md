---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Unpublish-KshFile

## SYNOPSIS
Resets an approval request or result for the file.

## SYNTAX

```
Unpublish-KshFile [-Identity] <File> [-Comment <String>] [-PassThru] [<CommonParameters>]
```

## DESCRIPTION
The Unpublish-KshFile cmdlet resets an approval request or result for the file. The approval status to be 'Draft'.

## EXAMPLES

### Example 1
```powershell
PS C:\> Unpublish-KshFile -Identity (Get-KshFile -FolderUrl '/sites/japan/hr/Shared%20Documents/README.txt')
```

Resets an approval request or result for the file.

## PARAMETERS

### -Comment
Specifies the comment.

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

### -PassThru
If specified, returns the updated object.

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

### Karamem0.SharePoint.PowerShell.Models.File

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.File

## NOTES

## RELATED LINKS
