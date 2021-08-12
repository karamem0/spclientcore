---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Add-KshTermCustomProperty

## SYNOPSIS
Adds a custom property of the term set or term.

## SYNTAX

### ParamSet1
```
Add-KshTermCustomProperty [-TermSet] <TermSet> -Name <String> -Value <String> [<CommonParameters>]
```

### ParamSet2
```
Add-KshTermCustomProperty [-Term] <Term> -Name <String> -Value <String> [<CommonParameters>]
```

## DESCRIPTION
The Add-KshTermCustomProperty cmdlet adds a custom property to the term set or term.

## EXAMPLES

### Example 1
```powershell
PS C:\> Add-KshTermCustomProperty -TermSet (Get-KshTermSet -TermGroup (Get-KshTermGroup -TermGroupName 'Company') -TermSetName 'Department') -Name 'Hierarchy' -Value '0'
```

Adds a custom property to the term set.

### Example 2
```powershell
PS C:\> Add-KshTermCustomProperty -Term (Get-KshTerm -TermSet (Get-KshTermSet -TermGroup (Get-KshTermGroup -TermGroupName 'Company') -TermSetName 'Department') -TermName 'Human Resources') -Name 'Hierarchy' -Value '1'
```

Adds a custom property to the term.

## PARAMETERS

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

### -Value
Specifies the value.

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

### Karamem0.SharePoint.PowerShell.Models.TermSet

### Karamem0.SharePoint.PowerShell.Models.Term

## OUTPUTS

### None

## NOTES

## RELATED LINKS
