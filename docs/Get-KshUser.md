---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Get-KshUser

## SYNOPSIS
Retrieves one or more users.

## SYNTAX

### ParamSet1
```
Get-KshUser [-Identity] <User> [<CommonParameters>]
```

### ParamSet2
```
Get-KshUser [-UserId] <Int32> [<CommonParameters>]
```

### ParamSet3
```
Get-KshUser [-UserName] <String> [<CommonParameters>]
```

### ParamSet4
```
Get-KshUser [-NoEnumerate] [<CommonParameters>]
```

## DESCRIPTION
The Get-KshUser cmdlet retrieves users of the current site.

## EXAMPLES

### Example 1
```powershell
PS C:\> Get-KshUser -UserId 1
```

Retrieves a user by user ID.

### Example 2
```powershell
PS C:\> Get-KshUser -UserName 'i:0#.f|membership|admin@example.onmicrosoft.com'
```

Retrieves a user by user login name.

### Example 3
```powershell
PS C:\> Get-KshUser -UserName 'admin@example.onmicrosoft.com'
```

Retrieves a user by user e-mail address.

### Example 4
```powershell
PS C:\> Get-KshUser
```

Retrieves all users of the current site.

## PARAMETERS

### -Identity
Specifies the user.

```yaml
Type: User
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
Parameter Sets: ParamSet4
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserId
Specifies the user ID.

```yaml
Type: Int32
Parameter Sets: ParamSet2
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserName
Specifies the user login name or e-mail address.

```yaml
Type: String
Parameter Sets: ParamSet3
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

### Karamem0.SharePoint.PowerShell.Models.User

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.User

## NOTES

## RELATED LINKS
