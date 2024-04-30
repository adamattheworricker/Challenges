import random
computerNumber = random.randint(1,100)
userNumber = 0
userAttempts = 0
while True:
    userNumber = int(input("Please select  number between 1 and 100\n"))
    if (userNumber > computerNumber):
        userAttempts += 1
        print("Wrong, guess lower!")
    elif (userNumber < computerNumber):
        userAttempts += 1
        print("Wrong, guess higher!")
    elif (userNumber == computerNumber):
        userAttempts += 1
        print("You win, you guessed correctly in %i attempts! The computer's number was %s" %(userAttempts,computerNumber))
        break
