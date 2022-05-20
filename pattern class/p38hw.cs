using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_class
{
    internal class p38hw
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int k = 1; k <= 5- i; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2 * i - 1; j++)
                {



                    Console.Write("*");


                }
                Console.WriteLine("");
            }
            for (int i = 4; i >= 1; i--)
            {
                for (int k = 1; k <= 5 - i; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2 * i - 1; j++)
                {



                    Console.Write("*");


                }
                Console.WriteLine("");
            }
        }
    }
    }
    

