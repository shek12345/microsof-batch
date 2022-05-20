using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//generic delegate
namespace arey_assignment.delegates
{
    internal class d4
    {
        public static double Add(int a, int b, float c)
        {
            return a + b + c;
          
            
        }
        public static void  substract(int a,int b)
        {
            Console.WriteLine(a-b);
        }
        public static void sum(string a,string b)
        {
            Console.WriteLine(a+b);
        }
        public static  bool checklength(string Name)
        {
            if (Name.Length > 4)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            Func< int, int, float, double> f1 = Add;
            
            double  d = f1(23, 55, 46.444f);
            Console.WriteLine(d);
            Action<int, int> a1 = substract;
            a1 (34, 54);
            Action<string, string> a2 = sum;
                a2("shekhar", "shinde");
            Predicate<string> p1 = checklength;
            bool b = p1("shekhar");
            Console.WriteLine(b);


               
                
        }
    }
}
