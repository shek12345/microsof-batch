using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_class.oops
{
     class Voter
    {
        long   adharcard;
        string Votername;
        string votercasted;


        public void SetAdharCard(long card)
        {
            adharcard = card;
        }
        public long getAdharCard()
        {
            return adharcard;
        }
        public void SetVoterName(string name)
        {
            Votername = name;
        }
        public string getVoterName()
        {

            return Votername;

        }
        public void SetVoterCasted(string casted)
        {
            votercasted = casted;
        }
        public string getVoterCasted()
        {

            return votercasted;

        }
        class Vote
        {
            static void Main(string[] args)
            {
                Voter v1 = new Voter();
                v1.SetAdharCard(1223344657443637);
                v1.SetVoterName("Akshay");
                v1.SetVoterCasted("bjp");
                Console.WriteLine(v1.getAdharCard());
                Console.WriteLine(v1.getVoterName());
                Console.WriteLine(v1.getVoterCasted());

            }
        }
    }
}