using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_class
    /* *****
     *  ***
     *   * */
{
    internal class p36
    {
        static void Main(string[] args)
        {

            Console.WriteLine("no of stars");
            int s = Convert.ToInt32(Console.ReadLine());
            for (int i = s; i >= 1; i--)
            {
                for (int k = 1; k <= s - i; k++)
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