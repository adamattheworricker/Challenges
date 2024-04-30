def calculateChange(change):
    fifty = 0
    twenty = 0
    ten = 0
    five = 0
    one = 0
    while change >= 50:
        change = change - 50
        fifty +=1
    while change >= 20:
        change = change - 20
        twenty +=1
    while change >= 10:
        change = change - 10
        ten +=1
    while change >= 5:
        change = change - 5
        five +=1
    while change >= 1:
        change = change - 1
        one +=1
    return fifty, twenty, ten, five, one

cost = int(input("Please enter the cost of the item\n"))
paid = int(input("Please enter the amount paid\n"))
change = paid - cost

if cost >= paid:
    print("Customer hasn't paid enough to get any change")
else:
    fifty, twenty, ten, five, one = calculateChange(change)
    print("Give the following change: \n$50 x " + str(fifty) + "\n$20 x " + str(twenty) + "\n$10 x " + str(ten) + "\n$5 x " + str(five) + "\n$1 x " + str(one))
