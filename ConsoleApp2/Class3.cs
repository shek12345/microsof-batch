using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_work
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int n = Convert.ToInt32(Console.ReadLine());
            
            if (n>0)
                Console.WriteLine("positive number");
            else if (n<0)
                Console.WriteLine(  "negative number");
            else
                Console.WriteLine("zero");

            string msg = n > 0 ? "positive" : n < 0 ? "negative" : "zero";

            Console.WriteLine(msg);
        } 
    }
}
