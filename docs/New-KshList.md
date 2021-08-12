---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# New-KshList

## SYNOPSIS
Creates a new list.

## SYNTAX

```
New-KshList [-Description <String>] [-QuickLaunchOption <QuickLaunchOptions>] [-ServerRelativeUrl <String>]
 [-Template <ListTemplateType>] -Title <String> [<CommonParameters>]
```

## DESCRIPTION
The New-KshList cmdlet adds a new list to the current site.

## EXAMPLES

### Example 1
```powershell
PS C:\> New-KshList -Description 'Check the updates' -QuickLaunchOption $true -ServerRelativeUrl 'Lists/Announcements' -TemplateType 'Announcements' -Title 'Announcements'
```

Creates a new list.

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

### -QuickLaunchOption
Specifies the quick launch options.

```yaml
Type: QuickLaunchOptions
Parameter Sets: (All)
Aliases:
Accepted values: Off, On, DefaultValue

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ServerRelativeUrl
Specifies the site relative URL.

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

### -Template
Specifies the list template ID.

```yaml
Type: ListTemplateType
Parameter Sets: (All)
Aliases:
Accepted values: NoListTemplate, GenericList, DocumentLibrary, Survey, Links, Announcements, Contacts, Events, Tasks, DiscussionBoard, PictureLibrary, DataSources, XmlForm, NoCodeWorkflows, WorkflowProcess, WebPageLibrary, CustomGrid, WorkflowHistory, GanttTasks, IssuesTracking, InvalidType

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

### Karamem0.SharePoint.PowerShell.Models.List

## NOTES

## RELATED LINKS
