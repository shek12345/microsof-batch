using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance.string_assignment
{
    internal class s2
    {
        static void Main(string[] args)
        {
            string s = "shekhar";
            string rev = "";
            for(int i=s.Length-1;i>=0; i--)
            {
                rev = rev + s[i];

            }
            if(s==rev)
                Console.WriteLine("it is pallindrome");
            else
                Console.WriteLine("not a pallindrome");
        }
    }
}
