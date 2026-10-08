Get-ChildItem "$PSScriptRoot\src" -Directory -Recurse |
    Where-Object { $_.Name -in @('bin', 'obj') } |
    Remove-Item -Recurse -Force
