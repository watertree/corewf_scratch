Remove-Item ../corewf -Recurse -Force -ErrorAction SilentlyContinue
Push-Location ../
git clone https://github.com/UIPath-Open/corewf.git
$csprojPath = (Resolve-Path 'corewf/src/CoreWf/System.Activities.csproj').Path
$csproj = Get-Content $csprojPath
$csproj = $csproj -replace "netcoreapp3.1;", "" -join "`r`n"
#$csproj = $csproj -replace "Exec Command", "Message Text"
[IO.File]::WriteAllText($csprojPath, $csproj)
Set-Location corewf/src
dotnet build ./System.Activities.sln
Pop-Location