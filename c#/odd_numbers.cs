using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i < num; i++)
            {
                Console.WriteLine(i++);
                {

                    Console.ReadLine();
                }
            }
        }
    }
}
