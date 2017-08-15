namespace Program
{
    class leapyear
    {
        static void Main(string[] args)
        {
            leapyear obj = new leapyear();
            obj.readdata();
            obj.leap();
        }
        int i;
        public void readdata()
        {
            Console.WriteLine("Enter the Year in Four Digits : ");
            i = Convert.ToInt32(Console.ReadLine());
        }
        public void leap()
        {
            if ((i % 4 == 0 && i % 100 != 0) || (i % 400 == 0))
            {
                Console.WriteLine("{0} is a Leap Year", i);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("{0} is not a Leap Year", i);
                Console.ReadLine();
            }
          
        }
    }
}