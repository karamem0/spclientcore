---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Restore-KshTenantDeletedSiteCollection

## SYNOPSIS
Restore a deleted site collection.

## SYNTAX

### ParamSet1
```
Restore-KshTenantDeletedSiteCollection [-Identity] <TenantDeletedSiteCollection> [<CommonParameters>]
```

### ParamSet2
```
Restore-KshTenantDeletedSiteCollection [-Identity] <TenantDeletedSiteCollection> [-NoWait] [<CommonParameters>]
```

## DESCRIPTION
The Restore-KshTenantDeletedSiteCollection cmdlet marks an deleted site collection as active.
This cmdlet can be used only when connected to the SharePoint admin center.

## EXAMPLES

### Example 1
```powershell
PS C:\> Restore-KshTenantDeletedSiteCollection -Identity (Get-KshTenantDeletedSiteCollection -SiteCollectionUrl 'https://example.sharepoint.com/sites/hub')
```

Restores a deleted site collection.

## PARAMETERS

### -Identity
Specifies the deleted site collection.

```yaml
Type: TenantDeletedSiteCollection
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

### Karamem0.SharePoint.PowerShell.Models.TenantDeletedSiteCollection

## OUTPUTS

### None

## NOTES

## RELATED LINKS
