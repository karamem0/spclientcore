---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Get-KshGroupMember

## SYNOPSIS
Retrieves one or more group members.

## SYNTAX

### ParamSet1
```
Get-KshGroupMember [-Group] <Group> [-MemberId] <Int32> [<CommonParameters>]
```

### ParamSet2
```
Get-KshGroupMember [-Group] <Group> [-MemberName] <String> [<CommonParameters>]
```

### ParamSet3
```
Get-KshGroupMember [-Group] <Group> [-NoEnumerate] [<CommonParameters>]
```

## DESCRIPTION
The Get-KshUser cmdlet retrieves members of the specified group.

## EXAMPLES

### Example 1
```powershell
PS C:\> Get-KshGroupMember -Group (Get-KshGroup -GroupName 'Blog Owners') -MemberId 1
```

Retrieves a group member by member ID.

### Example 2
```powershell
PS C:\> Get-KshGroupMember -Group (Get-KshGroup -GroupName 'Blog Owners') -MemberName 'i:0#.f|membership|admin@example.onmicrosoft.com'
```

Retrieves a group member by member login name.

### Example 3
```powershell
PS C:\> Get-KshGroupMember -Group (Get-KshGroup -GroupName 'Blog Owners') -MemberName 'admin@example.onmicrosoft.com'
```

Retrieves a group member by member e-mail address.

### Example 4
```powershell
PS C:\> Get-KshGroupMember -Group (Get-KshGroup -GroupName 'Blog Owners')
```

Retrieves all users of the group.

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

### -MemberId
Specifies the user ID.

```yaml
Type: Int32
Parameter Sets: ParamSet1
Aliases:

Required: True
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MemberName
Specifies the user login name or e-mail address.

```yaml
Type: String
Parameter Sets: ParamSet2
Aliases:

Required: True
Position: 1
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

### None

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.User

## NOTES

## RELATED LINKS
