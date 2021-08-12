---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Get-KshSubscription

## SYNOPSIS
Retrieves one or more subscription.

## SYNTAX

### ParamSet1
```
Get-KshSubscription [-Identity] <Subscription> [<CommonParameters>]
```

### ParamSet2
```
Get-KshSubscription [-List] <List> [-SubscriptionId] <Guid> [<CommonParameters>]
```

### ParamSet3
```
Get-KshSubscription [-List] <List> [-NoEnumerate] [<CommonParameters>]
```

## DESCRIPTION
The Get-KshSubscription cmdlet retrieves subscriptions of the specified list.

## EXAMPLES

### Example 1
```powershell
PS C:\> Get-KshSubscription -List (Get-KshList -ListTitle 'Announcements') -SubscriptionId '40231e12-904f-430a-aa76-a6487076c36e'
```

Retrieves a subscription by subscription ID.

### Example 2
```powershell
PS C:\> Get-KshSubscription -List (Get-KshList -ListTitle 'Announcements')
```

Retrieves all subscriptions.

## PARAMETERS

### -Identity
Specifies the subscription.

```yaml
Type: Subscription
Parameter Sets: ParamSet1
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -List
Specifies the list.

```yaml
Type: List
Parameter Sets: ParamSet2, ParamSet3
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NoEnumerate
If specified, suppresses to enumerate objects.

```yaml
Type: SwitchParameter
Parameter Sets: ParamSet3
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubscriptionId
Specifies the subscription ID.

```yaml
Type: Guid
Parameter Sets: ParamSet2
Aliases:

Required: True
Position: 1
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
