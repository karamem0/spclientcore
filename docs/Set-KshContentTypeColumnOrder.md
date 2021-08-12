---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Set-KshContentTypeColumnOrder

## SYNOPSIS
Reorders content type columns.

## SYNTAX

```
Set-KshContentTypeColumnOrder [-ContentType] <ContentType> -ContentTypeColumns <String[]> [-PushChanges]
 [<CommonParameters>]
```

## DESCRIPTION
The Set-KshContentTypeColumnOrder cmdlet changes columns order of the content type.

## EXAMPLES

### Example 1
```powershell
PS C:\> Set-KshContentTypeColumnOrder (Get-KshContentType -List (Get-KshList -ListTitle 'Announcements') -ContentTypeId '0x0100EFB1758564C77D448177233D1199B912000A210B1C5CBC634C849328008B1CC306') -ContentTypeColumns @('Column1', 'Column2')
```

Changes columns order of a list content type.

### Example 2
```powershell
PS C:\> Set-KshContentTypeColumnOrder (Get-KshContentType -ContentTypeId '0x0100EFB1758564C77D448177233D1199B912') -ContentTypeColumns @('Column1', 'Column2')
```

Changes columns order of a list content type.

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

### -ContentTypeColumns
Specifies the column names.

```yaml
Type: String[]
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

### Karamem0.SharePoint.PowerShell.Models.ContentType

## OUTPUTS

### None

## NOTES

## RELATED LINKS
