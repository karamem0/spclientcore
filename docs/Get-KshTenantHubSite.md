---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Get-KshTenantHubSite

## SYNOPSIS
Retrieves one or more hub sites.

## SYNTAX

### ParamSet1
```
Get-KshTenantHubSite [-HubSiteId] <Guid> [<CommonParameters>]
```

### ParamSet2
```
Get-KshTenantHubSite [-HubSiteUrl] <String> [<CommonParameters>]
```

### ParamSet3
```
Get-KshTenantHubSite [-NoEnumerate] [<CommonParameters>]
```

## DESCRIPTION
The Get-KshTenantHubSite cmdlet retrieves hub sites.
This cmdlet can be used only when connected to the SharePoint admin center.

## EXAMPLES

### Example 1
```powershell
PS C:\> Get-KshTenantHubSite -HubSiteId '36a7d47b-c717-4647-99ca-59c8cd3cc71f'
```

Retrieves a hub site by hub site ID.

### Example 2
```powershell
PS C:\> Get-KshTenantHubSite -HubSiteId 'https://example.sharepoint.com/sites/hub'
```

Retrieves a hub site by hub site URL.

### Example 3
```powershell
PS C:\> Get-KshTenantHubSite
```

Retrieves all hub sites.

## PARAMETERS

### -HubSiteId
Specifies the hub site ID.

```yaml
Type: Guid
Parameter Sets: ParamSet1
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -HubSiteUrl
Specifies the hub site URL.

```yaml
Type: String
Parameter Sets: ParamSet2
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

### Karamem0.SharePoint.PowerShell.Models.HubSite

## NOTES

## RELATED LINKS
