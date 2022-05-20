using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_class.oops
{
    internal class Student
    {
        int studentid;
        string name;
        float percent;
        Batch batch1 = new Batch();
        Address add = new Address();










        public int Studentid1 { get => studentid; set => studentid = value; }
        public string Name { get => name; set => name = value; }
        public float Percent { get => percent; set => percent = value; }
        internal Batch Batch1 { get => batch1; set => batch1 = value; }
        internal Address Add { get => add; set => add = value; }
    }

    class Batch
    {
        string batchname;
        string subject;









        public string Batchname { get => batchname; set => batchname = value; }
        public string Subject { get => subject; set => subject = value; }

    }
    class Address
    {
        string street;
        string city;







        public string City { get => city; set => city = value; }
        public string Street { get => street; set => street = value; }
    }
}
class test
{
    static void Main(string[] args)
    {

        
    }

}