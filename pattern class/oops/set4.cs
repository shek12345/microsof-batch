using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_class.oops
{
    internal class Pen
    {
        string Brand;
        string Colour;
        int Price;

        public void SetBrand(string b)
        {
            Brand = b;
        }
        public string GetBrand()
        {
            return Brand;
        }
        public void SetColour(string cl)
        {
            Colour = cl;
        }
        public string GetColour()
        {

            return Colour;

        }
        public void SetPrice(int pr)
        {
            Price = pr;
        }
        public int GetPrice()
        {
            return Price;

        }
    }
        class pen1
        {
            static void Main(string[] args)
            {
                Pen p1 = new Pen();
                p1.SetBrand("cello");
                p1.SetColour("blue");
                p1.SetPrice(10);
                Console.WriteLine(p1.GetBrand());
                Console.WriteLine(p1.GetColour());
                Console.WriteLine(p1.GetPrice());

                Pen p2 = new Pen();
                Console.WriteLine("brand");
                string b = Console.ReadLine();
                p2.SetBrand(b);
                Console.WriteLine("colour");
                string cl = Console.ReadLine();
                p2.SetColour(cl);
                Console.WriteLine("price");
                int pr = Convert.ToInt32(Console.ReadLine());
                p2.SetPrice(pr);
                Console.WriteLine(p1.GetBrand());
                Console.WriteLine(p1.GetColour());
                Console.WriteLine(p1.GetPrice());
            }

        }
    }



