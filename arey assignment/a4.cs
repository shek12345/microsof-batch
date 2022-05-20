using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace arey_assignment
{
    internal class a4
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("shekhar");
            al.Add(25);
            al.Add("latur");
            al.Add("Shekhars323@gmail.com");
            al.Add(2020);
            Console.WriteLine(al.Count);
            al.Add("shekhar");
            
            Console.WriteLine(al.Capacity);
            for (int i = 0; i < al.Count; i++)
            {

                Console.WriteLine(al[i]);
                al.Remove("latur");
                al.RemoveAt(2);
                

                
                    
            }

        }
    }
}