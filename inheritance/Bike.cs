using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class Bike
    {
        string model;
        string colour;
        int price;

        public Bike()
        {
            Console.WriteLine("In base class constructor");
        }
        public void M1()
        {

            Console.WriteLine("in base class");
        }
    }
         class Honda : Bike
        {
            public Honda()
            {
                Console.WriteLine("in derived class constructor");
            }
        }
            class test
            {
                static void Main(string[] args)
                {
                    Bike b1 = new Bike();
                    b1.M1();
                }

            }
        
    }













      
        
    

