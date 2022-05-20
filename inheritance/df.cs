using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class sample1
    {
        public int i;
        public int j;
        public void fun(int i,int j)
        {
            this.i = i;
            this.j = j;
        }
        class programe
        {
            static void Main(string[] args)
            {
                sample1 s = new sample1();
                s.i = 1;
                s.j = 2;
                s.fun(s.i, s.j);
                Console.WriteLine(s.i+" "+s.j);
                Console.ReadLine();
            }
        }
    }
}
