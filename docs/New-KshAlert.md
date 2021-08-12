---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# New-KshAlert

## SYNOPSIS
Creates a new alert.

## SYNTAX

```
New-KshAlert [-AlertFrequency <AlertFrequency>] [-AlertTemplateName <String>] [-AlertTime <DateTime>]
 [-AlertType <AlertType>] [-AlwaysNotify <Boolean>] [-DeliveryChannels <AlertDeliveryChannel>]
 [-EventType <AlertEventType>] [-EventTypeBitmask <Int32>] [-Filter <String>] -List <List>
 [-ListItem <ListItem>]
 [-Properties <System.Collections.Generic.IReadOnlyDictionary`2[System.String,System.String]>]
 [-Status <AlertStatus>] [-Title <String>] -User <User> [<CommonParameters>]
```

## DESCRIPTION
The New-KshAlert cmdlet adds a new alert to the current site.

## EXAMPLES

### Example 1
```powershell
PS C:\> The New-KshAlert -AlertFrequency 'Immediate' -AlertType 'List' -List (Get-KshList -ListUrl '/sites/japan/hr/Announcements') -User (Get-KshUser -UserName 'admin@example.onmicrosoft.com')
```

Creates a new alert.

## PARAMETERS

### -AlertFrequency
Specifies the alert frequency.

```yaml
Type: AlertFrequency
Parameter Sets: (All)
Aliases:
Accepted values: Immediate, Daily, Weekly

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AlertTemplateName
Specifies the alert template name.

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

### -AlertTime
Specifies the alert time.

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

### -AlertType
Specifies the alert type.

```yaml
Type: AlertType
Parameter Sets: (All)
Aliases:
Accepted values: List, ListItem, Custom

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AlwaysNotify
Specifies whether to notify always.

```yaml
Type: Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeliveryChannels
Specifies the delivery channels.

```yaml
Type: AlertDeliveryChannel
Parameter Sets: (All)
Aliases:
Accepted values: Email, Sms

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EventType
Specifies the event type.

```yaml
Type: AlertEventType
Parameter Sets: (All)
Aliases:
Accepted values: AddObject, ModifyObject, DeleteObject, Discussion, All

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EventTypeBitmask
Specifies the event type as bitmask.

```yaml
Type: Int32
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Filter
Specifies the filter.

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

### -List
Specifies the list.

```yaml
Type: List
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ListItem
Specifies the list item.

```yaml
Type: ListItem
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Properties
Specifies the custom properties.

```yaml
Type: System.Collections.Generic.IReadOnlyDictionary`2[System.String,System.String]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Status
Specifies the status.

```yaml
Type: AlertStatus
Parameter Sets: (All)
Aliases:
Accepted values: On, Off, Error

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Title
Specifies the title.

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

### -User
Specifies the user.

```yaml
Type: User
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

### Karamem0.SharePoint.PowerShell.Models.Alert

## NOTES

## RELATED LINKS
