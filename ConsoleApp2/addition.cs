using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_work
{
    internal class addition
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter number");
            int numb = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            
            for (int i = 1; i <= 10; i++) 
            {
                sum = sum + i;
            }
            
            Console.WriteLine("addition of 1 to 10 number" +sum);
        }

        
        

    }
}
