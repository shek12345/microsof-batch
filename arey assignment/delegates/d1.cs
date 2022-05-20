using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arey_assignment.delegates
{
    internal class d1
    {
        public static void factorial(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
                fact = fact * 1;
            Console.WriteLine("Factorial:"+fact);
        }
        class d2
        { 
        public delegate void mydel(int a);
        
        
            static void Main(string[] args)
            {
                mydel m1 = d1.factorial;
                m1(34);
                m1(5);
                m1(2);
            }

        }

    }
}
