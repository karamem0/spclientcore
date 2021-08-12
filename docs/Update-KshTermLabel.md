---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Update-KshTermLabel

## SYNOPSIS
Updates a term label.

## SYNTAX

### ParamSet1
```
Update-KshTermLabel [-Identity] <TermLabel> -Lcid <UInt32> [-PassThru] [<CommonParameters>]
```

### ParamSet2
```
Update-KshTermLabel [-Identity] <TermLabel> -Name <String> [-PassThru] [<CommonParameters>]
```

### ParamSet3
```
Update-KshTermLabel [-Identity] <TermLabel> [-IsDefault] [-PassThru] [<CommonParameters>]
```

## DESCRIPTION
The Update-KshTermLabel cmdlet updates properties of the term label.

## EXAMPLES

### Example 1
```powershell
PS C:\> Update-KshTermLabel -Identity (Get-KshTermLabel -Term (Get-KshTerm -TermSet (Get-KshTermSet -TermGroup (Get-KshTermGroup -TermGroupName 'Company') -TermSetName 'Department') -TermName 'Human Resources') -LabelName 'HR') -Lcid 1041
```

Updates property values of the term label.

## PARAMETERS

### -Identity
Specifies the term label.

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

### -IsDefault
If specified, sets the term label as default.

```yaml
Type: SwitchParameter
Parameter Sets: ParamSet3
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Lcid
Specifies the locale ID.
For more information, see [reference](https://docs.microsoft.com/ja-jp/openspecs/windows_protocols/ms-lcid/70feba9f-294e-491e-b6eb-56532684c37f).

```yaml
Type: UInt32
Parameter Sets: ParamSet1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
Specifies the name.

```yaml
Type: String
Parameter Sets: ParamSet2
Aliases:

Required: True
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

### Karamem0.SharePoint.PowerShell.Models.TermLabel

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.TermLabel

## NOTES

## RELATED LINKS
