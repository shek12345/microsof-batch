using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance.string_assignment
{
    internal class s1
    {
        static void Main(string[] args)
        {
            string s="shekhar";
            Console.WriteLine(s);
            string s1 = s.ToUpper();
            Console.WriteLine(s1);
            s = s.Replace('s', 'p');
            s = s.Replace('r', 't');
            Console.WriteLine(s);
            for(int i=0;i<s.Length;i++)
            {
                Console.WriteLine(s[i]);
            }
            
        }

    }
}
