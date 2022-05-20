using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_work.while_loop_problem
{
    //spy number or not
    internal class problem1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int a = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int mul = 1;
            while(a>0)
            {
                int digit = a % 10;
                sum = sum + digit;
                mul = mul * digit;
                    a = a / 10;

            }
            if (sum == mul)
            {
                Console.WriteLine("spy number");
            }
            else
            {
                Console.WriteLine("not a spy number");
            }
            }
        }
    }

