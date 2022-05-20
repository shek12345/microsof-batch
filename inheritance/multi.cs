using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class Car
    {
        string model;
        string colour;
        int price;
        public Car()
        {
            Console.WriteLine("In base class constructor");
        }
        public void Car1()
        {
            Console.WriteLine("in base class");
        }
    }
        class Honda1 : Car
    {
        public Honda1()
        {
            Console.WriteLine("in derived class constructor");
        }
    }
            class Toyata : Honda1
            {

                public Toyata()
                {
                    Console.WriteLine("in derived class constructor");
                }
            }
                class test1
                {
                    static void Main(string[] args)
                    {
                        Car c = new Car();
                        c.Car1();

                    }
                }
        }
    

