using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arey_assignment
{
    internal class emp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double salary { get; set; }
    }
       class emp1
        {
            static void Main(string[] args)
            {
            emp[] emplist = new emp[]
         {
                 new emp{Id=1,Name="shekhar", salary=2000},
                 new emp{Id=2,Name="akash", salary=5000},
                 new emp{Id=3,Name="amol", salary=7000},
                 new emp{Id=4,Name="amit", salary=24000},
            };
            foreach(emp e in emplist)
            {
                Console.WriteLine($"{e.Id}");
            }
            }
        }

    }

