using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_class
{
    internal class p30
        /*   6
         *  56
         * 456
         *3456 */
    {
        static void Main(string[] args)
        {
            for (int i = 6; i >= 1; i--)
            { 
                for (int k = 1; k <= i - 1; k++)
                    Console.Write(" ");
                for (int j = i; j <= 6; j++)
             


                    Console.Write(j);
                
                    Console.WriteLine("");
                }
            }
        }
    }