---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Add-KshStorageEntity

## SYNOPSIS
Creates a new storage entity.

## SYNTAX

```
Add-KshStorageEntity -Key <String> -Value <String> [-Description <String>] [-Comment <String>]
 [<CommonParameters>]
```

## DESCRIPTION
The Add-KshStorageEntity cmdlet adds a new storage entity to the current site.
The site must be a tenant app catalog site or a site collection app catalog site.

## EXAMPLES

### Example 1
```powershell
PS C:\> Add-KshStorageEntity -Key 'Copyright' -Value 'Copyright (c) 2021 karamem0'
```

Creates a storage entity.

## PARAMETERS

### -Comment
Specifies the comment.

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

### -Key
Specifies the key.

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

### -Value
Specifies the value.

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
