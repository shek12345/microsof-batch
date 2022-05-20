using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_class
{
    internal class p32
        /*1
         ab
         123
         abcd
         12345*/
    {
        static void Main(string[] args)
        {



            for (int i = 1; i <= 5; i++)
            {


               

                for (int j = 1; j <= i; j++)
                {
                    if(i%2==1)


                    Console.Write(j);
                    else
                        Console.Write((char)(64+j));
                    
                }
                Console.WriteLine("");
            }
        }
    }
}