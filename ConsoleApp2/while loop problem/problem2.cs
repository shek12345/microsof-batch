using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_work.while_loop_problem
   // all factor of given  number
{
    internal class problem2
    {
        static void Main(string[] args)
        {
            int count = 1;
            Console.WriteLine("Enter a number");
            int a = Convert.ToInt32(Console.ReadLine());
            while (a <= count)
            {
                if (a % count == 0)

                
                    Console.WriteLine(a);
                }
            }


        }
    }

