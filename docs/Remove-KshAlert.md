---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Remove-KshAlert

## SYNOPSIS
Removes an alert.

## SYNTAX

```
Remove-KshAlert [-Identity] <Alert> [<CommonParameters>]
```

## DESCRIPTION
The Remove-KshAlert cmdlet removes an alert from the current site.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-KshAlert -Identity (Get-KshAlert -AlertId '8e22b48d-680a-493a-b3d1-b4607108a94a')
```

Removes an alert.

## PARAMETERS

### -Identity
Specifies the alert.

```yaml
Type: Alert
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

### Karamem0.SharePoint.PowerShell.Models.Alert

## OUTPUTS

### None

## NOTES

## RELATED LINKS
