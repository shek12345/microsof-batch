using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class bouncy
    {
        static void Main(string[] args)
        {



            Console.WriteLine("enter a number");
            int a = Convert.ToInt32(Console.ReadLine());
            int rem = 0, t = 0, c = 0, l = 0, h = 0;

            while (a > 0)
            {
                c++;
                rem = a % 10;
                if (c == 1)
                {
                    t = rem;
                    l++;
                    h++;
                }
                else if (rem < t)
                {
                    t = rem;
                    h++;
                }
                else if (rem > t)
                {
                    t = rem;
                    l++;
                }
                a = a / 10;
            }
            if (c == h)
                Console.WriteLine("increasing");
            else if (c == l)
                Console.WriteLine("decreasing");
            else
                Console.WriteLine("bouncy");
        }
    }
}