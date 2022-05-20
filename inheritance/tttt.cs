using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class sample
    {
        public int func(int k ,int y)
        {
            return k+y;
        }
        public int func1(int t, float z)
        {
            return (t+(int)z);
        }
       
        class Program
        {
            static void Main(string[] args)
            {
                sample s = new sample();
                int i ;
                int b = 90;
                int c = 100;
                int d = 12;
                float m= 14.78f;
                i = s.func(b, c);
                Console.WriteLine(i);
                int j = (s.func1(d, m));
                Console.WriteLine(j);
                
                
                Console.ReadLine();

            }

        }
    }
}