 class SwapNumber
    {
        private static object num1;

        static void Main(string[] args)
        {
            int number1, number2, tempnumber;
            Console.Write("Enter the First Number : ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the Second Number : ");
            number2 = int.Parse(Console.ReadLine());
            tempnumber = number1;
            number1 = number2;
            number2 = tempnumber;
            Console.Write("After Swapping : ");
            Console.Write("First Number : " + number1);
            Console.Write("Second Number : " + number2);
            Console.Read();
        }
    }