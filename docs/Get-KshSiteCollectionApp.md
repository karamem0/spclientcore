---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Get-KshSiteCollectionApp

## SYNOPSIS
Retrieves one or more site collection apps.

## SYNTAX

### ParamSet1
```
Get-KshSiteCollectionApp [-Identity] <App> [<CommonParameters>]
```

### ParamSet2
```
Get-KshSiteCollectionApp [-AppId] <Guid> [<CommonParameters>]
```

### ParamSet3
```
Get-KshSiteCollectionApp [-NoEnumerate] [<CommonParameters>]
```

## DESCRIPTION
The Get-KshSiteCollectionApp cmdlet retrieves apps in the current site collection app catalog.

## EXAMPLES

### Example 1
```powershell
PS C:\> Get-KshSiteCollectionApp -AppId 'fdee2390-48bf-409e-956a-20f11a0add59'
```

Retrieves an app by app ID.

### Example 2
```powershell
PS C:\> Get-KshSiteCollectionApp
```

Retrieves all apps.

## PARAMETERS

### -AppId
Specifies the app ID.

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
Specifies the app.

```yaml
Type: App
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

### Karamem0.SharePoint.PowerShell.Models.App

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.App

## NOTES

## RELATED LINKS
