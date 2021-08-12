---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Remove-KshUser

## SYNOPSIS
Removes a user.

## SYNTAX

```
Remove-KshUser [-Identity] <User> [<CommonParameters>]
```

## DESCRIPTION
The Remove-KshUser cmdlet removes a user from the current site.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-KshUser -Identity (Get-KshUser -Identity 'i:0#.f|membership|admin@example.onmicrosoft.com')
```

Removes a user from the current site.

## PARAMETERS

### -Identity
Specifies the user.

```yaml
Type: User
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

### Karamem0.SharePoint.PowerShell.Models.User

## OUTPUTS

### None

## NOTES

## RELATED LINKS
