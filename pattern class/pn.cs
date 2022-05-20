using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_class
{
    internal class pn
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("Enter avalue of a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter avalue of b");
            int b = Convert.ToInt32(Console.ReadLine());
            int result = 1;
            for (int i = 1; i <= b; i++)
            {
                result = result * a;
                {
                    Console.WriteLine( result) ;

                }


            }
        }
    }
}