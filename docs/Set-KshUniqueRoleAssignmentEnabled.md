---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Set-KshUniqueRoleAssignmentEnabled

## SYNOPSIS
Changes whether unique role assignment is enabled.

## SYNTAX

### ParamSet1
```
Set-KshUniqueRoleAssignmentEnabled [-Site] [-Enabled] [-CopyRoleAssignments] [-ClearSubscopes]
 [<CommonParameters>]
```

### ParamSet2
```
Set-KshUniqueRoleAssignmentEnabled [-Site] [-Disabled] [<CommonParameters>]
```

### ParamSet3
```
Set-KshUniqueRoleAssignmentEnabled [-List] <List> [-Enabled] [-CopyRoleAssignments] [-ClearSubscopes]
 [<CommonParameters>]
```

### ParamSet4
```
Set-KshUniqueRoleAssignmentEnabled [-List] <List> [-Disabled] [<CommonParameters>]
```

### ParamSet5
```
Set-KshUniqueRoleAssignmentEnabled [-ListItem] <ListItem> [-Enabled] [-CopyRoleAssignments] [-ClearSubscopes]
 [<CommonParameters>]
```

### ParamSet6
```
Set-KshUniqueRoleAssignmentEnabled [-ListItem] <ListItem> [-Disabled] [<CommonParameters>]
```

## DESCRIPTION
The Set-KshUniqueRoleAssignmentEnabled cmdlet changes whether a unique role assignment is enabled for the current site, the specified list, or the specified list item.

## EXAMPLES

### Example 1
```powershell
PS C:\> Set-KshUniqueRoleAssignmentEnabled -Site -Enabled -CopyRoleAssignments -ClearSubscopes
```

Creates unique role assignments.

### Example 2
```powershell
PS C:\> Set-KshUniqueRoleAssignmentEnabled -Site -Disabled
```

Removes unique role assignments.

## PARAMETERS

### -ClearSubscopes
If specified, the role assignments for all child securable objects must be cleared.

```yaml
Type: SwitchParameter
Parameter Sets: ParamSet1, ParamSet3, ParamSet5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CopyRoleAssignments
If specified, copies the role assignments from the specified securable object.

```yaml
Type: SwitchParameter
Parameter Sets: ParamSet1, ParamSet3, ParamSet5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Disabled
If specified, removes unique role assignments for the securable object.

```yaml
Type: SwitchParameter
Parameter Sets: ParamSet2, ParamSet4, ParamSet6
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Enabled
If specified, creates unique role assignments for the securable object.

```yaml
Type: SwitchParameter
Parameter Sets: ParamSet1, ParamSet3, ParamSet5
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -List
Specifies the list.

```yaml
Type: List
Parameter Sets: ParamSet3, ParamSet4
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
Parameter Sets: ParamSet5, ParamSet6
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Site
If specified, uses the current site.

```yaml
Type: SwitchParameter
Parameter Sets: ParamSet1, ParamSet2
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

### Karamem0.SharePoint.PowerShell.Models.Site

### Karamem0.SharePoint.PowerShell.Models.List

### Karamem0.SharePoint.PowerShell.Models.ListItem

## OUTPUTS

### None

## NOTES

## RELATED LINKS
