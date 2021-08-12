---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Add-KshGroupMember

## SYNOPSIS
Adds a group member.

## SYNTAX

```
Add-KshGroupMember [-Group] <Group> -Member <User> [<CommonParameters>]
```

## DESCRIPTION
The Add-KshGroupMember cmdlet add a user to the specified group.

## EXAMPLES

### Example 1
```powershell
PS C:\> Add-KshGroupMember -Group (Get-KshGroup -GroupName 'Blog Owners') -Member (Get-KshUser -UserName 'i:0#.f|membership|admin@example.onmicrosoft.com')
```

Adds a group member.

## PARAMETERS

### -Group
Specifies the group.

```yaml
Type: Group
Parameter Sets: (All)
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Member
Specifies the user.

```yaml
Type: User
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

### Karamem0.SharePoint.PowerShell.Models.Group

## OUTPUTS

### None

## NOTES

## RELATED LINKS
