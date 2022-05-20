using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_work
{
    internal class prime_numb
    {
        static void Main(string[] args)
        {
            int number = 7;
            int count = 0;
            Console.WriteLine("take any number");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=number; i++)
            {
               if(number%i==0)
                {
                    count++;
                }
            }
            if(count==2)
            {
                Console.WriteLine("prime mumber");

            }
            else
            {
                Console.WriteLine("not aprime number");
            }
        }
    }
}
