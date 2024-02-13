file = open('names.txt', 'w')
list = ['John\n', 'Louise\n', 'Clive\n', 'Sherry\n']
file.writelines(list)
file.close()

with open('names.txt', 'r') as f:
    for line in f.readlines():
        if 'o' in line:
            print(line)
