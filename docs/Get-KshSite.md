---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Get-KshSite

## SYNOPSIS
Retrieves one or more sites.

## SYNTAX

### ParamSet1
```
Get-KshSite [-Identity] <Site> [<CommonParameters>]
```

### ParamSet2
```
Get-KshSite [-SiteCollection] <SiteCollection> [<CommonParameters>]
```

### ParamSet3
```
Get-KshSite [-List] <List> [<CommonParameters>]
```

### ParamSet4
```
Get-KshSite [-SiteId] <Guid> [<CommonParameters>]
```

### ParamSet5
```
Get-KshSite [-SiteUrl] <Uri> [<CommonParameters>]
```

### ParamSet6
```
Get-KshSite [-NoEnumerate] [<CommonParameters>]
```

## DESCRIPTION
The Get-KshSite cmdlet retrieves sub sites of the current site.
In order to retrive a site of different site collections, invoke the Connect-KshSite cmdlet.

## EXAMPLES

### Example 1
```powershell
PS C:\> Get-KshSite -SiteCollection (Get-KshCurrentSiteCollection)
```

Retrieves a root site of the site collection.

### Example 2
```powershell
PS C:\> Get-KshSite -List (Get-KshList -ListTitle 'Announcements')
```

Retrieves a parent site of the list.

### Example 3
```powershell
PS C:\> Get-KshSite -SiteId 'd298e576-6985-4119-9796-050b9f371872'
```

Retrieves a site by site ID.

### Example 4
```powershell
PS C:\> Get-KshSite -SiteUrl '/sites/japan/hr'
```

Retrieves a site by site URL.

### Example 5
```powershell
PS C:\> Get-KshSite
```

Retrieves all sites.

## PARAMETERS

### -Identity
Specifies the site.

```yaml
Type: Site
Parameter Sets: ParamSet1
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -List
Specifies the list.

```yaml
Type: List
Parameter Sets: ParamSet3
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -NoEnumerate
If specified, suppresses to enumerate objects.

```yaml
Type: SwitchParameter
Parameter Sets: ParamSet6
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SiteCollection
Specifies the site collection.

```yaml
Type: SiteCollection
Parameter Sets: ParamSet2
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -SiteId
Specifies the site ID.

```yaml
Type: Guid
Parameter Sets: ParamSet4
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SiteUrl
Specifies the site URL.

```yaml
Type: Uri
Parameter Sets: ParamSet5
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

### Karamem0.SharePoint.PowerShell.Models.Site

### Karamem0.SharePoint.PowerShell.Models.SiteCollection

### Karamem0.SharePoint.PowerShell.Models.List

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.Site

## NOTES

## RELATED LINKS
