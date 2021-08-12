---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Get-KshNavigationNode

## SYNOPSIS
Retrieves one or more navigation nodes.

## SYNTAX

### ParamSet1
```
Get-KshNavigationNode [-Identity] <NavigationNode> [<CommonParameters>]
```

### ParamSet2
```
Get-KshNavigationNode [-NavigationNodeId] <Int32> [<CommonParameters>]
```

### ParamSet3
```
Get-KshNavigationNode [-NavigationNode] <NavigationNode> [-NoEnumerate] [<CommonParameters>]
```

## DESCRIPTION
The Get-KshNavigationNode cmdlet retrieves navigation nodes of the specified navigation node.

## EXAMPLES

### Example 1
```powershell
PS C:\> Get-KshNavigationNode -NavigationNodeId 2001
```

Retrieves a navigation node from the navigation node ID.

### Example 2
```powershell
PS C:\> Get-KshNavigationNode -NavigationNode (Get-KshNavigationNode -NavigationNodeId 2001)
```

Retrieves all navigation nodes.

## PARAMETERS

### -Identity
Specifies the navigation node.

```yaml
Type: NavigationNode
Parameter Sets: ParamSet1
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -NavigationNode
Specifies the parent navigation node.

```yaml
Type: NavigationNode
Parameter Sets: ParamSet3
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NavigationNodeId
Specifies the navigation node ID.

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

### Karamem0.SharePoint.PowerShell.Models.NavigationNode

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.NavigationNode

## NOTES

## RELATED LINKS
