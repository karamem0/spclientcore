---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# New-KshAnonymousLink

## SYNOPSIS
Creates a new anonymous link.

## SYNTAX

### ParamSet1
```
New-KshAnonymousLink -Url <String> -IsEditLink <Boolean> [<CommonParameters>]
```

### ParamSet2
```
New-KshAnonymousLink -Url <String> -IsEditLink <Boolean> -Expiration <DateTime> [<CommonParameters>]
```

## DESCRIPTION
The New-KshAnonymousLink cmdlet generates a new anonymous link for the URL.
In order to use this cmdlet, the current site should be allowed to be shared with external users.

## EXAMPLES

### Example 1
```powershell
PS C:\> New-KshAnonymousLink -Url '/sites/japan/hr/Shared%20Documents/README.txt' -IsEditLink $true
```

Creates a new anonymous link.

## PARAMETERS

### -Expiration
Specifies the expiration date and time.

```yaml
Type: DateTime
Parameter Sets: ParamSet2
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsEditLink
Specifies whether it is an edit link.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Url
Specifies the URL.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: True
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

### System.String

## NOTES

## RELATED LINKS
