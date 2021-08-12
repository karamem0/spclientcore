---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Remove-KshAnonymousLink

## SYNOPSIS
Removes an anonymous link.

## SYNTAX

```
Remove-KshAnonymousLink [-Url] <String> [-IsEditLink] <Boolean> [-RemoveAssociatedSharingLinkGroup] <Boolean>
 [<CommonParameters>]
```

## DESCRIPTION
The Remove-KshAnonymousLink cmdlet removes an anonymous link for the URL.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-KshAnonymousLink -Url '/sites/japan/hr/Shared%20Documents/README.txt' -IsEditLink $true -RemoveAssociatedSharingLinkGroup $true
```

Removes an anonymous link.

## PARAMETERS

### -IsEditLink
Specifies whether it is an edit link.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: True
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RemoveAssociatedSharingLinkGroup
Specifies whether to remove the associated sharing link group.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: True
Position: 2
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

Required: True
Position: 0
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### None

## OUTPUTS

### None

## NOTES

## RELATED LINKS
