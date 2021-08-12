---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# New-KshDocumentSetDefaultDocument

## SYNOPSIS
Creates a new document set default document.

## SYNTAX

```
New-KshDocumentSetDefaultDocument -ContentType <ContentType> -DocumentContentType <ContentType>
 -Content <Byte[]> -FileName <String> [-PushChanges] [<CommonParameters>]
```

## DESCRIPTION
The New-KshDocumentSetDefaultDocument adds a new default document to the specified document set template.

## EXAMPLES

### Example 1
```powershell
PS C:\> New-KshDocumentSetDefaultDocument -ContentType (Get-KshContentType -ContentTypeId '0x0120D5200014BC33BECFD5C340922C6D6CECC7830D') -DocumentContentType (Get-KshContentType -ContentTypeId '0x101') -Content ([System.Text.Encoding]::UTF8.GetBytes('Contact: admin@example.onmicrosoft.com')) -FileName 'README.txt' -PushChanges
```

Creates a new document set default document.

## PARAMETERS

### -Content
Specifies the contents.

```yaml
Type: Byte[]
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ContentType
Specifies the content type.

```yaml
Type: ContentType
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DocumentContentType
Specifies the document content type.

```yaml
Type: ContentType
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

### None

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.DefaultDocument

## NOTES

## RELATED LINKS
