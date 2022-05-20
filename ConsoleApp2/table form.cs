using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_work
{
    internal class table_form

    {
        static void Main(string[] args)
        {
            int number, multiplier;
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            for(multiplier=1;multiplier<=10;multiplier++)
            {
                Console.WriteLine("{0}*{1}={2}",num,multiplier,(num*multiplier));

            }
            Console.Read();
        }
    }
}
