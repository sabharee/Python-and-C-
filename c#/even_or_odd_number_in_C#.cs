class evenodd
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            var i = Convert.ToInt32(Console.ReadLine());
            if (i%2 == 0)
            {
                Console.WriteLine("Given Number is Even Nmuber");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Given Number is Odd Number");
                Console.ReadLine();
            }
        }
    }