---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Update-KshGroup

## SYNOPSIS
Updates a group.

## SYNTAX

```
Update-KshGroup [-Identity] <Group> [-AllowMembersEditMembership <Boolean>]
 [-AllowRequestToJoinLeave <Boolean>] [-AutoAcceptRequestToJoinLeave <Boolean>] [-Description <String>]
 [-OnlyAllowMembersViewMembership <Boolean>] [-RequestToJoinLeaveEmailSetting <String>] [-Title <String>]
 [-PassThru] [<CommonParameters>]
```

## DESCRIPTION
The Update-KshGroup cmdlet updates properties of the group.

## EXAMPLES

### Example 1
```powershell
PS C:\> Update-KshGroup -Identity (Get-KshGroup -GroupName 'Blog Owners') -AllowMembersEditMembership $true
```

Updates property values of the group.

## PARAMETERS

### -AllowMembersEditMembership
Specifies whether members are allowed to edit membership.

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

### -AllowRequestToJoinLeave
Specifies whether to allow requests to join or leave.

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

### -AutoAcceptRequestToJoinLeave
Specifies whether to automatically accept requests to join or leave.

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

### -Identity
Specifies the group.

```yaml
Type: Group
Parameter Sets: (All)
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -OnlyAllowMembersViewMembership
Specifies whether only members are allowed to view membership.

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

### -RequestToJoinLeaveEmailSetting
Specifies the e-mail address to send requests to join or leave.

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
