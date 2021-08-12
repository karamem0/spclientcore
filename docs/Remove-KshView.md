---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Remove-KshView

## SYNOPSIS
Removes a view.

## SYNTAX

```
Remove-KshView [-Identity] <View> [<CommonParameters>]
```

## DESCRIPTION
The Remove-KshView cmdlet removes a view from the parent list.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-KshView -Identity (Get-KshView -List (Get-KshList -ListTitle 'Announcements') -ViewTitle 'My Items')
```

Removes a view from the list.

## PARAMETERS

### -Identity
Specifies the view.

```yaml
Type: View
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

### Karamem0.SharePoint.PowerShell.Models.View

## OUTPUTS

### None

## NOTES

## RELATED LINKS
