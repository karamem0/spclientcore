---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Update-KshAlert

## SYNOPSIS
Updates an alert.

## SYNTAX

```
Update-KshAlert [-Identity] <Alert> [-AlertFrequency <AlertFrequency>] [-AlertTime <DateTime>]
 [-AlwaysNotify <Boolean>] [-DeliveryChannels <AlertDeliveryChannel>] [-EventType <AlertEventType>]
 [-Filter <String>] [-Status <AlertStatus>] [-Title <String>] [-PassThru] [<CommonParameters>]
```

## DESCRIPTION
The Update-KshAlert cmdlet updates properties of the alert.

## EXAMPLES

### Example 1
```powershell
PS C:\> Update-KshAlert -Identity (Get-KshAlert -AlertId '8e22b48d-680a-493a-b3d1-b4607108a94a') -Status 'Off'
```

Updates property values of the alert.

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

### -Identity
Specifies the alert.

```yaml
Type: Alert
Parameter Sets: (All)
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByValue)
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

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Karamem0.SharePoint.PowerShell.Models.Alert

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.Alert

## NOTES

## RELATED LINKS
