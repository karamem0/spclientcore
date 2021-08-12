---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Get-KshRoleDefinition

## SYNOPSIS
Retrieves one or more role definitions.

## SYNTAX

### ParamSet1
```
Get-KshRoleDefinition [-Identity] <RoleDefinition> [<CommonParameters>]
```

### ParamSet2
```
Get-KshRoleDefinition [-RoleDefinitionId] <Int32> [<CommonParameters>]
```

### ParamSet3
```
Get-KshRoleDefinition [-RoleDefinitionName] <String> [<CommonParameters>]
```

### ParamSet4
```
Get-KshRoleDefinition [-NoEnumerate] [<CommonParameters>]
```

## DESCRIPTION
The Get-KshRoleDefinition cmdlet retrieves role definitions of the current site.

## EXAMPLES

### Example 1
```powershell
PS C:\> Get-KshRoleDefinition -RoleDefinitionId 1073741829
```

Retrieves a role definition by role definition ID.

### Example 2
```powershell
PS C:\> Get-KshRoleDefinition -RoleDefinitionName 'Full Control'
```

Retrieves a role definition by role definition name.

### Example 3
```powershell
PS C:\> Get-KshRoleDefinition
```

Retrieves all role definitions.

## PARAMETERS

### -Identity
Specifies the role definition.

```yaml
Type: RoleDefinition
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

### -RoleDefinitionId
Specifies the role definition ID.

```yaml
Type: Int32
Parameter Sets: ParamSet2
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RoleDefinitionName
Specifies the role definition name.

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

### Karamem0.SharePoint.PowerShell.Models.RoleDefinition

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.RoleDefinition

## NOTES

## RELATED LINKS
