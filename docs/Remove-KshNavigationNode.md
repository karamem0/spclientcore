---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Remove-KshNavigationNode

## SYNOPSIS
Removes a navigation node.

## SYNTAX

```
Remove-KshNavigationNode [-Identity] <NavigationNode> [<CommonParameters>]
```

## DESCRIPTION
The Remove-KshNavigationNode cmdlet removes a navigation node from the parent navigation node.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-KshNavigationNode -Identity (Get-KshNavigationNode -NavigationNodeId 2001)
```

Removes a navigation node.

## PARAMETERS

### -Identity
Specifies the navigation node.

```yaml
Type: NavigationNode
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

### Karamem0.SharePoint.PowerShell.Models.NavigationNode

## OUTPUTS

### None

## NOTES

## RELATED LINKS
