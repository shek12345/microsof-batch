using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace arey_assignment
    //sortedlist generic 
{
    internal class student1 : IComparble<student1>
    {
        string sname;
        int percentage;
    



        public int CompareTo(student s2)
        {


            return Sname.CompareTo(s2.Sname);
        }
        public override string ToString()
        {
            return $"Name:{ Sname}  Percentage:{Percentage}";
        }
        public student1(string sname, int percentage)
        {
            this.Sname = sname;
            this.Percentage = percentage;

        }

        public string Sname { get => sname; set => sname = value; }
        public int Percentage { get => percentage; set => percentage = value; }
    }
    class AA
    {
        static void Main(string[] args)
        {
            SortedList<student, string> ss = new SortedList<student, string>();
            ss.Add(new student("Akash", 37, "sangli"), "csharp");
            ss.Add(new student("Ajay", 44, "pune"), "java");
            ss.Add(new student("shekhar", 67, "latur"), "java");

            ss.Add(new student("Amit", 67, "sangli"), "java");
            foreach (KeyValuePair < student,string> Kvp in ss)
                Console.WriteLine(Kvp.Key + " " + Kvp.Value);
        }
    }
}
