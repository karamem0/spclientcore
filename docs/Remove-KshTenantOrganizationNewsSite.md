---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Remove-KshTenantOrganizationNewsSite

## SYNOPSIS
Removes an organization news site.

## SYNTAX

```
Remove-KshTenantOrganizationNewsSite -Url <String> [<CommonParameters>]
```

## DESCRIPTION
The Remove-KshTenantOrganizationNewsSite cmdlet removes an organization news site.
This cmdlet can be used only when connected to the SharePoint admin center.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-KshTenantOrganizationNewsSite -Url 'https://example.sharepoint.com/sites/news'
```

Removes a organization news site.

## PARAMETERS

### -Url
Specifies the URL.

```yaml
Type: String
Parameter Sets: (All)
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

### None

## OUTPUTS

### None

## NOTES

## RELATED LINKS
