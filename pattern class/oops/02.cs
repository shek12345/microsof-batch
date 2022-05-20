using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_class.oops
{
    internal class Calculator

    {
        public void Add(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine("sum");
        }
            public float Si(int p, float r,int n)
        {
            float si = p * n * r;
            return si;
        }
            public bool isLeapYear(int yy)
        {
            if (yy % 4 == 0)
                return true;
            else
                return false;
            static void Main(string[] args)
            {
                Calculator c = new Calculator();
                float Si = c.Si(30000, 4.0f, 2);
                bool r = c.isLeapYear(2021);
                c.Add(3, 4);
                    Console.WriteLine("Si:"+Si);
                Console.WriteLine("isLeapYear:"+r);
            }
        }
        
    }
}
