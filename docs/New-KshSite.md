---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# New-KshSite

## SYNOPSIS
Creates a new site.

## SYNTAX

```
New-KshSite [-Description <String>] [-Lcid <UInt32>] [-ServerRelativeUrl <String>] [-Template <String>]
 [-Title <String>] [-UseSamePermissionsAsParentSite <Boolean>] [<CommonParameters>]
```

## DESCRIPTION
The New-KshSite cmdlet adds a new site to the current site.

## EXAMPLES

### Example 1
```powershell
PS C:\> New-KshSite -Description 'Everyday happiness' -LCID 1033 -Title 'Blog' -Url 'blog' -UseSamePermissionsAsParentSite $true -Template 'BLOG#0'
```

Creates a new site.

## PARAMETERS

### -Description
Specifies the description.

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

### -Lcid
Specifies the locale ID.
For more information, see [reference](https://docs.microsoft.com/ja-jp/openspecs/windows_protocols/ms-lcid/70feba9f-294e-491e-b6eb-56532684c37f).

```yaml
Type: UInt32
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ServerRelativeUrl
Specifies the site relative URL.

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

### -Template
Specifies the site template ID.

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

### -Title
Specifies the title.

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

### -UseSamePermissionsAsParentSite
If specified, the site will inherit permissions from its parent site.

```yaml
Type: Boolean
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

### Karamem0.SharePoint.PowerShell.Models.Site

## NOTES

## RELATED LINKS
