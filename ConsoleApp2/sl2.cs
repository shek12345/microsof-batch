using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
//sorted list non generic
    

namespace arey_assignment
{
    internal class mysort : IComparer
    {
        public int Compare(Object o1, object o2)

        {
            StringBuilder sb1 = (StringBuilder)o1;
            StringBuilder sb2 = (StringBuilder)o2;
            return sb1.ToString().CompareTo(sb2.ToString());

        }
    }
    class B
    {
        static void Main(string[] args)
        {
            SortedList sl = new SortedList(new mysort());
            sl.Add(new StringBuilder("shekhar"), 90);
            sl.Add(new StringBuilder("akash"), 95);
            sl.Add(new StringBuilder("amit"), 92);
            sl.Add(new StringBuilder("ajay"), 93);
            foreach(DictionaryEntry d in sl)

                Console.WriteLine(d.Key+" "+d.Value);

        }
    }
            


    }

