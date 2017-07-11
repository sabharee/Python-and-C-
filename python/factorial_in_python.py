def factorial(n):
  if n!=1:
    z = n*factorial(n-1)
    return z
  else :
    return 1  

a=factorial(5)
print a