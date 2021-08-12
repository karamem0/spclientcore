---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Remove-KshTerm

## SYNOPSIS
Removes a term.

## SYNTAX

```
Remove-KshTerm [-Identity] <Term> [<CommonParameters>]
```

## DESCRIPTION
The Remove-KshTerm cmdlet removes a term from the parent term set or term.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-KshTerm -Identity (Get-KshTerm -TermSet (Get-KshTermSet -TermGroup (Get-KshTermGroup -TermGroupName 'Company') -TermSetName 'Department') -TermName 'Human Resources')
```

Removes a term.

## PARAMETERS

### -Identity
Specifies the term.

```yaml
Type: Term
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

### Karamem0.SharePoint.PowerShell.Models.Term

## OUTPUTS

### None

## NOTES

## RELATED LINKS
