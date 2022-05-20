using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_class
    //1
    //13
    //135
{
    internal class p17
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 9;i= i+3)
            {
                for (int j = 1; j <= i;j= j+3)
                {

                    Console.Write(j);

                    Console.Write(" ");
                }
                Console.WriteLine("");
            }
        }
    }
}