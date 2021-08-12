---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Get-KshGroup

## SYNOPSIS
Retrieves one or more groups.

## SYNTAX

### ParamSet1
```
Get-KshGroup [-Identity] <Group> [<CommonParameters>]
```

### ParamSet2
```
Get-KshGroup [-GroupId] <Int32> [<CommonParameters>]
```

### ParamSet3
```
Get-KshGroup [-GroupTitle] <String> [<CommonParameters>]
```

### ParamSet4
```
Get-KshGroup [-NoEnumerate] [<CommonParameters>]
```

## DESCRIPTION
The Get-KshGroup cmdlet retrieves groups of the current site.

## EXAMPLES

### Example 1
```powershell
PS C:\> Get-KshGroup -GroupId 1
```

Retrieves a group by group ID.

### Example 2
```powershell
PS C:\> Get-KshGroup -GroupName 'Blog Owners'
```

Retrieves a group by group title.

### Example 3
```powershell
PS C:\> Get-KshGroup
```

Retrieves all groups.

## PARAMETERS

### -GroupId
Specifies the group ID.

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

### -GroupTitle
Specifies the group title.

```yaml
Type: String
Parameter Sets: ParamSet3
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Identity
Specifies the group.

```yaml
Type: Group
Parameter Sets: ParamSet1
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -NoEnumerate
If specified, suppresses to enumerate objects.

```yaml
Type: SwitchParameter
Parameter Sets: ParamSet4
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

### Karamem0.SharePoint.PowerShell.Models.Group

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.Group

## NOTES

## RELATED LINKS
