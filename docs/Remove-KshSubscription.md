---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Remove-KshSubscription

## SYNOPSIS
Removes a subscription.

## SYNTAX

```
Remove-KshSubscription [-Identity] <Subscription> [<CommonParameters>]
```

## DESCRIPTION
The Remove-KshSubscription cmdlet removes a subscription from the list.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-KshSubscription -Identity (Get-KshSubscription -List (Get-KshList -ListTitle 'Announcements') -SubscriptionId '40231e12-904f-430a-aa76-a6487076c36e')
```

Removes a subscription.

## PARAMETERS

### -Identity
Specifies the subscription.

```yaml
Type: Subscription
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

### Karamem0.SharePoint.PowerShell.Models.Subscription

## OUTPUTS

### None

## NOTES

## RELATED LINKS
