using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_work.pattern
{
    internal class p1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("no of rows");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("no of col");
            int c = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=r;i++)
            {
                for(int j=1; j<=c;j++)
                { Console.Write("*"); 

            }
                Console.WriteLine();
        }

    }
}
}