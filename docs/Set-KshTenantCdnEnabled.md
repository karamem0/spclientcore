---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Set-KshTenantCdnEnabled

## SYNOPSIS
Changes whether Office 365 CDN is enabled.

## SYNTAX

### ParamSet1
```
Set-KshTenantCdnEnabled [-Public] -Enabled <Boolean> [-NoDefaultOrigins] [<CommonParameters>]
```

### ParamSet2
```
Set-KshTenantCdnEnabled [-Private] -Enabled <Boolean> [-NoDefaultOrigins] [<CommonParameters>]
```

## DESCRIPTION
The Set-KshTenantCdnEnabled cmdlet changes whether Office 365 CDN is enabled in the tenant.
This cmdlet can be used only when connected to the SharePoint admin center.

## EXAMPLES

### Example 1
```powershell
PS C:\> Set-KshTenantCdnEnabled -Public -Enabled $true
```

Enables Office 365 Public CDN.

### Example 2
```powershell
PS C:\> Set-KshTenantCdnEnabled -Private -Enabled $true
```

Enables the Office 365 Private CDN.

## PARAMETERS

### -Enabled
Specifies whether Office 365 CDN is enabled.

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

### -NoDefaultOrigins
If specified, prevent to create the default origins.

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

### -Private
If specified, targets Office 365 Private CDN.

```yaml
Type: SwitchParameter
Parameter Sets: ParamSet2
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Public
If specified, targets Office 365 Public CDN.

```yaml
Type: SwitchParameter
Parameter Sets: ParamSet1
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

### None

## NOTES

## RELATED LINKS
