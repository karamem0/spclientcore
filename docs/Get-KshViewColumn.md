---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Get-KshViewColumn

## SYNOPSIS
Retrieves view columns.

## SYNTAX

```
Get-KshViewColumn [-View] <View> [-NoEnumerate] [<CommonParameters>]
```

## DESCRIPTION
The Get-KshViewColumn cmdlet retrieves view columns of the specified view.

## EXAMPLES

### Example 1
```powershell
PS C:\> Get-KshViewColumn -View (Get-KshView -List (Get-KshList -ListTitle 'Announcements') -ViewId 'bae9f925-48d3-47f5-bb07-92927a82df7d')
```

Retrieves all view columns.

## PARAMETERS

### -NoEnumerate
If specified, suppresses to enumerate objects.

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

### -View
Specifies the view.

```yaml
Type: View
Parameter Sets: (All)
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

### None

## OUTPUTS

### System.String

## NOTES

## RELATED LINKS
