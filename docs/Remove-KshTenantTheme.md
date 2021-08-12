---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Remove-KshTenantTheme

## SYNOPSIS
Removes a theme.

## SYNTAX

```
Remove-KshTenantTheme [-Identity] <TenantTheme> [<CommonParameters>]
```

## DESCRIPTION
The Remove-KshTenantTheme cmdlet removes a theme from the tenant.
This cmdlet can be used only when connected to the SharePoint admin center.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-KshTenantTheme -Identity (Get-KshTenantTheme -ThemeName 'Custom Theme')
```

Removes a theme.

## PARAMETERS

### -Identity
Specifies the theme.

```yaml
Type: TenantTheme
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

### Karamem0.SharePoint.PowerShell.Models.TenantTheme

## OUTPUTS

### None

## NOTES

## RELATED LINKS
