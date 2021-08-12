---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Remove-KshTenantSiteCollection

## SYNOPSIS
Removes a site collection.

## SYNTAX

### ParamSet1
```
Remove-KshTenantSiteCollection [-Identity] <TenantSiteCollection> [<CommonParameters>]
```

### ParamSet2
```
Remove-KshTenantSiteCollection [-Identity] <TenantSiteCollection> [-NoWait] [<CommonParameters>]
```

## DESCRIPTION
The Remove-KshTenantSiteCollection cmdlet removes a deleted site collection.
This cmdlet can be used only when connected to the SharePoint admin center.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-KshTenantSiteCollection -Identity (Get-KshTenantSiteCollection -SiteCollectionUrl 'https://example.sharepoint.com/sites/hub')
```

Removes a site collection.

## PARAMETERS

### -Identity
Specifies the site collection.

```yaml
Type: TenantSiteCollection
Parameter Sets: (All)
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -NoWait
If specified, continue executing script immediately.

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

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Karamem0.SharePoint.PowerShell.Models.TenantSiteCollection

## OUTPUTS

### None

## NOTES

## RELATED LINKS
