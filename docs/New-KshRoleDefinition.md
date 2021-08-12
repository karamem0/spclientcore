---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# New-KshRoleDefinition

## SYNOPSIS
Creates a new role definition.

## SYNTAX

```
New-KshRoleDefinition [-BasePermission <BasePermission>] [-Description <String>] -Name <String>
 [-Order <Int32>] [<CommonParameters>]
```

## DESCRIPTION
The New-KshRoleDefinition cmdlet adds a new role definition to the current site.

## EXAMPLES

### Example 1
```powershell
PS C:\> New-KshRoleDefinition -BasePermission (Initialize-KshBasePermission -Permission 'ViewListItems') -Name 'Viewer'
```

Creates a new role definition.

## PARAMETERS

### -BasePermission
Specifies the base permissions.

```yaml
Type: BasePermission
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

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

### -Order
Specifies the order.

```yaml
Type: Int32
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

### None

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.RoleDefinition

## NOTES

## RELATED LINKS
