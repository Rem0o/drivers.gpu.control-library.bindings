
$currentDirectory = Get-Location

Write-Output "Adding uint to every enum in folder $currentDirectory...";


Get-ChildItem -Path "Bindings" -Filter *.cs -Recurse | ForEach-Object {
    $content = Get-Content $_.FullName;
    $updatedContent = $content -replace 'public enum (\w+)', 'public enum $1 : uint';
    $duplicateCheck = $updatedContent -replace 'uint : uint', 'uint';
    Set-Content -Path $_.FullName -Value $duplicateCheck;
}