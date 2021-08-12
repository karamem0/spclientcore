---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Add-KshTenantCdnOrigin

## SYNOPSIS
Adds Office 365 CDN origin.

## SYNTAX

### ParamSet1
```
Add-KshTenantCdnOrigin [-Public] -Origin <String> [<CommonParameters>]
```

### ParamSet2
```
Add-KshTenantCdnOrigin [-Private] -Origin <String> [<CommonParameters>]
```

## DESCRIPTION
The Add-KshTenantCdnOrigin cmdlet adds Office 365 CDN origin to the tenant.

## EXAMPLES

### Example 1
```powershell
PS C:\> The Add-KshTenantCdnOrigin -Public -Origin 'PUBLICCDN'
```

Adds Office 365 Public CDN origin.

### Example 2
```powershell
PS C:\> The Add-KshTenantCdnOrigin -Private -Origin 'PUBLICCDN'
```

Adds Office 365 Private CDN origin.

## PARAMETERS

### -Origin
Specifies the origin.

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
