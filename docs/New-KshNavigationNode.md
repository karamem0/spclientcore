---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# New-KshNavigationNode

## SYNOPSIS
Creates a new navigation node.

## SYNTAX

### ParamSet1
```
New-KshNavigationNode [-NavigationNode] <NavigationNode> [-AsLastNode <Boolean>] [-IsExternal <Boolean>]
 [-PreviousNode <NavigationNode>] [-Title <String>] [-Url <String>] [<CommonParameters>]
```

### ParamSet2
```
New-KshNavigationNode [-QuickLaunch] [-AsLastNode <Boolean>] [-IsExternal <Boolean>]
 [-PreviousNode <NavigationNode>] [-Title <String>] [-Url <String>] [<CommonParameters>]
```

### ParamSet3
```
New-KshNavigationNode [-TopNavigationBar] [-AsLastNode <Boolean>] [-IsExternal <Boolean>]
 [-PreviousNode <NavigationNode>] [-Title <String>] [-Url <String>] [<CommonParameters>]
```

## DESCRIPTION
The New-KshNavigationNode cmdlet adds a new navigation node to the specified navigation node.

## EXAMPLES

### Example 1
```powershell
PS C:\> New-KshNavigationNode -NavigationNode (Get-KshNavigationNode -NavigationNodeId 2001) -Title 'Bing' -Url 'https://www.bing.com'
```

Creates a new navigation node.

## PARAMETERS

### -AsLastNode
Specifies whether to add the navigation node to the last.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsExternal
Specifies whether the URL is external.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NavigationNode
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

### -PreviousNode
Specifies the previous node which the new navigation node to be added.

```yaml
Type: NavigationNode
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -QuickLaunch
If specified, the new navigation node is added to the quick launch.

```yaml
Type: SwitchParameter
Parameter Sets: ParamSet2
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Title
Specifies the title.

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

### -TopNavigationBar
If specified, the new navigation node is added to the top navigation bar.

```yaml
Type: SwitchParameter
Parameter Sets: ParamSet3
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Url
Specifies the URL.

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

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Karamem0.SharePoint.PowerShell.Models.NavigationNode

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.NavigationNode

## NOTES

## RELATED LINKS
