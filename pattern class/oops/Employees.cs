using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_class.oops
{
    internal class Employees
    {
        long Mobileno;
        string Name;
        int Age;
        public Employees()
        {
            Console.WriteLine("");
        }
        public Employees(long no, string nm, int a)
        {
            Mobileno = no;
            Name = nm;
            Age = a;

        } 

        class Employees1
        {
            static void Main(string[] args)
            {
                Employees e1 = new Employees();
                e1.Mobileno = 7658484488;
                e1.Name = "shekhar";
                e1.Age = 25;
                Console.WriteLine("no:" + e1.Mobileno);
                Console.WriteLine("nm:" + e1.Name);
                Console.WriteLine("a:" + e1.Age);
            }
        }
    }
}