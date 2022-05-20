using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clas_work_pattern
{
    internal class p1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number of row");
           int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number col");
            int b = Convert.ToInt32(Console.ReadLine());

            for (int r=1;r<=5;r++)
            {
                for (int c = 1;c <= 5; c++)
                {
                    if (c== 1 ||((r==1||r==3)))
                        Console.Write("*");
                        else
                        Console.WriteLine(" ");
                    

                }
            }

        }
    }
}
