using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_class
{
    internal class p37hw
    {
        static void Main(string[] args)
        {
            for (int i = 1; i<= 7; i++)
            {
                for (int k = 1; k <= 7 - i; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2 * i - 1; j++)
                {



                    Console.Write(j);


                }
                Console.WriteLine("");
            }  
                    for (int i = 6; i >= 1; i--)
                    {
                        for (int k = 1; k <= 7 - i; k++)
                        {
                            Console.Write(" ");
                        }
                        for (int j = 1; j <= 2 * i - 1; j++)
                        {



                            Console.Write(j);


                        }
                        Console.WriteLine("");
                    }
                }
            }
        }

    


