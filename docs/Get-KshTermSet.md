---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Get-KshTermSet

## SYNOPSIS
Retrieves one or term sets.

## SYNTAX

### ParamSet1
```
Get-KshTermSet [-Identity] <TermSet> [<CommonParameters>]
```

### ParamSet2
```
Get-KshTermSet [-TermGroup] <TermGroup> [-TermSetId] <Guid> [<CommonParameters>]
```

### ParamSet3
```
Get-KshTermSet [-TermGroup] <TermGroup> [-TermSetName] <String> [<CommonParameters>]
```

### ParamSet4
```
Get-KshTermSet [-TermGroup] <TermGroup> [-NoEnumerate] [<CommonParameters>]
```

## DESCRIPTION
The Get-KshTermSet cmdlet retrieves term sets of the term group.

## EXAMPLES

### Example 1
```powershell
PS C:\> Get-KshTermSet -TermGroup (Get-KshTermGroup -TermGroupName 'Company') -TermSetId '543a5c66-1de4-475a-9047-e4bd3aa4f2d7'
```

Retrieves a term set by term set ID.

### Example 2
```powershell
PS C:\> Get-KshTermSet -TermGroup (Get-KshTermGroup -TermGroupName 'Company') -TermSetName 'Department'
```

Retrieves a term set by term set name.

### Example 3
```powershell
PS C:\> Get-KshTermSet -TermGroup (Get-KshTermGroup -TermGroupName 'Company')
```

Retrieves all term sets.

## PARAMETERS

### -Identity
Specifies the term set.

```yaml
Type: TermSet
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
Parameter Sets: ParamSet4
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TermGroup
Specifies the term group.

```yaml
Type: TermGroup
Parameter Sets: ParamSet2, ParamSet3, ParamSet4
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TermSetId
Specifies the term set ID.

```yaml
Type: Guid
Parameter Sets: ParamSet2
Aliases:

Required: True
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TermSetName
Specifies the term set name.

```yaml
Type: String
Parameter Sets: ParamSet3
Aliases:

Required: True
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Karamem0.SharePoint.PowerShell.Models.TermSet

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.TermSet

## NOTES

## RELATED LINKS
