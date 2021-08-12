---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# New-KshTenantApp

## SYNOPSIS
Creates a new tenant app.

## SYNTAX

```
New-KshTenantApp -Content <Stream> -FileName <String> [-Overwrite <Boolean>] [<CommonParameters>]
```

## DESCRIPTION
The New-KshTenantApp cmdlet adds a new app to the tenant app catalog.

## EXAMPLES

### Example 1
```powershell
PS C:\> New-KshTenantApp -Content [System.IO.File]::OpenRead('C:\app.sppkg') -FileName 'app.sppkg'
```

Creates a new app.

## PARAMETERS

### -Content
Specifies the contents.

```yaml
Type: Stream
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FileName
Specifies the file name.

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

### -Overwrite
If specified, overwrites the existing file.

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

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### None

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.App

## NOTES

## RELATED LINKS
