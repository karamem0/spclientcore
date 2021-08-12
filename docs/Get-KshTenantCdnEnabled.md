---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Get-KshTenantCdnEnabled

## SYNOPSIS
Retrieves whether Office 365 CDN is enabled.

## SYNTAX

### ParamSet1
```
Get-KshTenantCdnEnabled [-Public] [<CommonParameters>]
```

### ParamSet2
```
Get-KshTenantCdnEnabled [-Private] [<CommonParameters>]
```

## DESCRIPTION
The Get-KshTenantCdnEnabled cmdlet retrieves whether Office 365 CDN is enabled in the tenant.
This cmdlet can be used only when connected to the SharePoint admin center.

## EXAMPLES

### Example 1
```powershell
PS C:\> Get-KshTenantCdnEnabled -Public
```

Retrieves whether Office 365 Public CDN is enabled.

### Example 2
```powershell
PS C:\> Get-KshTenantCdnEnabled -Private
```

Retrieves whether Office 365 Private CDN is enabled.

## PARAMETERS

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

### System.Boolean

## NOTES

## RELATED LINKS
