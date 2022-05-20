using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class kno
    {
        static void Main(string[] args)
        {
            int  fact, add = 0; 
            Console.WriteLine("krisnmurty no");
            int n = Convert.ToInt32(Console.ReadLine());
            
            for(int i=1;i<=1000;i++)
                {
                
                int digit = n % 10;
                n = n / 10;
                fact = 1;
                add = 0;
                for (int j = 0; j <= digit; j++)
                    fact = fact * j;
                add = add + fact;
                    
            }
            
                Console.Write("number is krisnmurty");
            
            
        }
    }
}
