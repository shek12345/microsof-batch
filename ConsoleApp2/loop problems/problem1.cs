using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_work.loops_problem_home_work
{
    internal class problem1
    // write a program to print even numbers from 121 to229 
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("even numbers");
            for (int i = 121; i <= 229; i++)
            {
                if (i % 2 == 0)

                    Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}