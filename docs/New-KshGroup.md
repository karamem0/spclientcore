---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# New-KshGroup

## SYNOPSIS
Creates a new group.

## SYNTAX

```
New-KshGroup [-Description <String>] -Title <String> [<CommonParameters>]
```

## DESCRIPTION
The New-KshGroup cmdlet adds a new group to the current site.

## EXAMPLES

### Example 1
```powershell
PS C:\> New-KshGroup -Description 'The members can manage Blog posts.' -Title 'Blog Owners'
```

Creates a new group.

## PARAMETERS

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

### -Title
Specifies the title.

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

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### None

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.Group

## NOTES

## RELATED LINKS
