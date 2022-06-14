using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace arey_assignment
{
    internal class collection1
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("Sun");
            al.Add("Mon");
            al.Add("Sat");
            al.Add("Sun");
            al.Add("Mon");

            al.Add("Sat");
            al.Add("Sun");
            al.Add("Sat");
            al.Add("Sun");
            al.Add("Mon");
            
          foreach (DictionaryEntry s in al)

                Console.WriteLine(s);
            
               

            
        }
    }
}
