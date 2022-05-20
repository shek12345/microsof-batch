using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input any number");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("{0} is a positive number", num);
            }
            else if (num < 0)
            {

                Console.WriteLine("{0} is a negative number", num);

            }
            else

                Console.WriteLine("Entered no is zero");

            Console.Read();


    }

    }
}