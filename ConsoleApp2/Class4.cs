using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_work
{
    internal class Class4
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("take n value");
            int n = Convert.ToInt32(Console.ReadLine());

            switch (n % 2 == 0)
            {
                case true: Console.WriteLine("even num");
                    break;

                case  false: Console.WriteLine("odd num");
                    break;
                default:
                                       
                        

            }
            

        }

    }
}
