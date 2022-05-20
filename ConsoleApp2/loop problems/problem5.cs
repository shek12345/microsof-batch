using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_work.loops_problem_home_work
{
    internal class problem5
        //prime no between 400 to 300
    {
        static void Main(string[] args)
        {
              int Count = 0;
            Console.WriteLine("prime number");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i=400;i>=300;i++)
            {
                if (num % i == 0)
                {
                    Count++;
                }
                else if (Count == 2)
                        {
                    Console.WriteLine("prime no between 400 to 300",+i);
                }
            }
        }
    }
}
