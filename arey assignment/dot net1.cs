using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arey_assignment
{
    internal class department
    {
       /* int depid;
        string dep_name;
        string location;*/

        public int Id { get ; set ; }
        public string Dep_name { get; set; }
        public string Location { get; set; }



        static void Main(string[] args)
        {
            department d = new department();
            d.Id = 1;

            d.Dep_name = "nj";
            d.Location = "pune";
            Console.WriteLine(d);
        }

    }
}
