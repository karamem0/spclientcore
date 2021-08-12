---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# New-KshTenantSiteCollection

## SYNOPSIS
Creates a new site collection.

## SYNTAX

### ParamSet1
```
New-KshTenantSiteCollection [-CompatibilityLevel <Int32>] [-Lcid <UInt32>] -Owner <String>
 [-StorageMaxLevel <Int64>] [-StorageWarningLevel <Int64>] [-Template <String>] [-TimeZoneId <Int32>]
 [-Title <String>] -Url <String> [-UserCodeMaxLevel <Double>] [-UserCodeWarningLevel <Double>]
 [<CommonParameters>]
```

### ParamSet2
```
New-KshTenantSiteCollection [-CompatibilityLevel <Int32>] [-Lcid <UInt32>] -Owner <String>
 [-StorageMaxLevel <Int64>] [-StorageWarningLevel <Int64>] [-Template <String>] [-TimeZoneId <Int32>]
 [-Title <String>] -Url <String> [-UserCodeMaxLevel <Double>] [-UserCodeWarningLevel <Double>] [-NoWait]
 [<CommonParameters>]
```

## DESCRIPTION
The New-KshTenantSiteCollection cmdlet adds a new site collection to the tenant.
This cmdlet can be used only when connected to the SharePoint admin center.

## EXAMPLES

### Example 1
```powershell
PS C:\> New-KshTenantSiteCollection -Owner 'admin@example.onmicrosoft.com' -Url 'https://example.sharepoint.com/sites/hub'
```

Creates a new site collection.

## PARAMETERS

### -CompatibilityLevel
Specifies the compatibility level.

```yaml
Type: Int32
Parameter Sets: (All)
Aliases:

Required: False
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
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NoWait
If specified, continue executing script immediately.

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

### -Owner
Specifies the owner.

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

### -StorageMaxLevel
Specifies the maximum quota of the storage.

```yaml
Type: Int64
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StorageWarningLevel
Specifies the warning quota of the storage.

```yaml
Type: Int64
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Template
Specifies the site template ID.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TimeZoneId
Specifies the time zone ID.
For more information, see [reference](https://docs.microsoft.com/en-us/previous-versions/office/sharepoint-server/ms453853(v=office.15)).

```yaml
Type: Int32
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Title
Specifies the title.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Url
Specifies the URL.

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

### -UserCodeMaxLevel
Specifies the maximum quota of the server resource.

```yaml
Type: Double
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserCodeWarningLevel
Specifies the warning quota of the server resource.

```yaml
Type: Double
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

### Karamem0.SharePoint.PowerShell.Models.TenantSiteCollection

## NOTES

## RELATED LINKS
