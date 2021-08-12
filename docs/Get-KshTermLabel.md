---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Get-KshTermLabel

## SYNOPSIS
Retrieves one or term labels.

## SYNTAX

### ParamSet1
```
Get-KshTermLabel [-Identity] <TermLabel> [<CommonParameters>]
```

### ParamSet2
```
Get-KshTermLabel [-Term] <Term> [-LabelName] <String> [<CommonParameters>]
```

### ParamSet3
```
Get-KshTermLabel [-Term] <Term> [-NoEnumerate] [<CommonParameters>]
```

## DESCRIPTION
The Get-KshTermLabel cmdlet retrieves label of the term.

## EXAMPLES

### Example 1
```powershell
PS C:\> Get-KshTermLabel -Term (Get-KshTerm -TermSet (Get-KshTermSet -TermGroup (Get-KshTermGroup -TermGroupName 'Company') -TermSetName 'Department') -TermName 'Human Resources') -LabelName 'HR'
```

Retrieves a label by label name.

### Example 2
```powershell
PS C:\> Get-KshTermLabel -Term (Get-KshTerm -TermSet (Get-KshTermSet -TermGroup (Get-KshTermGroup -TermGroupName 'Company') -TermSetName 'Department') -TermName 'Human Resources')
```

Retrieves all labels.

## PARAMETERS

### -Identity
Specifies the label.

```yaml
Type: TermLabel
Parameter Sets: ParamSet1
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -LabelName
Specifies the label name.

```yaml
Type: String
Parameter Sets: ParamSet2
Aliases:

Required: True
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NoEnumerate
If specified, suppresses to enumerate objects.

```yaml
Type: SwitchParameter
Parameter Sets: ParamSet3
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Term
Specifies the term.

```yaml
Type: Term
Parameter Sets: ParamSet2, ParamSet3
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

### Karamem0.SharePoint.PowerShell.Models.TermLabel

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.TermLabel

## NOTES

## RELATED LINKS
