---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Get-KshTermGroup

## SYNOPSIS
Retrieves one or term groups.

## SYNTAX

### ParamSet1
```
Get-KshTermGroup [-Identity] <TermGroup> [<CommonParameters>]
```

### ParamSet2
```
Get-KshTermGroup [-TermGroupId] <Guid> [<CommonParameters>]
```

### ParamSet3
```
Get-KshTermGroup [-TermGroupName] <String> [<CommonParameters>]
```

### ParamSet4
```
Get-KshTermGroup [-NoEnumerate] [<CommonParameters>]
```

## DESCRIPTION
The Get-KshTermGroup cmdlet retrieves term groups of the term store.

## EXAMPLES

### Example 1
```powershell
PS C:\> Get-KshTermGroup -TermGroupId '50df975d-4239-43c8-ae5f-276f1046018a'
```

Retrieves a term group by term group ID.

### Example 2
```powershell
PS C:\> Get-KshTermGroup -TermGroupName 'Company'
```

Retrieves a term group by term group name.

### Example 3
```powershell
PS C:\> Get-KshTermGroup
```

Retrieves all term groups.

## PARAMETERS

### -Identity
Specifies the term group.

```yaml
Type: TermGroup
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

### -TermGroupId
Specifies the term group ID.

```yaml
Type: Guid
Parameter Sets: ParamSet2
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TermGroupName
Specifies the term group name.

```yaml
Type: String
Parameter Sets: ParamSet3
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

### Karamem0.SharePoint.PowerShell.Models.TermGroup

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.TermGroup

## NOTES

## RELATED LINKS
