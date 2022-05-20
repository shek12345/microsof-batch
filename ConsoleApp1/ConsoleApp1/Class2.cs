using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            if ((num % 5 == 0) && (num % 11 == 0)) 

            Console.WriteLine(" number is divisable by 5 and 11");
            Console.WriteLine("number is not divisable by 5 and 11");

            Console.ReadLine();
        }
    }
}
