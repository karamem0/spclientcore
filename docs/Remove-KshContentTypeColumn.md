---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Remove-KshContentTypeColumn

## SYNOPSIS
Removes a content type column.

## SYNTAX

```
Remove-KshContentTypeColumn [-Identity] <ContentTypeColumn> [-PushChanges] [<CommonParameters>]
```

## DESCRIPTION
The Remove-KshContentTypeColumn cmdlet removes a content type column from the specified content type.

## EXAMPLES

### Example 1
```powershell
PS C:> Remove-KshContentTypeColumn -Identity (Get-KshContentTypeColumn -ContentType (Get-KshContentType -List (Get-KshList -ListTitle 'Announcements') -ContentTypeId '0x0100EFB1758564C77D448177233D1199B912000A210B1C5CBC634C849328008B1CC306') -Column (Get-KshColumn -List (Get-KshList -ListTitle 'Announcements') -ColumnTitle 'Remarks'))
```

Removes a content type column from the list content type.

### Example 2
```powershell
PS C:> Remove-KshContentTypeColumn -Identity (Get-KshContentTypeColumn -ContentType (Get-KshContentType -ContentTypeId '0x0100EFB1758564C77D448177233D1199B912') -Column (Get-KshColumn -ColumnTitle 'Remarks')) -PushChanges
```

Removes a content type column from the site content type.

## PARAMETERS

### -Identity
Specifies the content type column.

```yaml
Type: ContentTypeColumn
Parameter Sets: (All)
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByValue)
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

### Karamem0.SharePoint.PowerShell.Models.ContentTypeColumn

## OUTPUTS

### None

## NOTES

## RELATED LINKS
