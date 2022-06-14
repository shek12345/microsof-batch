using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arey_assignment
{
    internal class jaggad 
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[2][];

            arr[0] = new int[3] { 11, 45, 66 };
            arr[1] = new int[6] { 33, 55, 4, 33, 22, 222 };
        
            for( int i=0; i<arr.GetLength(0);i++)
            {
                
                for(int j=0; j<arr[i].Length;j++)
                {
                    Console.WriteLine(arr[i][j]+" ");
                }
                Console.WriteLine();
            }
                
        }
    }
}
