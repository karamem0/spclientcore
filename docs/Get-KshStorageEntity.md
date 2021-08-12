---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Get-KshStorageEntity

## SYNOPSIS
Retrieves a storage entity.

## SYNTAX

```
Get-KshStorageEntity [-Key] <String> [<CommonParameters>]
```

## DESCRIPTION
The Get-KshStorageEntity cmdlet retrieves a storage entitiy of the current site.

## EXAMPLES

### Example 1
```powershell
PS C:\> Get-KshStorageEntity -Key 'Copyright'
```

Retrieves a storage entity.

## PARAMETERS

### -Key
Specifies the key.

```yaml
Type: String
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

### Karamem0.SharePoint.PowerShell.Models.StorageEntity

## NOTES

## RELATED LINKS
