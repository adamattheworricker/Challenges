shape = input ("I can help you calculate the area of a square or a triangle. Which would you like me to do? Please enter square or triangle\n")
shape = shape.lower()

length = int(input ("What is the length of the object in centimetres?\n"))
height = int(input ("What is the height of the object in centimetres?\n"))

if (shape == "triangle"):
    area = length * height / 2
    print("The area of the triangle is %i centimetres squared" %area)
elif (shape == "square"):
    area = length * height
    print("The area of the square is %i centimetres squared" %area)
else:
    print("You did not select a valid shape. Try again!")
