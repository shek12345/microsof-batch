using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//deligate multicast 
namespace arey_assignment.delegates
{
    internal class d3
    {
        public delegate void mydel(int a, int b);
        public static void add(int a, int b)
        {
            Console.WriteLine("sum=" + (a + b));
        }
        public static void substract(int a, int b)
        {
            Console.WriteLine("sub=" + (a - b));
        }
        public static void product(int a, int b)
        {
            Console.WriteLine("pro=" + (a * b));
        }
    
       
       
        
            static void Main(string[] args)
            {
                mydel m1 = add;
                m1 = m1 + substract;
                m1 = m1 + product;
                m1(2, 4);

            }

        }
    }

