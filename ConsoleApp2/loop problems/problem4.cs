using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_work.loops_problem_home_work
{
    internal class problem4
        //squre for 1 to 20

    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("number");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i =1; i <= 20;i++)
            {
                sum= i * i;

            }
            Console.WriteLine("squre of 1 to 20 num");

        }
        
    }
}
