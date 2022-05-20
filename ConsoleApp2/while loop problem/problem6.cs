using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_work.while_loop_problem
//harshad number
{
    internal class problem6

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int a = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int digit = 0;
            while (a > 0)
            {
                digit = a % 10;
                sum = sum + digit;
                a = a / 10;
                if (a % sum == 0)
                {
                    Console.WriteLine("harshad number");
                }
                else
                {
                    Console.WriteLine("not a harshad number");
                }
                }
            }
        }
    }

