using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//largest no in array
namespace arey_assignment
{
    internal class a3
    {
        static void Main(string[] args)
        {
            int max1, max2;
            Console.WriteLine("array element are");

            int[] arr = new int[7];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
            max1 = max2 = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max1)
                {
                    max2 = max1;
                    max1 = arr[i];
                }
                else if (arr[i] > max2)
                {
                    max2 = arr[i];
                }
            }
            Console.WriteLine("first max no"+max1);
            Console.WriteLine("second max no"+max2);
        }
    }
}