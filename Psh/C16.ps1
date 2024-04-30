Write-Host "Please enter your favorite sport; EPL, NFL, NBA, MLB or NHL"
$sport = Read-Host
$sport = $sport.ToUpper()
switch ($sport) {
    EPL {"Awesome, you're a soccer fan! The current EPL champions are Manchester City"}
    NFL {"Great, a football lover. The current Superbowl champions are the Kansas City Chiefs"}
    NBA {"Hey basketball fan! Current NBA champions are the Denver City Nuggets"}
    MLB {"Oh hi there baseball fanatic! The current MLB champions are the Texas Rangers"}
    NHL {"Howdy hockey fan! The current Stanley Cup holders are the Vegas Golden Knights"}
    Default {"Hmm, I dont know anything about that sport, please select another one"}
}
