using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_work
{
    internal class nterms
    {
        //2,5,10,17,26,37,50,...nterms
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i=1; i<=10;i++)
            {
                Console.WriteLine(i*i+1);
            }

        }

    }
}
