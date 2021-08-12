---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Get-KshRoleAssignment

## SYNOPSIS
Retrieves one or more role assignments.

## SYNTAX

### ParamSet1
```
Get-KshRoleAssignment [-Identity] <RoleAssignment> [<CommonParameters>]
```

### ParamSet2
```
Get-KshRoleAssignment [-Site] [-PrincipalId] <Int32> [<CommonParameters>]
```

### ParamSet3
```
Get-KshRoleAssignment [-Site] [-NoEnumerate] [<CommonParameters>]
```

### ParamSet4
```
Get-KshRoleAssignment [-List] <List> [-PrincipalId] <Int32> [<CommonParameters>]
```

### ParamSet5
```
Get-KshRoleAssignment [-List] <List> [-NoEnumerate] [<CommonParameters>]
```

### ParamSet6
```
Get-KshRoleAssignment [-ListItem] <ListItem> [-PrincipalId] <Int32> [<CommonParameters>]
```

### ParamSet7
```
Get-KshRoleAssignment [-ListItem] <ListItem> [-NoEnumerate] [<CommonParameters>]
```

## DESCRIPTION
The Get-KshRoleAssignment cmdlet retrieves role assignments of the current site, the specified list, or the specified list item.

## EXAMPLES

### Example 1
```powershell
PS C:\> Get-KshRoleAssignment -Site -PrincipalId 1
```

Retrieves a site role assignment by principal ID.

### Example 2
```powershell
PS C:\> Get-KshRoleAssignment -List (Get-KshList -ListUrl '/sites/japan/hr/Announcements') -PrincipalId 1
```

Retrieves a list role assignment by principal ID.

### Example 3
```powershell
PS C:\> Get-KshRoleAssignment -ListItem (Get-KshListItem -List (Get-KshList -ListUrl '/sites/japan/hr/Announcements') -ItemId 1) -PrincipalId 1
```

Retrieves a list item role assignment by principal ID.

### Example 4
```powershell
PS C:\> Get-KshRoleAssignment
```

Retrieves all site role assignments.

## PARAMETERS

### -Identity
Specifies the role assignment.

```yaml
Type: RoleAssignment
Parameter Sets: ParamSet1
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -List
Specifies the list.

```yaml
Type: List
Parameter Sets: ParamSet4, ParamSet5
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
Parameter Sets: ParamSet6, ParamSet7
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
Parameter Sets: ParamSet3, ParamSet5, ParamSet7
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PrincipalId
Specifies the user ID or group ID.

```yaml
Type: Int32
Parameter Sets: ParamSet2, ParamSet4, ParamSet6
Aliases:

Required: True
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Site
If specified, uses the current site.

```yaml
Type: SwitchParameter
Parameter Sets: ParamSet2, ParamSet3
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

### Karamem0.SharePoint.PowerShell.Models.RoleAssignment

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.RoleAssignment

## NOTES

## RELATED LINKS
