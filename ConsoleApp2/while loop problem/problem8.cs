using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_work.while_loop_problem
    //red
{
    internal class problem8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i % 3 == 0 && i % 5 == 0 ? "RedBlue" : i % 3 == 0 ? "Red" : i % 5 != 0);
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("RedBlue");
                else if (i % 3 == 0)
                { Console.WriteLine("Red");
                }
                else if(i%5==0)
             { 
                    Console.WriteLine("Blue");

                }
                else
                    Console.WriteLine("number itself");
                
        

                
                    

            }

        }

    }
}
