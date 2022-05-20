using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_class
{
    internal class p27
    {
       /*5
         44*/
        static void Main(string[] args)
        {
            for (int i =5; i >= 1; i--)
            {
                for (int j = i; j <= 5; j++)
                {

                    Console.Write(i);

                    Console.Write(" ");
                }
                Console.WriteLine("");
            }
        }
    }
}