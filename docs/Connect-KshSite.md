---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Connect-KshSite

## SYNOPSIS
Connects to a site.

## SYNTAX

### ParamSet1
```
Connect-KshSite [-Url] <Uri> [-ClientId <String>] [-Authority <Uri>] [-UserMode] [<CommonParameters>]
```

### ParamSet2
```
Connect-KshSite [-Url] <Uri> -Credential <PSCredential> [-ClientId <String>] [-Authority <Uri>] [-UserMode]
 [<CommonParameters>]
```

### ParamSet3
```
Connect-KshSite [-Url] <Uri> -ClientId <String> [-Authority <Uri>] -CertificatePath <String>
 -CertificatePassword <SecureString> [<CommonParameters>]
```

### ParamSet4
```
Connect-KshSite [-Url] <Uri> [-ClientId <String>] [-Authority <Uri>] [-Cached] [<CommonParameters>]
```

### ParamSet5
```
Connect-KshSite [-Url] <Uri> -ClientId <String> -ClientSecret <String> [<CommonParameters>]
```

## DESCRIPTION
The Connect-KshSite cmdlet creates new connection to a site.

## EXAMPLES

### Example 1
```powershell
PS C:\> Connect-KshSite -Url 'https://example.sharepoint.com'
```

Connects to a site with device code.

### Example 2
```powershell
PS C:\> Connect-KshSite -Url 'https://example.sharepoint.com' -Credentials (Get-Credential)
```

Connects to a site with user name and password.

### Example 3
```powershell
PS C:\> Connect-KshSite -Url 'https://example.sharepoint.com' -ClientId 'e157e5b9-f2df-4417-991d-60546d11c21d' -CertificatePath 'C:\Certificate.pfx' -CertificatePassword 'P@ssw0rd'
```

Connects to a site with client certificate.

### Example 4
```powershell
PS C:\> Connect-KshSite -Url 'https://example.sharepoint.com' -Cached
```

Connects to a site with cached credentials.

### Example 5
```powershell
PS C:\> Connect-KshSite -Url 'https://example.sharepoint.com' -ClientId '0c51fcfc-73d3-4179-b541-c63ad7c0e36f' -ClientSecret 'MPKzUeOEK45gZOTx0yBTv9pAgQReINaYsY9CJnXsAFk='
```

Connects to a site with client secret.

## PARAMETERS

### -Authority
Specifies the authorization endpoint URL. This parameter is provided for some environment. (Germany, China, and US Government)

```yaml
Type: Uri
Parameter Sets: ParamSet1, ParamSet2, ParamSet3, ParamSet4
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Cached
If specified, uses the last login credentials.

```yaml
Type: SwitchParameter
Parameter Sets: ParamSet4
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CertificatePassword
Specifies the password for certificate file (.pfx).

```yaml
Type: SecureString
Parameter Sets: ParamSet3
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CertificatePath
Specifies the path which located certificate file (.pfx).

```yaml
Type: String
Parameter Sets: ParamSet3
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ClientId
Specifies the app ID of Azure AD app or SharePoint add-in.

```yaml
Type: String
Parameter Sets: ParamSet1, ParamSet2, ParamSet4
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

```yaml
Type: String
Parameter Sets: ParamSet3, ParamSet5
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ClientSecret
Specifies the app secret.

```yaml
Type: String
Parameter Sets: ParamSet5
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Credential
Specifies the credentials (user name and password) of Office 365.

```yaml
Type: PSCredential
Parameter Sets: ParamSet2
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Url
Specifies the site URL.

```yaml
Type: Uri
Parameter Sets: (All)
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -UserMode
If specified, connects with the user mode. (without admin consent)

```yaml
Type: SwitchParameter
Parameter Sets: ParamSet1, ParamSet2
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

### System.Uri

## OUTPUTS

### None

## NOTES

## RELATED LINKS
