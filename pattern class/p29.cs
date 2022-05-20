using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_class
    /* 1
     *12
     123
    1234 */ 
{
    internal class p29
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int k = 1; k <= 5 - i; k++)
                    Console.Write(" ");
                for (int j = 1; j <=i; j++)
                

                    
                    Console.Write(j);

                    Console.WriteLine("");
                }
            }
        }
    } 