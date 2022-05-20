using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_class
{
    //P
    internal class p9
    {
        static void Main(string[] args)
        {
            for (int r = 0; r <= 6; r++)
            {
                for (int c = 0; c <= 6; c++)
                {
                  if  ( (c == 0 || r == 0 || r == 3) ||( c == 6) && (r == 1 || r == 2))
                        
                       Console.Write("*");
                   
                    else
                        Console.Write(" ");
                }
                     Console.WriteLine("");
            }


        }

    }
    
}
