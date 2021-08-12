---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Get-KshTenantSiteTemplate

## SYNOPSIS
Retrieves one or more tenant site templates.

## SYNTAX

### ParamSet1
```
Get-KshTenantSiteTemplate -CompatibilityLevel <Int32> -Lcid <UInt32> [-NoEnumerate] [<CommonParameters>]
```

### ParamSet2
```
Get-KshTenantSiteTemplate [-NoEnumerate] [<CommonParameters>]
```

## DESCRIPTION
The Get-KshTenantSiteTemplate cmdlet retrieves tenant site templates.
This cmdlet can be used only when connected to the SharePoint admin center.

## EXAMPLES

### Example 1
```powershell
PS C:\> Get-KshTenantSiteTemplate
```

Retrieves all tenant site templates.

### Example 2
```powershell
PS C:\> Get-KshTenantSiteTemplate -CompatibilityLevel 15 -Lcid 1033
```

Retrieves tenant site templates by filter.

## PARAMETERS

### -CompatibilityLevel
Specifies the compatibility level.

```yaml
Type: Int32
Parameter Sets: ParamSet1
Aliases:

Required: True
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
Parameter Sets: ParamSet1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

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

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### None

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.TenantSiteTemplate

## NOTES

## RELATED LINKS
