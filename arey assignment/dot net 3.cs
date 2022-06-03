using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arey_assignment
{
    internal class  array
    {
        static void Main(string[] args)
        {
            int[,] a = new int[4, 3]
            {
                { 1,2,3},
                { 2,3,4},
                {3,6,7 },
                {5,8,6 },
            };
            int i, j;
            for (i = 0; i < a.GetLength(0); i++)
            {
                for (j = 0; j < a.GetLength(1); j++)
                {
                    Console.WriteLine(a[i,j]+" ");
                    Console.WriteLine();
                }
            }
           

            
           
        }
    }
}