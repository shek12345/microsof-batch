using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_work.loops_problem_home_work
{
    internal class problem_amstrong

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int a = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int x = a;
            while(a>0)
            {
                int digit = a % 10;
                sum = sum + digit * digit * digit;
                a = a / 10;

            }
            if(sum==x)
                Console.WriteLine("armstrong number");
            else
                Console.WriteLine("not a armstrong number");


        }
    }
}
