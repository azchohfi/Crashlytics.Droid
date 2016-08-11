mvn 'dependency:copy-dependencies' '-DoutputDirectory=.'

$files = Dir *.aar
foreach($f in $files)
{
    $newFile = $f.Name -replace ('.aar', '.jar')
    Rename-Item $f temp.zip
    $tempFolder = "$env:TEMP\$($f.Name)"
    Expand-Archive temp.zip -DestinationPath $tempFolder -Force
    Remove-Item temp.zip
    Move-Item "$tempFolder\classes.jar" ".\$newfile" -Force
    Remove-Item -Recurse $tempFolder
}