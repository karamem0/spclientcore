---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# New-KshDocumentSet

## SYNOPSIS
Creates a new document set.

## SYNTAX

```
New-KshDocumentSet -Folder <Folder> -Name <String> -ContentType <ContentType> [<CommonParameters>]
```

## DESCRIPTION
The New-KshDocumentSet cmdlet adds a new document set to the speficied folder.

## EXAMPLES

### Example 1
```powershell
PS C:\> New-KshDocumentSet -Folder (Get-KshFolder -FolderUrl '/sites/japan/hr/Shared%20Documents') -Name 'Design Documents' -ContentType (Get-KshContentType -List (Get-KshList -ListUrl '/sites/japan/hr/Shared%20Documents' -ContentTypeId '0x0120D5200014BC33BECFD5C340922C6D6CECC7830D008BB6866D789F8E48B1DFD8CCF0B26886'))
```

Creates a new document set.

## PARAMETERS

### -ContentType
Speficies the content type.

```yaml
Type: ContentType
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Folder
Speficies the folder.

```yaml
Type: Folder
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
Speficies the name.

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

### None

## OUTPUTS

### System.String

## NOTES

## RELATED LINKS
