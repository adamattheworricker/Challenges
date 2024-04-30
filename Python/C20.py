import random
computerNumber = random.randint(1,100)
userNumber = 0
while True:
    userNumber = int(input("Please select  number between 1 and 100\n"))
    if (userNumber > computerNumber):
        print("Wrong, guess lower!")
    elif (userNumber < computerNumber):
        print("Wrong, guess higher!")
    elif (userNumber == computerNumber):
        print("You win, you guessed correctly! The computer's number was %i" %computerNumber)
        break
