using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clas_work_pattern
{
    internal class p3
    {
        static void Main(string[] args)
        {



            for (int r = 0; r <= 7; r++)
            {
                for (int c = 0; c <= 7; c++)
                {
                    if( ((c == 0 || c == 7  ) || (r == 0 || r == 3)))
                    

                        Console.Write("*");
                    else



                            Console.Write("");

                    }
                    Console.WriteLine("");
                }
            }
        }
    }

