---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Get-KshSiteCollectionFeature

## SYNOPSIS
Retrieves one or more site collection features.

## SYNTAX

### ParamSet1
```
Get-KshSiteCollectionFeature [-Identity] <Feature> [<CommonParameters>]
```

### ParamSet2
```
Get-KshSiteCollectionFeature [-FeatureId] <Guid> [<CommonParameters>]
```

### ParamSet3
```
Get-KshSiteCollectionFeature [-NoEnumerate] [<CommonParameters>]
```

## DESCRIPTION
The Get-KshSiteCollectionFeature cmdlet retrieves features of the site collection.

## EXAMPLES

### Example 1
```powershell
PS C:\> Get-KshSiteCollectionFeature -FeatureId 'b21b090c-c796-4b0f-ac0f-7ef1659c20ae'
```

Retrieves a feature by feature ID.

### Example 2
```powershell
PS C:\> Get-KshSiteCollectionFeature
```

Retrieves all features.

## PARAMETERS

### -FeatureId
Specifies the feature ID.

```yaml
Type: Guid
Parameter Sets: ParamSet2
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Identity
Specifies the feature.

```yaml
Type: Feature
Parameter Sets: ParamSet1
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -NoEnumerate
If specified, suppresses to enumerate objects.

```yaml
Type: SwitchParameter
Parameter Sets: ParamSet3
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

### Karamem0.SharePoint.PowerShell.Models.Feature

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.Feature

## NOTES

## RELATED LINKS
