using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_class.oops
{
    internal class Country
    {
        string name;
        int nooflanguages;
        int noofstates;
        string capital;

        public string Name
        {

            set { name = value; }
            get { return name; }

        }
        public int Nooflanguages
        {
            set { nooflanguages = value; }
            get { return nooflanguages; }
        }
        public int Noofstates
        {
            set { noofstates = value; }
            get { return noofstates; }
        }

        public string Capital
        {
            get { return capital; }
            set { capital = value; }
        }
    }
        class Country1
        {

            static void Main(string[] args)
            {
                Country c1 = new Country();
                c1.Name = "india";
                c1.Nooflanguages = 87;
                c1.Noofstates = 45;
                c1.Capital = "delhi";
                Console.WriteLine(c1.Name);
                Console.WriteLine(c1.Nooflanguages);
                Console.WriteLine(c1.Noofstates);
                Console.WriteLine(c1.Capital);


            }
        }
    }

