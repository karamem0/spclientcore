---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Update-KshTenantTheme

## SYNOPSIS
Updates a theme.

## SYNTAX

```
Update-KshTenantTheme -Identity <TenantTheme> -IsInverted <Boolean> -Palette <Hashtable> [-PassThru]
 [<CommonParameters>]
```

## DESCRIPTION
The Update-KshTenantTheme cmdlet updates properties of the theme.
This cmdlet can be used only when connected to the SharePoint admin center.

## EXAMPLES

### Example 1
```powershell
PS C:\> Update-KshTenantTheme -Identity (Get-KshTenantTheme -ThemeName 'Custom Theme') -Palette @{ "black" = "#0f0f0f" }
```

Updates property values of the theme.

## PARAMETERS

### -Identity
Specifies the theme.

```yaml
Type: TenantTheme
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

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

### -Palette
Specifies the palette.

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

### -PassThru
If specified, returns the updated object.

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

### Karamem0.SharePoint.PowerShell.Models.TenantTheme

## NOTES

## RELATED LINKS
