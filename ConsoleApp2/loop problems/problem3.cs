using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_work.loops_problem_home_work
{
    internal class problem3
        //fing gcd and lcm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number b");
            int b = Convert.ToInt32(Console.ReadLine());
            int g = 1;
            for(int i=2;i<=a&&i<=b;i++)
            {
             if  ( a % i == 0 && b % i == 0)
                g = i;
            }
        }
    }
}
