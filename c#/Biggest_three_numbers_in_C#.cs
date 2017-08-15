
namespace practice1
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1, num2, num3;
            
            Console.Write("Enter the 1st number :");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the  2nd number :");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the 3rd  number :");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine(num1+" is Biggest number");
                Console.ReadLine();
            }
            else if (num2 > num3 && num2 > num1)
            {
                Console.WriteLine(num2 + " is Biggest number");
                 Console.ReadLine();
            }
            else
            {
                Console.WriteLine(num3 + " is Biggest number");
                Console.ReadLine();
            }
        }

    }
}