---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Remove-KshRoleAssignment

## SYNOPSIS
Removes a role assignment.

## SYNTAX

```
Remove-KshRoleAssignment [-Identity] <RoleAssignment> [<CommonParameters>]
```

## DESCRIPTION
The Remove-KshRoleAssignment cmdlet removes a role assignment from the site, list or list item.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-KshRoleAssignment -Identity (Get-KshRoleAssignment -PrincipalId 1)
```

Removes a role assignment.

## PARAMETERS

### -Identity
Specifies the role assignment.

```yaml
Type: RoleAssignment
Parameter Sets: (All)
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Karamem0.SharePoint.PowerShell.Models.RoleAssignment

## OUTPUTS

### None

## NOTES

## RELATED LINKS
