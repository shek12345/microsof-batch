using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_class
{
    internal class Stock
    {
        string Stockname;
        float Openingprice;
        float Closingprice;
        public void SetStockname(string nm)
        {
            Stockname = nm;
        }
        public string GetStockname()
        {
            return Stockname;
        }
        public void SetOpeningprice(float op)
        {
            Openingprice = op;
        }
        public float GetOpeningprice()
        {
            return Openingprice;
        }
        public void SetClosingprice(float cp)
        {
            Closingprice = cp;
        }
        public float GetClosingprice()
        {
            return Closingprice;
        }

        class stocktest
        {
            static void Main(string[] args)
            {
                Stock s1 = new Stock();
                s1.SetStockname("tcs");
                s1.SetOpeningprice(123.3f);
                s1.SetClosingprice(10.12f);
                Console.WriteLine(s1.GetStockname());
                Console.WriteLine(s1.GetOpeningprice());
                Console.WriteLine(s1.GetClosingprice());
                
             
            
                Stock s2 = new Stock();
                Console.WriteLine("Stockname");
                string nm = Console.ReadLine();
                s2.SetStockname(nm);
                Console.WriteLine("openingprice");
                Single op = Convert.ToSingle(Console.ReadLine());
                s2.SetOpeningprice(op);
                Console.WriteLine("Closingprice");
                Single cp = Convert.ToSingle(Console.ReadLine());
                s2.SetClosingprice(cp);
                Console.WriteLine(s2.GetStockname());
                Console.WriteLine(s2.GetOpeningprice());
                Console.WriteLine(s2.GetClosingprice());
            }

        }

        }
        

    }

