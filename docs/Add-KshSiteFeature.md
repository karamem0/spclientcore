---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Add-KshSiteFeature

## SYNOPSIS
Adds a site feature.

## SYNTAX

```
Add-KshSiteFeature -FeatureId <Guid> [-Force <Boolean>] [-Scope <FeatureDefinitionScope>] [<CommonParameters>]
```

## DESCRIPTION
The Add-KshSiteFeature cmdlet adds a feature to the site.

## EXAMPLES

### Example 1
```powershell
PS C:\> Add-KshSiteFeature -FeatureId '99fe402e-89a0-45aa-9163-85342e865dc8'
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
