---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Update-KshNavigationNode

## SYNOPSIS
Updates a navigation node.

## SYNTAX

```
Update-KshNavigationNode [-Identity] <NavigationNode> [-AudienceIds <Guid[]>] [-IsVisible <Boolean>]
 [-Title <String>] [-Url <String>] [-PassThru] [<CommonParameters>]
```

## DESCRIPTION
The Update-KshNavigationNode cmdlet updates column values of the navigation node.

## EXAMPLES

### Example 1
```powershell
PS C:\> Update-KshNavigationNode -Identity (Get-KshNavigationNode -NavigationNodeId 2001) -Title 'Google' -Url 'https://www.google.com'
```

Updates column values of the navigation node.

## PARAMETERS

### -AudienceIds
Specifies the audience IDs.

```yaml
Type: Guid[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

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

### -IsVisible
Specifies whether the navigation node is visible.

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

### -PassThru
If specified, returns the updated object.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
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
