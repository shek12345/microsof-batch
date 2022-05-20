using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_class
    /* *
     * ***
     * ***** */
{
    internal class p33
        
            
                
    {
        static void Main(string[] args)
        {

            Console.WriteLine("no of stars");
            int s = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= s; i++)
            {
                for (int k = 1; k <= i; k++)
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