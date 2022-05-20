using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_work.while_loop_problem
{
    internal class problem7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int a = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=50;i++)
            {
                if (a % 2 == 0)
                {
                    Console.WriteLine("even number", +i);
                }
                else
                {
                    Console.WriteLine("odd number",i*i);
                }
                }

            }
        }
    }

