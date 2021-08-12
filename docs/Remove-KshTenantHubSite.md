---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Remove-KshTenantHubSite

## SYNOPSIS
Removes a hub site.

## SYNTAX

```
Remove-KshTenantHubSite [-Identity] <HubSite> [<CommonParameters>]
```

## DESCRIPTION
The Remove-KshTenantHubSite cmdlet removes a hub site.
This cmdlet can be used only when connected to the SharePoint admin center.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-KshTenantHubSite -Identity (Get-KshTenantHubSite -HubSiteUrl 'https://example.sharepoint.com/sites/hub')
```

Removes a hub site.

## PARAMETERS

### -Identity
Specifies the hub site.

```yaml
Type: HubSite
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

### Karamem0.SharePoint.PowerShell.Models.HubSite

## OUTPUTS

### None

## NOTES

## RELATED LINKS
