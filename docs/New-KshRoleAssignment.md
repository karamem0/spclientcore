---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# New-KshRoleAssignment

## SYNOPSIS
Creates a new role assignment.

## SYNTAX

### ParamSet1
```
New-KshRoleAssignment [-Site] [-Principal] <Principal> [-RoleDefinition] <RoleDefinition> [<CommonParameters>]
```

### ParamSet2
```
New-KshRoleAssignment [-List] <List> [-Principal] <Principal> [-RoleDefinition] <RoleDefinition>
 [<CommonParameters>]
```

### ParamSet3
```
New-KshRoleAssignment [-ListItem] <ListItem> [-Principal] <Principal> [-RoleDefinition] <RoleDefinition>
 [<CommonParameters>]
```

## DESCRIPTION
The New-KshRoleAssignment cmdlet adds a new role assignment to the current site, the specified list, or the specified list item.

## EXAMPLES

### Example 1
```powershell
PS C:\> New-KshRoleAssignment -Site -Principal (Get-KshUser -Identity 'i:0#.f|membership|admin@example.onmicrosoft.com') -RoleDefinition (Get-KshRoleDefinition -RoleDefinitionName 'Full Control')
```

Creates a new role assignment.

## PARAMETERS

### -List
Specifies the list.

```yaml
Type: List
Parameter Sets: ParamSet2
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ListItem
Specifies the list item.

```yaml
Type: ListItem
Parameter Sets: ParamSet3
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Principal
Specifies the user or group.

```yaml
Type: Principal
Parameter Sets: (All)
Aliases:

Required: True
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RoleDefinition
Specifies the role definition.

```yaml
Type: RoleDefinition
Parameter Sets: (All)
Aliases:

Required: True
Position: 2
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Site
If specified, uses the current site.

```yaml
Type: SwitchParameter
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

### None

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.RoleAssignment

## NOTES

## RELATED LINKS
