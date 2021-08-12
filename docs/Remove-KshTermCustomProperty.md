---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Remove-KshTermCustomProperty

## SYNOPSIS
Removes a custom property of the term set or term.

## SYNTAX

### ParamSet1
```
Remove-KshTermCustomProperty [-TermSet] <TermSet> [-Name] <String> [<CommonParameters>]
```

### ParamSet2
```
Remove-KshTermCustomProperty [-Term] <Term> [-Name] <String> [<CommonParameters>]
```

## DESCRIPTION
The Remove-KshTermCustomProperty cmdlet removes a custom property from the term set or term.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-KshTermCustomProperty -TermSet (Get-KshTermSet -TermGroup (Get-KshTermGroup -TermGroupName 'Company') -TermSetName 'Department') -Name 'Hierarchy'
```

Removes a custom property from the term set.

### Example 2
```powershell
PS C:\> Remove-KshTermCustomProperty -Term (Get-KshTerm -TermSet (Get-KshTermSet -TermGroup (Get-KshTermGroup -TermGroupName 'Company') -TermSetName 'Department') -TermName 'Human Resources') -Name 'Hierarchy'
```

Removes a custom property from the term.

## PARAMETERS

### -Name
Specifies the name.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: True
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Term
Specifies the term.

```yaml
Type: Term
Parameter Sets: ParamSet2
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TermSet
Specifies the term set.

```yaml
Type: TermSet
Parameter Sets: ParamSet1
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

### Karamem0.SharePoint.PowerShell.Models.TermSet

### Karamem0.SharePoint.PowerShell.Models.Term

## OUTPUTS

### None

## NOTES

## RELATED LINKS
