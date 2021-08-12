---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Update-KshTermGroup

## SYNOPSIS
Updates a term group.

## SYNTAX

```
Update-KshTermGroup [-Identity] <TermGroup> [-Description <String>] [-Name <String>] [-PassThru]
 [<CommonParameters>]
```

## DESCRIPTION
The Update-KshTermGroup cmdlet updates properties of the term group.

## EXAMPLES

### Example 1
```powershell
PS C:\> Update-KshTermGroup -Identity (Get-KshTermGroup -TermGroupName 'Company') -Name 'Location'
```

Updates property values of the term group.

## PARAMETERS

### -Description
Specifies the description.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Identity
Specifies the term group.

```yaml
Type: TermGroup
Parameter Sets: (All)
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Name
Specifies the name.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PassThru
If specified, returns the updated object.

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

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Karamem0.SharePoint.PowerShell.Models.TermGroup

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.TermGroup

## NOTES

## RELATED LINKS
