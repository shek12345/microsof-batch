using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_work.while_loop_problem
{
    internal class imei_no
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            long a = Convert.ToInt32(Console.ReadLine());
            long n = a;
            long c = 0;
            while (n > 0)
            {
                c++;
                n = n % 10;

                Console.WriteLine("NO of digit");
                if (c == 15)

                {
                    int sum = 0;
                    for (int i = 1; i <= 15; i++)
                    {
                        int d = (int)(n % 10);
                        n = n / 10;
                        if (i % 2 == 0)
                        {
                            int doubleup = 2 * d;
                            if (doubleup <= 9)
                                sum = sum + doubleup;
                            else
                                sum = sum + doubleup % 10 + doubleup / 10;
                        }
                    }
                }
                {
                    Console.WriteLine("valid no");
                }




                {
                    Console.WriteLine("not a valid no");

                }
            }
        }
    }
}

