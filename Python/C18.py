sentence = input("I can analyse text for you. Please enter the text you would like me to review\n")
words = sentence.split(" ")
chars = sentence.replace(" ","")
average = len(chars) / len(words)
print(str(average))
fullstops = (len(sentence.split("."))-1)
print("Please find below the statistics for your text...\nNumber of words: " + str(len(words)) + "\nAverage word length: " + str(average) + "\nNumber of sentences: " + str(fullstops))

