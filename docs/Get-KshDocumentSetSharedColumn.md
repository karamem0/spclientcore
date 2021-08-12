---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Get-KshDocumentSetSharedColumn

## SYNOPSIS
Retrieves document set shared columns.

## SYNTAX

```
Get-KshDocumentSetSharedColumn [-ContentType] <ContentType> [-NoEnumerate] [<CommonParameters>]
```

## DESCRIPTION
The Get-KshDocumentSetSharedColumn cmdlet retrieves shared columns of the document set template.

## EXAMPLES

### Example 1
```powershell
PS C:\> Get-KshDocumentSetSharedColumn -ContentType (Get-KshContentType -ContentTypeId '0x0120D5200014BC33BECFD5C340922C6D6CECC7830D')
```

Retrieves document set shared columns.

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

### -NoEnumerate
If specified, suppresses to enumerate objects.

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

### Karamem0.SharePoint.PowerShell.Models.Column

## NOTES

## RELATED LINKS
