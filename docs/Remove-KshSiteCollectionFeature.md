---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Remove-KshSiteCollectionFeature

## SYNOPSIS
Removes a site collection feature.

## SYNTAX

```
Remove-KshSiteCollectionFeature [-Identity] <Feature> [-Force <Boolean>] [<CommonParameters>]
```

## DESCRIPTION
The Remove-KshSiteCollectionFeature cmdlet removes a feature from the current site collection.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-KshSiteFeature -Identity (Get-KshSiteCollectionFeature -FeatureId 'b21b090c-c796-4b0f-ac0f-7ef1659c20ae')
```

Removes a feature.

## PARAMETERS

### -Force
Specifies whether to force removing.

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

### -Identity
Specifies the feature.

```yaml
Type: Feature
Parameter Sets: (All)
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Karamem0.SharePoint.PowerShell.Models.Feature

## OUTPUTS

### None

## NOTES

## RELATED LINKS
