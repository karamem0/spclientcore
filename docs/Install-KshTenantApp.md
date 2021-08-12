---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Install-KshTenantApp

## SYNOPSIS
Installs the tenant app.

## SYNTAX

```
Install-KshTenantApp [-Identity] <App> [-PassThru] [<CommonParameters>]
```

## DESCRIPTION
The Install-KshTenantApp cmdlets installs the tenant app to the current site.

## EXAMPLES

### Example 1
```powershell
PS C:\> Install-KshTenantApp -Identity (Get-KshTenantApp -AppId 'fdee2390-48bf-409e-956a-20f11a0add59')
```

Installs an app.

## PARAMETERS

### -Identity
Specifies the app.

```yaml
Type: App
Parameter Sets: (All)
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByValue)
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

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Karamem0.SharePoint.PowerShell.Models.App

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.App

## NOTES

## RELATED LINKS
