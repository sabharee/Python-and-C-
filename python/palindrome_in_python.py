str =raw_input("enter the string:")

def palindrome(i,number):   
  while i<len(str):
   if str[i]==str[number]:     
     i=i+1
     number=number-1
     j=1+palindrome(i,number)
     return j     
   else:
     return 1   
  return 1 

k=palindrome(0,-1)-1
if k==len(str):    
  print "it is a palindrome"
else:
  print "it is not palindrome" 


     


    
