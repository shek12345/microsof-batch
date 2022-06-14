using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
//arraylist non generic

namespace arey_assignment
{
    internal class player
    {
        int playerid;
        string playername, country, team;

        public player(int playerid, string playername, string country, string team)
        {
            this.Playerid = playerid;
            this.Playername = playername;
            this.Country = country;
            this.Team = team;
        }

        public int Playerid { get => playerid; set => playerid = value; }
        public string Playername { get => playername; set => playername = value; }
        public string Country { get => country; set => country = value; }
        public string Team { get => team; set => team = value; }
    }
    class IPL
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(new player(1, "MS Dhoni", "India", "csk"));
            al.Add(new player(1, "Rohit Sharma", "India", "mi"));
            al.Add(new player(1, "maxwell", "Austr", "rcb"));
            al.Add(new player(1, "vk", "India", "rcb"));
            al.Add(new player(1, "finch", "austr", "kkr"));
            al.Add(new player(1, "cummins", "austr", "kkr"));
            al.Add(new player(1, "warner", "austr", "dc"));
            al.Add(new player(1, "pant", "India", "dc"));
            al.Add(new player(1, "surya", "India", "mi"));
            al.Add(new player(1, "jadeja", "India", "csk"));
            al.Add(new player(1, "hazelwood", "austr", "csk"));


        }
    }
}
