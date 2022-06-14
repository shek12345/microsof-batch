using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
//Hashtable non generic

namespace arey_assignment
{
     class collection2
    {
        static void Main(string[] args)
        {
            ArrayList al= new ArrayList()

            {
                "pune", "mumbai","pune", "mumbai","Nashik","pune"
            };
            Hashtable h = new Hashtable();
            foreach (dynamic k in al)
            {
                if (h.ContainsKey(k))
                {
                    int oldvalue = h[k];
                    h[k] = oldvalue + 1;
                }
                else
                    h.Add(k, 1);

            }
            foreach (DictionaryEntry e in h)
                Console.WriteLine(e.Key + " "+e.Value);

        }
    }
}
