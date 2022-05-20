using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number 1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number 2");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number 3");
            int num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2 && num1 > num3) ;
            else if (num2 > num1 && num2 > num3) ;
            Console.WriteLine("largest value {0} {1} {2} is {3}",num1,num2,num3);
            Console.ReadLine();


        }
    }
}
