$xml = [Xml] (Get-Content '..\PochtaAPI\PochtaAPI.csproj')
$version = [string] $xml.Project.PropertyGroup.Version
$version = $version.trim() #WTF powershell is junk
Write-Host "Version: $version"
Write-Host "##vso[task.setvariable variable=Version]$version"
Write-Host "##vso[build.updatebuildnumber]$version-$(Build.BuildId)"