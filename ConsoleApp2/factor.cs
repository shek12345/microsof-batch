using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_work
{
    internal class factor
    {
        static void Main(string[] args)

        {
            
            Console.WriteLine("acce numb");
            int numb = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= numb; i++)
            {
                if (numb % i == 0)
                    Console.WriteLine(i);
            }     
           
            

        }
    }
}