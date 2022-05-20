using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class vehicle
    {
         string nm;
          internal int price;
        public override string ToString()
        {
            return $"nm:{nm} price:{price}";
            
        }


        public void Go()
        {
            Console.WriteLine("vehicle is moving");
        }
    } 
        class car:vehicle
        {
           public  new void Go()
            {
                Console.WriteLine("car is moving");
            }
        }
        class bicycle : vehicle
        {
            public void Go()
            {
                Console.WriteLine("bicycle is moving");
            }
        }
            class vehicle1
            { 
                static void Main(string[] args)
            {
                vehicle v = new vehicle();
            Console.WriteLine(v);
            
                    vehicle c= new car();
                    c.Go();
                    
            }
            
                
            }
           
          
        }
           

    

