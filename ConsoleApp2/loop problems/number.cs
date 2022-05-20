using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_work.loops_problem_home_work
{
    internal class number
    {
        static void Main(string[] args)
        {
            int sum = 0;
            
            Console.WriteLine("enter a number");
            int a = Convert.ToInt32(Console.ReadLine());
            while (a > 0)
            {
                int digit = a % 10;
                sum = sum + digit;
                a = a / 10;

            }
                Console.WriteLine("addition of digit:{0}", sum);
                if (a % 10 == 0)
                
                    Console.WriteLine("harshad number");
                    else 
                        Console.WriteLine( "not a harshad number");

                }
            }
        }
    


