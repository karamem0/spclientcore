---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Get-KshListTemplate

## SYNOPSIS
Retrieves one or more list templates.

## SYNTAX

### ParamSet1
```
Get-KshListTemplate [-Identity] <ListTemplate> [<CommonParameters>]
```

### ParamSet2
```
Get-KshListTemplate [-ListTemplateTitle] <String> [<CommonParameters>]
```

### ParamSet3
```
Get-KshListTemplate [-NoEnumerate] [<CommonParameters>]
```

## DESCRIPTION
The Get-KshListTemplate cmdlet retrieves list templates of the current site.

## EXAMPLES

### Example 1
```powershell
PS C:\> Get-KshListTemplate -ListTemplateTitle 'Document Library'
```

Retrieves a list template by list template title.

### Example 2
```powershell
PS C:\> Get-KshListTemplate
```

Retrieves all list templates.

## PARAMETERS

### -Identity
Specifies the list template.

```yaml
Type: ListTemplate
Parameter Sets: ParamSet1
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ListTemplateTitle
Specifies the list template title.

```yaml
Type: String
Parameter Sets: ParamSet2
Aliases:

Required: True
Position: 0
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

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Karamem0.SharePoint.PowerShell.Models.ListTemplate

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.ListTemplate

## NOTES

## RELATED LINKS
