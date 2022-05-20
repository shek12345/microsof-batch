using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_class.oops
{
    internal class Constructor
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
    }
}
