---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Unlock-KshTenantSiteCollection

## SYNOPSIS
Unlocks a site collection.

## SYNTAX

### ParamSet1
```
Unlock-KshTenantSiteCollection [-Identity] <TenantSiteCollection> [-PassThru] [<CommonParameters>]
```

### ParamSet2
```
Unlock-KshTenantSiteCollection [-Identity] <TenantSiteCollection> [-NoWait] [<CommonParameters>]
```

## DESCRIPTION
The Unlock-KshTenantSiteCollection cmdlet sets lock state of a site collection to Unlock.
This cmdlet can be used only when connected to the SharePoint admin center.

## EXAMPLES

### Example 1
```powershell
PS C:\> Unlock-KshTenantSiteCollection -Identity (Get-KshTenantSiteCollection -SiteCollectionUrl 'https://example.sharepoint.com/sites/hub')
```

Unlocks the site collection.

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

### -PassThru
If specified, returns the updated object.

```yaml
Type: SwitchParameter
Parameter Sets: ParamSet1
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

### Karamem0.SharePoint.PowerShell.Models.TenantSiteCollection

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.TenantSiteCollection

## NOTES

## RELATED LINKS
