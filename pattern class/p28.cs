using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_class
{
    internal class p28
    {
        //5
        //45
        static void Main(string[] args)
        {
            for (int i = 5; i >= 1; i--)
            {
                for (int j = i; j <= 5; j++)
                {

                    Console.Write(j);
                        

                    Console.Write(" ");
                }
                Console.WriteLine("");
            }
        }
    }
}
