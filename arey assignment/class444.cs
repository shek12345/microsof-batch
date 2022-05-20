using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arey_assignment
{
    internal class class444
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30, 40, 50, 60, 70, 80 };
            int sum = 0;
            for (int i = 0; i < arr.Length; i += 2)
            {
                sum = 0;
                sum = arr[i] + arr[i + 1];

                Console.WriteLine(sum);
            }

        }
    }
}
