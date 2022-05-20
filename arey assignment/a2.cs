using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arey_assignment
{
    internal class a2
    {
        static void Main(string[] args)
        {
            int[] a = new int[6];
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            
            
                if(a[i]%2==0)
                {
                sum = sum + a[i];
                }
                Console.WriteLine("sum of even element"+sum);
            }

        }
    }
}
