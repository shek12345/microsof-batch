using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_work.while_loop_problem
{
    //trimorphic number
    internal class problem4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int a = Convert.ToInt32(Console.ReadLine());

            int cube;
            cube = a * a * a;
            {
                Console.WriteLine("cube",+cube);
            }
            while(a>0)
            {
                
                int digit = cube % 10;
                {
                    if (a == digit)
                    {
                        Console.WriteLine("trimorphic no");
                    }
                    else
                    {
                        Console.WriteLine("not a trimorphic no");
                    }

                    }
                }
            }
        }
    }

