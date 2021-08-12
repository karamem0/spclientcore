---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Remove-KshGroupMember

## SYNOPSIS
Removes a group member.

## SYNTAX

```
Remove-KshGroupMember [-Group] <Group> [-Member] <User> [<CommonParameters>]
```

## DESCRIPTION
The Remove-KshGroupMember cmdlet removes a member from the specified group.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-KshGroupMember -Group (Get-KshGroup -GroupName 'Blog Owners') -Member (Get-KshUser -UserName 'i:0#.f|membership|admin@example.onmicrosoft.com')
```

Removes a group member.

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
Position: 1
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
