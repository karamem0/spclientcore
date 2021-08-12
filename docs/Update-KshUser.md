---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Update-KshUser

## SYNOPSIS
Updates a user.

## SYNTAX

```
Update-KshUser [-Identity] <User> [-Email <String>] [-IsSiteCollectionAdmin <Boolean>] [-Title <String>]
 [-PassThru] [<CommonParameters>]
```

## DESCRIPTION
The Update-KshUser cmdlet updates properties of the user.

## EXAMPLES

### Example 1
```powershell
PS C:\> Update-KshUser -Identity (Get-KshUser -Identity 'i:0#.f|membership|admin@example.onmicrosoft.com') -IsSiteCollectionAdmin $true
```

Updates property values of the user.

## PARAMETERS

### -Email
Specifies the e-mail address.

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

### -IsSiteCollectionAdmin
Specifies whether the user is a site collection administrator.

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

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Karamem0.SharePoint.PowerShell.Models.User

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.User

## NOTES

## RELATED LINKS
