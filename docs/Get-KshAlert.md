---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Get-KshAlert

## SYNOPSIS
Retrieves one or more alerts.

## SYNTAX

### ParamSet1
```
Get-KshAlert [-Identity] <Alert> [<CommonParameters>]
```

### ParamSet2
```
Get-KshAlert [-AlertId] <Guid> [<CommonParameters>]
```

### ParamSet3
```
Get-KshAlert [-NoEnumerate] [<CommonParameters>]
```

## DESCRIPTION
The Get-KshAlert cmdlet retrieves alerts of the current site.

## EXAMPLES

### Example 1
```powershell
PS C:\> Get-KshAlert -AlertId '8e22b48d-680a-493a-b3d1-b4607108a94a'
```

Retrieves an alert by alert ID.

### Example 2
```powershell
PS C:\> Get-KshAlert
```

Retrieves all alerts.

## PARAMETERS

### -AlertId
Specifies the alert ID.

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
Specifies the alert.

```yaml
Type: Alert
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

### Karamem0.SharePoint.PowerShell.Models.Alert

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.Alert

## NOTES

## RELATED LINKS
