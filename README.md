# Functions Applying Recursivity

##Palindromic words
A word is palindrome if the word reads the same forward as it does backward. This means that the meaning does not change. 

Example: the word “level”. Because we can do an inversion of the word and the meaning will be the same. 

In the project, there is a method that receive a string and the function of the method is to compare if the first half of the word is the same that the other half. 

##Prime numbers
To resolve this exercise in a recursive way we will need to parameters for our method “Prim”. The first parameter will be the number, and the second one will be the divisor. In this case, the method will do successive divisions. 
if (y == 1)
If the condition above is met, we will return true. 

if (x % y == 0)
If the condition above is met, we will return false because it means that the number can be divide for other numbers different of 1 and the same number entered. 

If the division is not exact we will decrease the divisor 1 number so we can continue with the successive divisions until one of the conditions can be met. 

Also, in the project it is a method with “x” as parameter (x is the number that will be evaluated). This method calls the “Prim” function so we can return the result. 
