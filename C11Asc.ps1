Write-Host "How tall would you like your steps?"
$height = Read-Host 
For($i=1;$i -le $height;$i++) {
    $step = "#" * $i
    Write-Host $step
    } 
