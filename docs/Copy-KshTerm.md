---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Copy-KshTerm

## SYNOPSIS
Copies a term.

## SYNTAX

```
Copy-KshTerm [-Identity] <Term> [-CopyChildren] [<CommonParameters>]
```

## DESCRIPTION
The Copy-KshTerm cmdlet creates a copy from the term.

## EXAMPLES

### Example 1
```powershell
PS C:\> Copy-KshTerm (Get-KshTerm -TermSet (Get-KshTermSet -TermGroup (Get-KshTermGroup -TermGroupName 'Company') -TermSetName 'Department') -TermName 'Human Resources')
```

Copies a term.

## PARAMETERS

### -CopyChildren
If specified, copies the child terms.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

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

### Karamem0.SharePoint.PowerShell.Models.Term

## NOTES

## RELATED LINKS
