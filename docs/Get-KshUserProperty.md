---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Get-KshUserProperty

## SYNOPSIS
Retrieves an user properties.

## SYNTAX

### ParamSet1
```
Get-KshUserProperty [-Identity] <UserProperty> [<CommonParameters>]
```

### ParamSet2
```
Get-KshUserProperty [-UserLoginName] <String> [<CommonParameters>]
```

## DESCRIPTION
The Get-KshUserProperty cmdlet retrieves properties of the specified user.

## EXAMPLES

### Example 1
```powershell
PS C:\> Get-KshUserProperty -UserLoginName 'i:0#.f|membership|admin@example.onmicrosoft.com'
```

Retrieves a user properties by user login name.

## PARAMETERS

### -Identity
Specifies the user properties.

```yaml
Type: UserProperty
Parameter Sets: ParamSet1
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -UserLoginName
Specifies the user login name.

```yaml
Type: String
Parameter Sets: ParamSet2
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Karamem0.SharePoint.PowerShell.Models.UserProperty

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.UserProperty

## NOTES

## RELATED LINKS
