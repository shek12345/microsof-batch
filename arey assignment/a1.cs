using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arey_assignment
{
    internal class a1
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());

                int max = arr[0];
                {
                    if (arr[i] > max)
                    {
                        max = arr[i];
                    }
                    Console.WriteLine("max element is");
                }
            }
        }
    }
}
