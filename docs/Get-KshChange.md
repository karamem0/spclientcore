---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Get-KshChange

## SYNOPSIS
Retrieves changes.

## SYNTAX

### ParamSet1
```
Get-KshChange [-SiteCollection] [-BeginToken <ChangeToken>] [-EndToken <ChangeToken>] [-FetchLimit <Int64>]
 [-Objects <ChangeObjects>] [-Operations <ChangeOperations>] [-RecursiveAll <Boolean>] [-NoEnumerate]
 [<CommonParameters>]
```

### ParamSet2
```
Get-KshChange [-Site] [-BeginToken <ChangeToken>] [-EndToken <ChangeToken>] [-FetchLimit <Int64>]
 [-Objects <ChangeObjects>] [-Operations <ChangeOperations>] [-RecursiveAll <Boolean>] [-NoEnumerate]
 [<CommonParameters>]
```

### ParamSet3
```
Get-KshChange [-List] <List> [-BeginToken <ChangeToken>] [-EndToken <ChangeToken>] [-FetchLimit <Int64>]
 [-Objects <ChangeObjects>] [-Operations <ChangeOperations>] [-RecursiveAll <Boolean>] [-NoEnumerate]
 [<CommonParameters>]
```

## DESCRIPTION
The Get-KshChange cmdlet retrieves changes of the current site collection, the current site, or the specified list.

## EXAMPLES

### Example 1
```powershell
PS C:\> Get-KshChange -SiteCollection -Objects All -Operations All
```

Retrieves all changes for the current site collection.

### Example 2
```powershell
PS C:\> Get-KshChange -Site -Objects All -Operations All
```

Retrieves all changes for the current site.

### Example 3
```powershell
PS C:\> Get-KshChange -List (Get-KshList -ListTitle 'Announcements') -Objects All -Operations All
```

Retrieves all changes for the specified list.

## PARAMETERS

### -BeginToken
Specifies the change token for the beginning.

```yaml
Type: ChangeToken
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EndToken
Specifies the change token for the ending.

```yaml
Type: ChangeToken
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FetchLimit
Specifies the number of items.

```yaml
Type: Int64
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -List
Specifies the list.

```yaml
Type: List
Parameter Sets: ParamSet3
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
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Objects
Specifies objects to retrieve.

```yaml
Type: ChangeObjects
Parameter Sets: (All)
Aliases:
Accepted values: None, Item, List, Site, SiteCollection, File, Folder, Alert, User, Group, ContentType, Column, SecurityPolicy, View, All

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Operations
Specifies operations to retrieve.

```yaml
Type: ChangeOperations
Parameter Sets: (All)
Aliases:
Accepted values: None, Add, Update, DeleteObject, Rename, Move, Restore, RoleDefinitionAdd, RoleDefinitionDelete, RoleDefinitionUpdate, RoleAssignmentAdd, RoleAssignmentDelete, GroupMembershipAdd, GroupMembershipDelete, SystemUpdate, Navigation, All

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RecursiveAll
Specifies to retrieve recursively.

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

### -Site
If specified, uses the current site.

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

### -SiteCollection
If specified, uses the current site colletion.

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

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### None

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.Change

## NOTES

## RELATED LINKS
