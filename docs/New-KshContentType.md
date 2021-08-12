---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# New-KshContentType

## SYNOPSIS
Creates a new content type.

## SYNTAX

### ParamSet1
```
New-KshContentType -List <List> -ContentType <ContentType> [<CommonParameters>]
```

### ParamSet2
```
New-KshContentType -List <List> [-ContentType <ContentType>] [-Description <String>] [-Group <String>]
 -Name <String> [<CommonParameters>]
```

### ParamSet3
```
New-KshContentType [-ContentType <ContentType>] [-Description <String>] [-Group <String>] -Name <String>
 [<CommonParameters>]
```

## DESCRIPTION
The New-KshContentType cmdlet adds a new content type to the current site or the specified list.

## EXAMPLES

### Example 1
```powershell
PS C:\> New-KshContentType -List 'Announcements' -ContentType (Get-KshContentType -Identity '0x0100EFB1758564C77D448177233D1199B912')
```

Creates a new list content from the site content type.

### Example 2
```powershell
PS C:\> New-KshContentType -List 'Announcements' -Name 'Approval Requests'
```

Creates a new content type to the list.

### Example 3
```powershell
PS C:\> New-KshContentType -Name 'Approval Requests'
```

Creates a new content type to the current site.

## PARAMETERS

### -ContentType
Specifies the parent content type.

```yaml
Type: ContentType
Parameter Sets: ParamSet1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

```yaml
Type: ContentType
Parameter Sets: ParamSet2, ParamSet3
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
Specifies the description.

```yaml
Type: String
Parameter Sets: ParamSet2, ParamSet3
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Group
Specifies the name for grouping.

```yaml
Type: String
Parameter Sets: ParamSet2, ParamSet3
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -List
Specifies the list.

```yaml
Type: List
Parameter Sets: ParamSet1, ParamSet2
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
Specifies the name.

```yaml
Type: String
Parameter Sets: ParamSet2, ParamSet3
Aliases:

Required: True
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

### Karamem0.SharePoint.PowerShell.Models.ContentType

## NOTES

## RELATED LINKS
