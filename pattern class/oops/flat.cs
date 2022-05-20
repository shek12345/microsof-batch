using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_class.oops
{
    internal class Flat
    {
        int flatno;
        string buildingname;
        Owner flatowner = new Owner();
        public Flat()
        {

        }

        public int Flatno { get => flatno; set => flatno = value; }
        public string Buildingname { get => buildingname; set => buildingname = value; }
        internal Owner Flatowner { get => flatowner; set => flatowner = value; }
    }
    class Owner
    {
        int age;
        string ownername;
        char gender;
        public Owner()
        {

        }

        public int Age { get => age; set => age = value; }
        public string Ownername { get => ownername; set => ownername = value; }
        public char Gender { get => gender; set => gender = value; }
    }

    class test
    {
        static void Main(string[] args)
        {
            Flat f1 = new Flat();
            f1.Flatno = 101;
            f1.Buildingname = "omkar";
            f1.Flatowner.Age = 24;
            f1.Flatowner.Ownername = "akash";
            f1.Flatowner.Gender = 'm'; 
        }
    }
}

