---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# New-KshTermGroup

## SYNOPSIS
Creates a new term group.

## SYNTAX

```
New-KshTermGroup [-Id <Guid>] -Name <String> [<CommonParameters>]
```

## DESCRIPTION
The New-KshTermGroup cmdlet adds a new term group to the term set.

## EXAMPLES

### Example 1
```powershell
PS C:\> New-KshTermGroup -Name 'Company'
```

Creates a new term group.

## PARAMETERS

### -Id
Specifies the ID.

```yaml
Type: Guid
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
Specifies the name.

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

### Karamem0.SharePoint.PowerShell.Models.TermGroup

## NOTES

## RELATED LINKS
