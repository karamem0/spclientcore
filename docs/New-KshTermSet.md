---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# New-KshTermSet

## SYNOPSIS
Creates a new term set.

## SYNTAX

```
New-KshTermSet [-TermGroup] <TermGroup> [-Id <Guid>] -Lcid <UInt32> -Name <String> [<CommonParameters>]
```

## DESCRIPTION
The New-KshTermSet cmdlet adds a new term set to the term group.

## EXAMPLES

### Example 1
```powershell
PS C:\> New-KshTermSet -TermGroup (Get-KshTermGroup -TermGroupName 'Company') -Name 'Department' -Lcid 1033
```

Creates a new term set.

## PARAMETERS

### -Id
Specifies the ID.

```yaml
Type: Guid
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

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

### -Name
Specifies the name.

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

### -TermGroup
Specifies the term group.

```yaml
Type: TermGroup
Parameter Sets: (All)
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Karamem0.SharePoint.PowerShell.Models.TermGroup

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.TermSet

## NOTES

## RELATED LINKS
