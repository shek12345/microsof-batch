using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_work.loops_problem_home_work
{
    internal class problem6
        //palindrome no or not
    {
        static void Main(string[] args)
        {
            int number = 1221;
            int reminder;
            Console.WriteLine("enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i=1; i<=1221;i++)
            {
                reminder = num % 10;
            }
        }
    }
}
