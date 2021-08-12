---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Remove-KshTenantCdnOrigin

## SYNOPSIS
Removes Office 365 CDN origin.

## SYNTAX

### ParamSet1
```
Remove-KshTenantCdnOrigin [-Public] -Origin <String> [<CommonParameters>]
```

### ParamSet2
```
Remove-KshTenantCdnOrigin [-Private] -Origin <String> [<CommonParameters>]
```

## DESCRIPTION
The Remove-KshTenantCdnOrigin cmdlet removes Office 365 CDN origin from the tenant.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-KshTenantCdnOrigin -Public -Origin 'PUBLICCDN'
```

Rmeoves Office 365 Public CDN origin.

### Example 2
```powershell
PS C:\> Remove-KshTenantCdnOrigin -Public -Origin 'PRIVATECDN'
```

Rmeoves Office 365 Private CDN origin.

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
