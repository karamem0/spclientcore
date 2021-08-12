---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Remove-KshRoleDefinition

## SYNOPSIS
Removes a role definition.

## SYNTAX

```
Remove-KshRoleDefinition [-Identity] <RoleDefinition> [<CommonParameters>]
```

## DESCRIPTION
The Remove-KshRoleDefinition cmdlet removes a role definition from the current site.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-KshRoleDefinition -Identity (Get-KshRoleDefinition -RoleDefinitionName 'Viewer')
```

Removes a role definition.

## PARAMETERS

### -Identity
Specifies the role definition.

```yaml
Type: RoleDefinition
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

### Karamem0.SharePoint.PowerShell.Models.RoleDefinition

## OUTPUTS

### None

## NOTES

## RELATED LINKS
