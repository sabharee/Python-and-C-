class ASCII
    {
        static void Main(string[] args)
        {
            string s;
            Console.WriteLine(" Enter your sentence: ");
            s = Console.ReadLine();
            foreach (char c in s)
            {
                Console.WriteLine((int)c);
                Console.ReadLine();
            }
        }
    }