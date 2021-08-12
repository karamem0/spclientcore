---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Get-KshTenantCdnOrigin

## SYNOPSIS
Retrieves Office 365 CDN origins.

## SYNTAX

### ParamSet1
```
Get-KshTenantCdnOrigin [-Public] [-NoEnumerate] [<CommonParameters>]
```

### ParamSet2
```
Get-KshTenantCdnOrigin [-Private] [-NoEnumerate] [<CommonParameters>]
```

## DESCRIPTION
The Get-KshTenantCdnOrigin cmdlet retrieves Office 365 CDN origins under the tenant.
This cmdlet can be used only when connected to the SharePoint admin center.

## EXAMPLES

### Example 1
```powershell
PS C:\> Get-KshTenantCdnOrigin -Public
```

Retrieves Office 365 Public CDN origins.

### Example 2
```powershell
PS C:\> Get-KshTenantCdnOrigin -Private
```

Retrieves Office 365 Private CDN origins.

## PARAMETERS

### -NoEnumerate
If specified, suppresses to enumerate objects.

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

### System.String

## NOTES

## RELATED LINKS
