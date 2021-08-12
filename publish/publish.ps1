$PROJECT_PATH = "$PSScriptRoot/../source/SPClientCore/SPClientCore.csproj"
$SOURCE_MODULE_PATH = "$PSScriptRoot/../source/SPClientCore/bin/Debug/netstandard2.0/publish/SPClientCore.psd1"
$SCRIPT_MODULE_PATH = "$PSScriptRoot/../scripts/SPClientCore.Tests.psd1"
$OUTPUT_PATH = "$PSScriptRoot/../source/SPClientCore.Tests/bin/Debug/net5.0/SPClientCore.Tests.config.json"
$PARAMS = @{
    Url = 'https://karamem0.sharepoint.com/sites/spclientcore'
    UserName = 'sharepointadmin'
    Password = 'G4tuX5H5gq*,'
    DomainName = 'karamem0.com'
}

dotnet publish $PROJECT_PATH --nologo --verbosity quiet

Import-Module -Name $SOURCE_MODULE_PATH
Import-Module -Name $SCRIPT_MODULE_PATH

Uninstall-TestSite @PARAMS
Start-Sleep -Seconds 30
Install-TestSite @PARAMS | ConvertTo-Json -Compress | Out-File -FilePath $OUTPUT_PATH -Encoding 'UTF8'
