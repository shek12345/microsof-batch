using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//constructr
namespace pattern_class.oops
{
    internal class Car
    {
        string carmodel;

        string colour;
        int caryear;

        public Car(string model, string col, int year)
        {
            carmodel = model;
            colour = col;
            caryear = year;
        }
        static void Main(string[] args)
        {
            Car c1 = new Car("hondacity", "red", 2020);
            Console.WriteLine("model:"+c1.carmodel);
            Console.WriteLine("col:"+c1.colour);
            Console.WriteLine("year:"+c1.caryear);
        }

    }
}