using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arey_assignment
{
    
    internal class student22
    {
        public delegate void mydel();
        public event mydel Fail;
            public event mydel Dis;
        public void Accmarks(int marks)
        {
            if ((marks<40))
            {
                Fail();
            }
            else if (marks >60)
            {
                Dis();
                
            }
            Console.WriteLine($"your score is{marks}");
        }
        class pg
        {
            static void Failmsg()
            {
                Console.WriteLine("you are fail!");
            }
            static void Dismsg()
            {
                Console.WriteLine("you are dis!");
            }
            static void Main(string[] args)
            {

                student22 s = new student22();
                s.Fail += new mydel(Failmsg);
                s. Dis+= new mydel(Dismsg);
                s.Accmarks(87);
            }
        }

    }
}
