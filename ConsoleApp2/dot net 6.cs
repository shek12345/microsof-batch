using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arey_assignment
{
    internal class del33
    {
        
        
             public delegate void mydel(string name);
        public static void uppercase(string name)
        {
            Console.WriteLine($"uppercase:"+name.ToUpper());
        }
        public static void lowercase(string name)
        {

            Console.WriteLine($"lowercase:" +name.ToLower());

        }
        
        
        static void Main(string[] args)
        {
            mydel m1 = uppercase;
            m1 = m1 + lowercase;
            m1("shekhar");

        }
    }
    }
