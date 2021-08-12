---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Add-KshSiteCollectionFeature

## SYNOPSIS
Adds a site collection feature.

## SYNTAX

```
Add-KshSiteCollectionFeature -FeatureId <Guid> [-Force <Boolean>] [-Scope <FeatureDefinitionScope>]
 [<CommonParameters>]
```

## DESCRIPTION
The Add-KshSiteCollectionFeature cmdlet adds a feature to the site collection.

## EXAMPLES

### Example 1
```powershell
PS C:\> Add-KshSiteCollectionFeature -FeatureId 'b21b090c-c796-4b0f-ac0f-7ef1659c20ae'
```

Adds a feature.

## PARAMETERS

### -FeatureId
Specifies the feature ID.

```yaml
Type: Guid
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Force
Specifies whether to force adding.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Scope
Specifies the scope.

```yaml
Type: FeatureDefinitionScope
Parameter Sets: (All)
Aliases:
Accepted values: None, Farm, SiteCollection, Site

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

### None

## NOTES

## RELATED LINKS
