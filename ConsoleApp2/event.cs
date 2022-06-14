using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arey_assignment
{

    public delegate void mydel1();
    internal class Bank
    {
        public event mydel1 zerobalance;
        public event mydel1 Insufficientbalance;
        int bal;
        public Bank()
        {
            bal = 100;
        }
        public void creadit(int value)
        {
            bal = bal + value;
        }
        public void debit(int value)
        {
            if ((bal == 0))
            {
                zerobalance();
            }
            else if (bal < value)
            {
                Insufficientbalance();
            }


        }
    } 
        class bank1
        {
            static void Insufficientbalance()
            {
                Console.WriteLine("Insufficient balance");
            }
            static void zerobalance()
            {
                Console.WriteLine("zero balance");
            }
            static void Main(string[] args)
            {
                Bank b = new Bank();
                b.zerobalance += new mydel1(zerobalance);
                b.Insufficientbalance += new mydel1(Insufficientbalance);
                b.debit(300);
            }
        }
    }

