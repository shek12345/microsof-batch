using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_work.loops_problem_home_work
    //number of itreation depends on number
    //a=1234
    //a=1+2+3+4
{
    internal class problem7

    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Enter a number");
            int a = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while(a>0)
            {
                int digit = a % 10;
                sum = sum + digit;
                a = a / 10;
                {
                    Console.WriteLine(sum);
                }
            }
           

        }
    }
}
