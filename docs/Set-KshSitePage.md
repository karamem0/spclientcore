---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Set-KshSitePage

## SYNOPSIS
Changes a site page properties.

## SYNTAX

### ParamSet1
```
Set-KshSitePage [-List] <List> [-PageName] <String> [-PageLayoutType <SitePageLayoutType>] [-Title <String>]
 [<CommonParameters>]
```

### ParamSet2
```
Set-KshSitePage [-PageName] <String> [-PageLayoutType <SitePageLayoutType>] [-Title <String>]
 [<CommonParameters>]
```

## DESCRIPTION
The Set-KshSitePage cmdlet updates properties of the site page.

## EXAMPLES

### Example 1
```powershell
PS C:\> Set-KshSitePage -PageName 'News' -PageLayoutType 'Home'
```

Changes a site page properties.

## PARAMETERS

### -List
Specifies the list.

```yaml
Type: List
Parameter Sets: ParamSet1
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PageLayoutType
Specifies the page layout type.

```yaml
Type: SitePageLayoutType
Parameter Sets: (All)
Aliases:
Accepted values: Article, Home, SingleWebPartAppPage, RepostPage, HeaderlessSearchResults, Spaces

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PageName
Specifies the page name.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: True
Position: 1
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

### Karamem0.SharePoint.PowerShell.Models.List

## OUTPUTS

### None

## NOTES

## RELATED LINKS
