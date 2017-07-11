n=int(raw_input("enter the number to factorial of:"))
def factorial(n):
 if n!=1:
  z=n*factorial(n-1)
  return z
 else:
  return 1
s=factorial(n)
print s
