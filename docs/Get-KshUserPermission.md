---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Get-KshUserPermission

## SYNOPSIS
Retrieves an user permissions.

## SYNTAX

### ParamSet1
```
Get-KshUserPermission [-User] <User> [-Site] [<CommonParameters>]
```

### ParamSet2
```
Get-KshUserPermission [-User] <User> [-List] <List> [<CommonParameters>]
```

### ParamSet3
```
Get-KshUserPermission [-User] <User> [-ListItem] <ListItem> [<CommonParameters>]
```

## DESCRIPTION
The Get-KshUserPermission cmdlet retrieves user permissions for the the specified site, list or list item.

## EXAMPLES

### Example 1
```powershell
PS C:\> Get-KshUserPermission -User (Get-KshUser -UserName 'admin@example.onmicrosoft.com') -Site
```

Retrieves user permissions for the site.

### Example 2
```powershell
PS C:\> Get-KshUserPermission -User (Get-KshUser -UserName 'admin@example.onmicrosoft.com') -List (Get-KshList -ListTitle 'Announcements')
```

Retrieves user permissions for the list.

### Example 3
```powershell
PS C:\> Get-KshUserPermission -User (Get-KshUser -UserName 'admin@example.onmicrosoft.com') -ListItem (Get-KshListItem -List (Get-KshList -ListTitle 'Announcements') -ItemId 1)
```

Retrieves user permissions for the list item.

## PARAMETERS

### -List
Specifies the list.

```yaml
Type: List
Parameter Sets: ParamSet2
Aliases:

Required: True
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ListItem
Specifies the list item.

```yaml
Type: ListItem
Parameter Sets: ParamSet3
Aliases:

Required: True
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Site
If specified, uses the current site.

```yaml
Type: SwitchParameter
Parameter Sets: ParamSet1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -User
Specifies the user.

```yaml
Type: User
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

### Karamem0.SharePoint.PowerShell.Models.User

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.BasePermission

## NOTES

## RELATED LINKS
