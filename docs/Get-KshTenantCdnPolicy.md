---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Get-KshTenantCdnPolicy

## SYNOPSIS
Retrieves Office 365 CDN policies.

## SYNTAX

### ParamSet1
```
Get-KshTenantCdnPolicy [-Public] [-NoEnumerate] [<CommonParameters>]
```

### ParamSet2
```
Get-KshTenantCdnPolicy [-Private] [-NoEnumerate] [<CommonParameters>]
```

## DESCRIPTION
The Get-KshTenantCdnPolicy cmdlet retrieves Office 365 CDN policies applied to the tenant.
This cmdlet can be used only when connected to the SharePoint admin center.

## EXAMPLES

### Example 1
```powershell
PS C:\> Get-KshTenantCdnPolicy -Public
```

Retrieves Office 365 Public CDN policies.

### Example 2
```powershell
PS C:\> Get-KshTenantCdnPolicy -Private
```

Retrieves Office 365 Private CDN policies.

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
