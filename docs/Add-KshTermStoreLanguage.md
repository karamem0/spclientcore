---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Add-KshTermStoreLanguage

## SYNOPSIS
Adds a term store language.

## SYNTAX

```
Add-KshTermStoreLanguage -Lcid <UInt32> [<CommonParameters>]
```

## DESCRIPTION
The Add-KshTermStoreLanguage cmdlet adds a language to the term store.

## EXAMPLES

### Example 1
```powershell
PS C:\> Add-KshTermStoreLanguage -Lcid 1033
```

Adds a language.

## PARAMETERS

### -Lcid
Specifies the locale ID.
For more information, see [reference](https://docs.microsoft.com/ja-jp/openspecs/windows_protocols/ms-lcid/70feba9f-294e-491e-b6eb-56532684c37f).

```yaml
Type: UInt32
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
