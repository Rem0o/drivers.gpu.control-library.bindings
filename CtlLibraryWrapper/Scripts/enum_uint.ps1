
$currentDirectory = Get-Location

Write-Output "Replacing 0x80000000 in folder $currentDirectory...";

Get-ChildItem -Path "Bindings" -Filter *.cs -Recurse | ForEach-Object {
    $content = Get-Content $_.FullName;
    $updatedContent = $content -replace '0x80000000', '-2147483648';
    Set-Content -Path $_.FullName -Value $updatedContent;
}