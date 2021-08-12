---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Remove-KshTermStoreLanguage

## SYNOPSIS
Removes a term store language.

## SYNTAX

```
Remove-KshTermStoreLanguage [-Lcid] <UInt32> [<CommonParameters>]
```

## DESCRIPTION
The Remove-KshTermStoreLanguage cmdlet removes a language from the term store.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-KshTermStoreLanguage -Lcid 1033
```

Removes a language.

## PARAMETERS

### -Lcid
Specifies the locale ID.
For more information, see [reference](https://docs.microsoft.com/ja-jp/openspecs/windows_protocols/ms-lcid/70feba9f-294e-491e-b6eb-56532684c37f).

```yaml
Type: UInt32
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
