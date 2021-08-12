---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# New-KshTenantTheme

## SYNOPSIS
Creates a new theme.

## SYNTAX

```
New-KshTenantTheme -IsInverted <Boolean> -Name <String> -Palette <Hashtable> [<CommonParameters>]
```

## DESCRIPTION
The New-KshTenantTheme cmdlet adds a new theme to the tenant.
This cmdlet can be used only when connected to the SharePoint admin center.

## EXAMPLES

### Example 1
```powershell
PS C:\> New-KshTenantTheme -Name 'Custom Theme' -Palette @{ "black" = "#000000" }
```

Creates a new site theme.

## PARAMETERS

### -IsInverted
Specifies whether the colors are inverted.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
Specifies the theme name.

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

### -Palette
Specifies the palette.
For more information, see [theme generator](https://developer.microsoft.com/en-us/fabric#/styles/themegenerator).

```yaml
Type: Hashtable
Parameter Sets: (All)
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

### Karamem0.SharePoint.PowerShell.Models.TenantTheme

## NOTES

## RELATED LINKS
