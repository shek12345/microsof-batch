using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_work.while_loop_problem
{
    //amicable number
    internal class problem3

    {
        static void Main(string[] args)
        {
            int s1 = 0;
            int s2 = 0;
            Console.WriteLine("Enter a number");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n1; i++)
            {
                if (n1 % i == 0)
                {
                    s1 = s1 + i;

                }
                for (int j = 1; j <= n2; j++)
                {
                    if (n2 % j == 0)
                    {
                        s2 = s2 + j;

                    }
                    if(s1==n2 && s2==n1)
                    {
                        Console.WriteLine("amicable number");
                    }
                    else
                    {
                        Console.WriteLine("not a amicable number");
                    }
                }
            }
        }

    }
}