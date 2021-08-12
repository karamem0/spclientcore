---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Remove-KshStorageEntity

## SYNOPSIS
Removes a storage entity.

## SYNTAX

```
Remove-KshStorageEntity [-Key] <String> [<CommonParameters>]
```

## DESCRIPTION
The Remove-KshStorageEntity cmdlet removes a storage entity from the current site.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-KshStorageEntity -Key 'Copyright'
```

Removes a storage entity.

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

### None

## NOTES

## RELATED LINKS
