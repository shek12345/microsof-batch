using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_work.while_loop_problem
{
    //twin prime number
    internal class problem_5
    {
        static void Main(string[] args)
        {
            int x = 0;
            Console.WriteLine("Enter a number a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a number b");
            int b = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                    x++;


            }
           

            int y = 0;
            for (int i = 1; i <=b; i++)
            {
                if (b % i == 0)
                   y++;


            }
          
        
             if(x==2 && y==2)
            {
                if(x-y==2 || y-x==2)
                    Console.WriteLine("Twin Prime number");
                else
                    Console.WriteLine("Prime but not twin");


            }
             else
            {
                Console.WriteLine("Not prime numbers");
            }
        }

    }

}           
                
                    
                            
                        
                    

                
            
        
    
