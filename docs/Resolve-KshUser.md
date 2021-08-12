---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Resolve-KshUser

## SYNOPSIS
Validates a user.

## SYNTAX

```
Resolve-KshUser [-LoginName] <String> [<CommonParameters>]
```

## DESCRIPTION
The Resolve-KshUser cmdlet checks whether the user is a valid user of the current site, and add it to the site if not exists.

## EXAMPLES

### Example 1
```powershell
PS C:\> Resolve-KshUser -LoginName 'admin@example.onmicrosoft.com'
```

Validates a user.

## PARAMETERS

### -LoginName
Specifies the login name.

```yaml
Type: String
Parameter Sets: (All)
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

### System.String

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.User

## NOTES

## RELATED LINKS
