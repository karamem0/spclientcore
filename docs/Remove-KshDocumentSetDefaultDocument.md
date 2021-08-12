---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Remove-KshDocumentSetDefaultDocument

## SYNOPSIS
Removes a document set default document.

## SYNTAX

```
Remove-KshDocumentSetDefaultDocument [-ContentType] <ContentType> [-FileName] <String> [-PushChanges]
 [<CommonParameters>]
```

## DESCRIPTION
The Remove-KshDocumentSetDefaultDocument cmdlet removes a default document from the specified document set template.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-KshDocumentSetDefaultDocument -ContentType (Get-KshContentType -ContentTypeId '0x0120D5200014BC33BECFD5C340922C6D6CECC7830D') -FileName 'README.txt' -PushChanges
```

Removes a document set default document.

## PARAMETERS

### -ContentType
Specifies the content type.

```yaml
Type: ContentType
Parameter Sets: (All)
Aliases:

Required: True
Position: 0
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
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PushChanges
If Specified, propagates changes to all content types that use the content type.

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

### Karamem0.SharePoint.PowerShell.Models.ContentType

## OUTPUTS

### None

## NOTES

## RELATED LINKS
