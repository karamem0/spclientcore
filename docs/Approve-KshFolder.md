---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Approve-KshFolder

## SYNOPSIS
Approves an approval request for the folder.

## SYNTAX

```
Approve-KshFolder [-Identity] <Folder> [-Comment <String>] [-PassThru] [<CommonParameters>]
```

## DESCRIPTION
The Approve-KshFolder cmdlet an approves approval request for the folder. The approval status to be 'Approved'.

## EXAMPLES

### Example 1
```powershell
PS C:\> Approve-KshFolder -Identity (Get-KshFolder -FolderUrl '/sites/japan/hr/Shared%20Documents/Templates')
```

Approves an approval request for the folder.

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

### Karamem0.SharePoint.PowerShell.Models.Folder

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.Folder

## NOTES

## RELATED LINKS
