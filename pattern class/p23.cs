using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_class
{
    internal class p23
    {
        static void Main(string[] args)
        {
            
            
            for (int i = 2; i <= 10; i=i+2)
            {
                for (int j = 2; j <= i;j= j+2)
                {
                    
                    
                    Console.Write(j);
                   

                    
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine("");
        }
    }
}