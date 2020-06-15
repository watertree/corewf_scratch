Remove-Item ../corewf -Recurse -Force -ErrorAction SilentlyContinue
New-Item ../corewf -ItemType Directory
Push-Location ../corewf
$Archive = 'System.Activities.zip'
Invoke-WebRequest https://www.myget.org/F/uipath-dev/api/v2/package/System.Activities/3.0.0-20200310-05 -OutFile $Archive
Expand-Archive $Archive
Remove-Item $Archive
Pop-Location