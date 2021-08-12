---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Get-KshTerm

## SYNOPSIS
Retrieves one or terms.

## SYNTAX

### ParamSet1
```
Get-KshTerm [-Identity] <Term> [<CommonParameters>]
```

### ParamSet2
```
Get-KshTerm [-TermLabel] <TermLabel> [<CommonParameters>]
```

### ParamSet3
```
Get-KshTerm [-TermSet] <TermSet> [-TermId] <Guid> [<CommonParameters>]
```

### ParamSet4
```
Get-KshTerm [-TermSet] <TermSet> [-TermName] <String> [<CommonParameters>]
```

### ParamSet5
```
Get-KshTerm [-TermSet] <TermSet> [-NoEnumerate] [<CommonParameters>]
```

### ParamSet6
```
Get-KshTerm [-Term] <Term> [-TermId] <Guid> [<CommonParameters>]
```

### ParamSet7
```
Get-KshTerm [-Term] <Term> [-TermName] <String> [<CommonParameters>]
```

### ParamSet8
```
Get-KshTerm [-Term] <Term> [-NoEnumerate] [<CommonParameters>]
```

## DESCRIPTION
The Get-KshTerm cmdlet retrieves terms of the term set or term.

## EXAMPLES

### Example 1
```powershell
PS C:\> Get-KshTerm -TermSet (Get-KshTermSet -TermGroup (Get-KshTermGroup -TermGroupName 'Company') -TermSetName 'Department') -TermId '4e45662f-c021-41fd-b413-967bf413d369'
```

Retrieves a term by term ID.

### Example 2
```powershell
PS C:\> Get-KshTerm -TermSet (Get-KshTermSet -TermGroup (Get-KshTermGroup -TermGroupName 'Company') -TermSetName 'Department') -TermName 'Human Resources'
```

Retrieves a term by term name.

### Example 3
```powershell
PS C:\> Get-KshTerm -TermSet (Get-KshTermSet -TermGroup (Get-KshTermGroup -TermGroupName 'Company') -TermSetName 'Department')
```

Retrieves all terms of the term set.

### Example 4
```powershell
PS C:\> Get-KshTerm -Term (Get-KshTerm -TermSet (Get-KshTermSet -TermGroup (Get-KshTermGroup -TermGroupName 'Company') -TermSetName 'Department') -TermName 'Human Resources')
```

Retrieves all terms of the term.

## PARAMETERS

### -Identity
Specifies the term.

```yaml
Type: Term
Parameter Sets: ParamSet1
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -NoEnumerate
If specified, suppresses to enumerate objects.

```yaml
Type: SwitchParameter
Parameter Sets: ParamSet5, ParamSet8
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
Parameter Sets: ParamSet6, ParamSet7, ParamSet8
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TermId
Specifies the term ID.

```yaml
Type: Guid
Parameter Sets: ParamSet3, ParamSet6
Aliases:

Required: True
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TermLabel
Specifies the term label.

```yaml
Type: TermLabel
Parameter Sets: ParamSet2
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -TermName
Specifies the term name.

```yaml
Type: String
Parameter Sets: ParamSet4, ParamSet7
Aliases:

Required: True
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TermSet
Specifies the term set.

```yaml
Type: TermSet
Parameter Sets: ParamSet3, ParamSet4, ParamSet5
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

### Karamem0.SharePoint.PowerShell.Models.Term

### Karamem0.SharePoint.PowerShell.Models.TermLabel

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.Term

## NOTES

## RELATED LINKS
