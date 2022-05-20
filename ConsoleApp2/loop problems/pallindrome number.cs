using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_work.loops_problem_home_work
{
    internal class pallindrome_number
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int a = Convert.ToInt32(Console.ReadLine());
            
            int rev = 0;
            while(a>0)
            {
                int digit = a % 10;
                rev = rev * 10 + digit;
                a = a / 10;

            }
            if (rev==a)
                Console.WriteLine("pallindrome number");
            else
                Console.WriteLine("not apallindrome number");
                
        }
    }
}
