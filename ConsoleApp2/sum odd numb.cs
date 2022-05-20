using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_work
{
    internal class sum_odd_numb
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Enter any number");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++) 
            {
                sum = i + 1;
            }
            Console.WriteLine("sumof first 10 odd numbers"+num+"="+sum);

            Console.ReadLine();


        }
    }
}
