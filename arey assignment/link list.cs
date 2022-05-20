using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arey_assignment
{
    internal class linklist
    {
        private static LinkedListNode<int> newNode;

        static void Main(string[] args)
        {
            LinkedList<int> ll = new LinkedList<int>();
            ll.AddLast(34);
            ll.AddLast(45);
            ll.AddLast(31);
            ll.AddLast(65);
            ll.AddFirst(68);
            ll.AddAfter(ll.First, 34);
            
            foreach (int x in ll)
                Console.WriteLine(x);
         
            
           
        }
    }
}
