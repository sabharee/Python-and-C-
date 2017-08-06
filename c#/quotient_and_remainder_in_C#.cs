 class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter to find quotient or remainder:");
            var s =Console.ReadLine();
            if (s == "quotient")
            {
                Console.WriteLine("enter the first number :");
                var i = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("enter the second number :");
                var j = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Quotient of 2 numbet is:",i / j);
                Console.ReadLine();
            }
            else if (s == "remainder")
            {
                Console.WriteLine("enter the first number :");
                var i = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("enter the second number :");
                var j = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Remainder of 2 numbet is:",i % j);
                Console.ReadLine();
            }
            else
            {
            }
            
        }
    }