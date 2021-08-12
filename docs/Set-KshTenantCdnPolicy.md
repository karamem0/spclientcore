---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Set-KshTenantCdnPolicy

## SYNOPSIS
Changes Office 365 CDN policy.

## SYNTAX

### ParamSet1
```
Set-KshTenantCdnPolicy [-Public] -Type <TenantCdnPolicyType> -Value <String> [<CommonParameters>]
```

### ParamSet2
```
Set-KshTenantCdnPolicy [-Private] -Type <TenantCdnPolicyType> -Value <String> [<CommonParameters>]
```

## DESCRIPTION
The Set-KshTenantCdnPolicy cmdlet changes the value of Office 365 CDN policy.
This cmdlet can be used only when connected to the SharePoint admin center.

## EXAMPLES

### Example 1
```powershell
PS C:\> Set-KshTenantCdnPolicy -Public -Type 'IncludeFileExtensions' -Value 'CSS,EOT,GIF,ICO,JPEG,JPG,JS,MAP,PNG,SVG,TTF,WOFF'
```

Changes Office 365 Public CDN policy.

### Example 2
```powershell
PS C:\> Set-KshTenantCdnPolicy -Private -Type 'IncludeFileExtensions' -Value 'GIF,ICO,JPEG,JPG,JS,PNG'
```

Changes Office 365 Private CDN policy.

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

### -Type
Specifies the policy type.

```yaml
Type: TenantCdnPolicyType
Parameter Sets: (All)
Aliases:
Accepted values: IncludeFileExtensions, ExcludeRestrictedSiteClassifications, ExcludeIfNoScriptDisabled

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Value
Specifies the value.

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

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### None

## OUTPUTS

### None

## NOTES

## RELATED LINKS
