---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Update-KshTenantHubSite

## SYNOPSIS
Updates a hub site.

## SYNTAX

```
Update-KshTenantHubSite [-Identity] <HubSite> [-Description <String>] [-EnablePermissionsSync <Boolean>]
 [-HideNameInNavigation <Boolean>] [-LogoUrl <String>] [-ParentHubSiteId <Guid>] [-Title <String>] [-PassThru]
 [<CommonParameters>]
```

## DESCRIPTION
The Update-KshTenantHubSite cmdlet updates properties of the hub site.
This cmdlet can be used only when connected to the SharePoint admin center.

## EXAMPLES

### Example 1
```powershell
PS C:\> Update-KshTenantHubSite -Identity (Get-KshTenantHubSite -HubSiteUrl 'https://example.sharepoint.com/sites/hub') -Title 'Hub site'
```

Updates property values of the hub site.

## PARAMETERS

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

### -EnablePermissionsSync
Specifies whether to enable permissions sync.

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

### -HideNameInNavigation
Specifies whether to hide name in navigation.

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

### -LogoUrl
Specifies the logo URL.

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

### -ParentHubSiteId
Specifies the parent hub site ID.

```yaml
Type: Guid
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

### Karamem0.SharePoint.PowerShell.Models.HubSite

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.HubSite

## NOTES

## RELATED LINKS
