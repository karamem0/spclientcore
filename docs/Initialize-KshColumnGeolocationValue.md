---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Initialize-KshColumnGeolocationValue

## SYNOPSIS
Creates a geolocation column value.

## SYNTAX

```
Initialize-KshColumnGeolocationValue [-Altitude <Double>] -Latitude <Double> -Longitude <Double>
 [-Measure <Double>] [<CommonParameters>]
```

## DESCRIPTION
The Initialize-KshColumnGeolocationValue cmdlet creates a new geolocation column value from latitude and longitude.
This is provided for the [New-KshListItem](New-KshListItem.md) cmdlet and [Update-KshListItem](Update-KshListItem.md) cmdlet.

## EXAMPLES

### Example 1
```powershell
PS C:\> Initialize-KshColumnGeolocationValue -Latitude 10 -Longitude 10
```

Creates a new geolocation column value.

## PARAMETERS

### -Altitude
Specifies the altitude.

```yaml
Type: Double
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Latitude
Specifies the latitude.

```yaml
Type: Double
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Longitude
Specifies the longitude.

```yaml
Type: Double
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Measure
Specifies the measure.

```yaml
Type: Double
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

### None

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.ColumnGeolocationValue

## NOTES

## RELATED LINKS
