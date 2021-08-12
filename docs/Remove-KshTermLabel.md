---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Remove-KshTermLabel

## SYNOPSIS
Removes a label of the term.

## SYNTAX

```
Remove-KshTermLabel [-Identity] <TermLabel> [<CommonParameters>]
```

## DESCRIPTION
The Remove-KshTermLabel cmdlet removes a label from term.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-KshTermLabel -Identity (Get-KshTermLabel -Term (Get-KshTerm -TermSet (Get-KshTermSet -TermGroup (Get-KshTermGroup -TermGroupName 'Company') -TermSetName 'Department') -TermName 'Human Resources') -LabelName 'HR')
```

Removes a label.

## PARAMETERS

### -Identity
Specifies the label.

```yaml
Type: TermLabel
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

### Karamem0.SharePoint.PowerShell.Models.TermLabel

## OUTPUTS

### None

## NOTES

## RELATED LINKS
