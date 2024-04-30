height = int(input("How tall would you like your steps?\n"))

i = int(1)
while i <= height:
    print((height - i) * " ",i * "#", sep='')
    i = i + 1