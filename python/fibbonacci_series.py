number=int(raw_input("enter the fibonacci number:"))
i=0
print i
j=1
print j
count=2
if number<=0:
    print ("print only positive integes")
while count<number:
  z = i + j
  i = j
  j = z
  print z
  count += 1   
  