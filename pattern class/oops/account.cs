using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//properties method
namespace pattern_class.oops
{
    internal class Account
    {
        string name;
        long accountno;
        long mobileno;


        public string Name
        {
            set { name = value; }
            get { return name; }

        }
        public long Accountno
        {
            set { accountno = value; }
            get { return accountno; }
        }
        public long Mobileno
        {
            set { mobileno = value; }
            get { return mobileno; }
        }
    }
    class Account1
    {
        static void Main(string[] args)
        {
            Account a1 = new Account();
            a1.Name = "shekhar";
            a1.Accountno = 4536335443636;
            a1.Mobileno = 8675474477;
            Console.WriteLine(a1.Name);
            Console.WriteLine(a1.Accountno);
            Console.WriteLine(a1.Mobileno);
        }
    }
}
