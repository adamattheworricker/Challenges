sport = input("Please enter your favorite sport; EPL, NFL, NBA, MLB or NHL\n")
sport = sport.upper()
if sport == 'EPL':
    print("Awesome, you're a soccer fan! The current EPL champions are Manchester City")
elif sport == 'NFL':
    print("Great, a football lover. The current Superbowl champions are the Kansas City Chiefs")
elif sport == 'NBA':
    print("Hey basketball fan! Current NBA champions are the Denver City Nuggets")
elif sport == 'MLB':
    print("Oh hi there baseball fanatic! The current MLB champions are the Texas Rangers")
elif sport == 'NHL':
    print("Howdy hockey fan! The current Stanley Cup holders are the Vegas Golden Knights")
else:
    print("Hmm, I dont know anything about that sport, please select another one")

