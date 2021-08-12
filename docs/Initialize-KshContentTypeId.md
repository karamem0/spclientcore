---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Initialize-KshContentTypeId

## SYNOPSIS
Creates a content type ID.

## SYNTAX

```
Initialize-KshContentTypeId [-StringValue] <String> [<CommonParameters>]
```

## DESCRIPTION
The Initialize-KshContentTypeId cmdlet creates a content type ID from string value.
This is provided for the [Update-KshFolder](Update-KshFolder.md) and [Update-KshView](Update-KshView.md) cmdlet.

## EXAMPLES

### Example 1
```powershell
PS C:\> Initialize-KshContentTypeId -StringValue '0x0107'
```

Creates a content type ID.

## PARAMETERS

### -StringValue
Specifies the string value.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### None

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.ContentTypeId

## NOTES

## RELATED LINKS
