using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_work.loops_problem_home_work
{
    internal class fre
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int n = Convert.ToInt32(Console.ReadLine());
            int a = n;
            int c = 0;
            for (int i = 0; i <= 10; i++)
            {
               
                n = a;
                while (n > 0)
                {
                    int d = n % 10;
                    if (d == i)
                        c++;
                    n = n / 10;

                }
                if (c > 0)
                    Console.WriteLine($"Frequencyof{i}={c}");

            }
        }
    }
}
