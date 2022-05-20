using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_work.loops_problem_home_work
{
    internal class neonnumber

    {
        static void Main(string[] args)
        {
          
            
            Console.WriteLine("enter a number");
            int a = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int squre = a * a;
            while(squre>0)
            {
                int digit = squre % 10;
                sum = sum + digit;
                squre = squre / 10;
            }
            if(sum==a)
                Console.WriteLine("neon number");
            else
                Console.WriteLine("not a neon number");

        }
    }
}
