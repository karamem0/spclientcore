---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Remove-KshTermSet

## SYNOPSIS
Removes a term set.

## SYNTAX

```
Remove-KshTermSet [-Identity] <TermSet> [<CommonParameters>]
```

## DESCRIPTION
The Remove-KshTermSet cmdlet removes a term set from the parent term group.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-KshTermSet -Identity (Get-KshTermSet -TermGroup (Get-KshTermGroup -TermGroupName 'Company') -TermSetName 'Department')
```

Removes a term set.

## PARAMETERS

### -Identity
Specifies the term set.

```yaml
Type: TermSet
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

### Karamem0.SharePoint.PowerShell.Models.TermSet

## OUTPUTS

### None

## NOTES

## RELATED LINKS
