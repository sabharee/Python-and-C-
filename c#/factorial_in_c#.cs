using System;
public class Factorial
{
    public static void Main(string[] args)
    {
        int i, fact = 1, number;
        Console.WriteLine("Enter the number for factorial");
        number = int.Parse(Console.ReadLine());
        for (i = 1; i <= number; i++)
        {
            fact = fact * i;
        }
        Console.WriteLine("Factorial of"+number+"is:"+fact);
        Console.ReadLine();
    }
}

