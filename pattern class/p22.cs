using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_class
  {   
    //1
    //22
    //333


    internal class p22
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {

                    Console.Write(i);

                    Console.Write(" ");
                }
                Console.WriteLine("");
            }
        }
    }
}