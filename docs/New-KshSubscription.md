---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# New-KshSubscription

## SYNOPSIS
Creates a new subscription.

## SYNTAX

```
New-KshSubscription [-List] <List> [-ClientState <String>] -ExpirationDateTime <DateTime>
 -NotificationUrl <String> [<CommonParameters>]
```

## DESCRIPTION
The New-KshSubscription cmdlet adds a new subscription to the specified list.

## EXAMPLES

### Example 1
```powershell
PS C:\> New-KshSubscription -List (Get-KshList -ListTitle 'Announcements') -ExpirationDateTime [System.DateTime]::UtcNow.AddDays(1) -NotificationUrl 'https://www.example.com'
```

Creates a new subscription.

## PARAMETERS

### -ClientState
Specifies the client state.

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

### -ExpirationDateTime
Specifies the expiration date/time.

```yaml
Type: DateTime
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -List
Specifies the list.

```yaml
Type: List
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

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Karamem0.SharePoint.PowerShell.Models.List

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.Subscription

## NOTES

## RELATED LINKS
