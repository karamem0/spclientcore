---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Get-KshContentType

## SYNOPSIS
Retrieves one or more content types.

## SYNTAX

### ParamSet1
```
Get-KshContentType [-Identity] <ContentType> [<CommonParameters>]
```

### ParamSet2
```
Get-KshContentType [-List] <List> [-ContentTypeId] <String> [<CommonParameters>]
```

### ParamSet3
```
Get-KshContentType [-List] <List> [-NoEnumerate] [<CommonParameters>]
```

### ParamSet4
```
Get-KshContentType [-ContentTypeId] <String> [<CommonParameters>]
```

### ParamSet5
```
Get-KshContentType [-NoEnumerate] [<CommonParameters>]
```

## DESCRIPTION
The Get-KshContentType cmdlet retrieves content types of the current site or the specified group.

## EXAMPLES

### Example 1
```powershell
PS C:\> Get-KshContentType -ContentTypeId '0x0100EFB1758564C77D448177233D1199B912'
```

Retrieves a content type by content type ID.

### Example 2
```powershell
PS C:\> Get-KshContentType -List (Get-KshList -ListTitle 'Announcements')
```

Retrieves all content types of the list.

### Example 3
```powershell
PS C:\> Get-KshContentType
```

Retrieves all content types of the current site.

## PARAMETERS

### -ContentTypeId
Specifies the content type ID.

```yaml
Type: String
Parameter Sets: ParamSet2, ParamSet4
Aliases:

Required: True
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Identity
Specifies the content type.

```yaml
Type: ContentType
Parameter Sets: ParamSet1
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -List
Specifies the list.

```yaml
Type: List
Parameter Sets: ParamSet2, ParamSet3
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
Parameter Sets: ParamSet3, ParamSet5
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

### Karamem0.SharePoint.PowerShell.Models.ContentType

## NOTES

## RELATED LINKS
