---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Remove-KshTermGroup

## SYNOPSIS
Removes a term group.

## SYNTAX

```
Remove-KshTermGroup [-Identity] <TermGroup> [<CommonParameters>]
```

## DESCRIPTION
The Remove-KshTermGroup cmdlet removes a term group from the term store.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-KshTermGroup -Identity (Get-KshTermGroup -TermGroupName 'Company')
```

Removes a term group.

## PARAMETERS

### -Identity
Specifies the term group.

```yaml
Type: TermGroup
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

### Karamem0.SharePoint.PowerShell.Models.TermGroup

## OUTPUTS

### None

## NOTES

## RELATED LINKS
