using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_class
{
    internal class p16
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 9;i= i+2)
            {
                for (int j = 1; j <= i; j=j+2)
                {

                    Console.Write(j);

                    Console.Write(" ");
                }
                Console.WriteLine("");
            }
        }
    }
}