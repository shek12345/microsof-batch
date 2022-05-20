using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
//sorted list non generic
namespace arey_assignment
{
    internal class student : IComparable
    {
        string sname;
        int percentage;
        string city;



        public int CompareTo(object o)
        {
            student s2 = (student)o;

            return this.Sname.CompareTo(s2.Sname);
        }
        public override string ToString()
        {
            return $"Name:{ Sname} City{City} Percentage{Percentage}";

        }
        public student(string sname, int percentage, string city)
        {
            this.Sname = sname;
            this.Percentage = percentage;
            this.City = city;
        }
        public string Sname { get => sname; set => sname = value; }
        public int Percentage { get => percentage; set => percentage = value; }
        public string City { get => city; set => city = value; }
    
    }
    class A
    {
        static void Main(string[] args)
        {
            SortedList ss = new SortedList();
            ss.Add(new student("Akash", 37, "sangli"), "csharp");
            ss.Add(new student("Ajay", 44, "pune"), "java");
            ss.Add(new student("shekhar", 67, "latur"), "java");

            ss.Add(new student("Amit", 67, "sangli"), "java");
            foreach (DictionaryEntry d in ss)
                Console.WriteLine(d.Key + " " + d.Value);
        }
    }
}