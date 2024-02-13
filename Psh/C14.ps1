Write-Host 'I can help you calculate the area of a square or a triangle. Which would you like me to do? Please enter square or triangle'
$shape = Read-Host
 
Write-Host 'What is the length in centimeters?'
[INT]$length = Read-Host
Write-Host 'What is the height in centimeters?'
[INT]$height = Read-Host
 
If ($shape -eq "square") {
    [INT]$area = $length*$height
    Write-Host "The area of the square is $area centimeters squared"
    }
    ElseIf ($shape -eq "triangle") {
    [INT]$area = $length*$height*0.5
    Write-Host "The area of the triangle is $area centimeters squared"
    }
    Else {
    Write-Host 'You did not select a valid shape.' -ForegroundColor Yellow
    }

