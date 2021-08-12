---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Update-KshSubscription

## SYNOPSIS
Updates a subscription.

## SYNTAX

```
Update-KshSubscription [-Identity] <Subscription> [-ExpirationDateTime <DateTime>] [-NotificationUrl <String>]
 [-PassThru] [<CommonParameters>]
```

## DESCRIPTION
The Update-KshSubscription cmdlet updates properties of the subscription.

## EXAMPLES

### Example 1
```powershell
PS C:\> Update-KshSubscription -Identity (Get-KshSubscription -List (Get-KshList -ListTitle 'Announcements') -SubscriptionId '40231e12-904f-430a-aa76-a6487076c36e') -ExpirationDateTime [System.DateTime]::UtcNow.AddDays(1)
```

Updates property values of the subscription.

## PARAMETERS

### -ExpirationDateTime
Specifies the expiration date/time.

```yaml
Type: DateTime
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

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

### -NotificationUrl
Specifies the notification URL.

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

### -PassThru
If specified, returns the updated object.

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

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Karamem0.SharePoint.PowerShell.Models.Subscription

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.Subscription

## NOTES

## RELATED LINKS
