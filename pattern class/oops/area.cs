using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//overloading

namespace pattern_class.oops
{
    internal class overload
    {
        static public void area(int s)
        {
            Console.WriteLine("area oh squre"+s*s);
        }
        static public void area(float r)
        {
            Console.WriteLine("Area of circle"+3.24f*r*r);
        }
        static public  void area(int l,int b)
        {
            Console.WriteLine("Area of rectangle"+l*b);
        }
        static void Main(string[] args)
        {
            overload.area(10);
            overload.area(3.4f);
            overload.area(10, 32);
        }
    }
}
