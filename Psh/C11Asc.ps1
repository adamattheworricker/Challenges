Write-Host "How tall would you like your steps?"
$height = Read-Host
For($i=1;$i -le $height;$i++) {
    $space = " " * ($height-$i)
    $step = "#" * $i
    Write-Host $space $step
    } 
