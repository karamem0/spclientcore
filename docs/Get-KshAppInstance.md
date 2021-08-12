---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Get-KshAppInstance

## SYNOPSIS
Retrieves one or more app instances.

## SYNTAX

### ParamSet1
```
Get-KshAppInstance [-Identity] <AppInstance> [<CommonParameters>]
```

### ParamSet2
```
Get-KshAppInstance [-AppInstanceId] <Guid> [<CommonParameters>]
```

### ParamSet3
```
Get-KshAppInstance [-AppProductId] <Guid> [-NoEnumerate] [<CommonParameters>]
```

### ParamSet4
```
Get-KshAppInstance [-NoEnumerate] [<CommonParameters>]
```

## DESCRIPTION
The Get-KshAppInstance cmdlet retrieves app instances of the current site.

## EXAMPLES

### Example 1
```powershell
PS C:\> Get-KshAppInstance -AppInstanceId 'db909b7c-59eb-4b8c-ad1e-7f712c82fc33'
```

Retrieves an app instance by app instance ID.

### Example 1
```powershell
PS C:\> Get-KshAppInstance -AppProductId '38e2d58b-cc4e-48f5-93e5-7f1892357638'
```

Retrieves app instances by app product ID.

### Example 3
```powershell
PS C:\> Get-KshAppInstance
```

Retrieves all app instances.

## PARAMETERS

### -AppInstanceId
Specifies the app instance ID.

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

### -AppProductId
Specifies the app product ID.

```yaml
Type: Guid
Parameter Sets: ParamSet3
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Identity
Specifies the app instance.

```yaml
Type: AppInstance
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
Parameter Sets: ParamSet3, ParamSet4
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

### Karamem0.SharePoint.PowerShell.Models.AppInstance

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.AppInstance

## NOTES

## RELATED LINKS
