using System;
namespace palindrome
{
    class palindrome_Program
    {
        static void Main(string[] args)
        {
            string number,revs="";
            Console.WriteLine("Enter the string");
            number = Console.ReadLine();
            for (int i = number.Length-1; i >=0; i--)
            {
                revs += number[i].ToString();
            }
            if (revs == number)
            {
                Console.WriteLine("String is Palindrome", number, revs);
            }
            else
            {
                Console.WriteLine("String is not Palindrome", number, revs);
            }
            Console.ReadKey();
        }
    }
}