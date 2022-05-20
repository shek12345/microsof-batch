using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_class.oops
{
    internal class Book

    {
         public string  name, author;
         public int price;
       
        static void Main(string[] args)
        {
            Book b1 = new Book();
            Book b2 = new Book();
            b1.name = "www";
            b1.author = "abc";
            b1.price = 100;
            Console.WriteLine(b1);
            Console.WriteLine("book name,author.price");
            b2. name = Console.ReadLine();
            b2.author = Console.ReadLine();
            b2.price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(b2);
                
                             
            
            
           
            




        }
}

}