using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_class
{
    internal class p8
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j = 5;   
            for (int r = 1; r <= 6; r++)
            {
                for (int c = 1; c <= 6; c++)
                {
                    if (c == 1 || r == c+1||r+c==6) 
                        Console.Write("*");

                    else if
                        (r == i && c == j)


                    {

                        Console.Write(" ");
                        i = i + 1;
                        j = j - 1;


                    } 
                    else     
                    Console.Write("  ");
                }
                Console.WriteLine("");
            }
            
        }
    }
}