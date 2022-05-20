using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_work2
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("take a year");
            int year = Convert.ToInt32(Console.ReadLine());
             string msg = year % 4 == 0 ? "leap year" : "not a leap year" ;
            Console.WriteLine();
        }
    }
}
