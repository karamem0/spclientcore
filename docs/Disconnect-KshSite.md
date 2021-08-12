---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Disconnect-KshSite

## SYNOPSIS
Disconnects from a site.

## SYNTAX

```
Disconnect-KshSite [[-Url] <Uri>] [<CommonParameters>]
```

## DESCRIPTION
The Disconnect-KshSite cmdlet deletes the connection to a site. The connection cache will also be deleted.

## EXAMPLES

### Example 1
```powershell
PS C:\> Disconnect-KshSite -Url 'https://example.sharepoint.com'
```

Deletes the connection cache for the URL.

### Example 1
```powershell
PS C:\> Disconnect-KshSite
```

Disconnects the current connection. The connection cache will also be deleted.

## PARAMETERS

### -Url
Specifies the URL.

```yaml
Type: Uri
Parameter Sets: (All)
Aliases:

Required: False
Position: 0
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### System.Uri

## OUTPUTS

### System.Void

## NOTES

## RELATED LINKS
