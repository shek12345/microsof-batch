using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//anomous method
namespace arey_assignment
{
    public delegate void del(int a,int b);
    internal class d4
    {
        

      /*  public static  void add(int a,int b)
        {
            Console.WriteLine(a+b);
        }*/
   
    static void Main(string[] args)
    {
         Action<int,int>d1 = (a,b) => Console.WriteLine(a+b);
            d1(10, 76);

           
    }
    }
}
