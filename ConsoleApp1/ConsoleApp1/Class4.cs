using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class4
        
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the operator(+,-,*,/ )");

            Console.WriteLine("enter the two numbers one by one");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("{0} + {1} = {2}", num1,num2,(num1+num2));

            Console.WriteLine("{0} - {1} = {2}", num1, num2,(num1-num2));

            Console.WriteLine("{0} * {1} = {2}", num1, num2,(num1* num2));

            Console.WriteLine("{0} / {1} = {2}", num1, num2,(num1/num2));

            Console.ReadLine();


        }  
    
    
    }
}
