using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arey_assignment
{
    class Class2
    {
        static int Potential(string ss)
        {


            int sum = 0, a;

            for (int j = 0; j < ss.Length; j++)
            {
                if (ss[j] >= 'A' && ss[j] < 'Z')
                {
                    a = ss[j] - 64;

                    sum = sum + a;
                }
            }

            return sum;
        }
        static void Main(string[] args)
        {
            string ss = Console.ReadLine();
            ss = ss.ToUpper();

            //ss="my name is riya
            string[] arr = ss.Split();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (Potential(arr[j]) > Potential(arr[j + 1]))
                    {
                        // swap
                        string t = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = t;
                    }
                }
            }

            foreach (string wrd in arr)
                Console.Write(wrd + " ");
            Console.ReadLine();
        }
    }
}