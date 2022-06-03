using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arey_assignment
{
    internal class project1
    {
        static void Main(string[] args)
        {
            string Player, CPU;
            int randomint;
            int scorePlayer = 0;
            int ScoreCPU = 0;
            bool playagain = true;
            while(playagain)
                {
                scorePlayer = 0;
                ScoreCPU = 0;
            }
            while(scorePlayer<3&&ScoreCPU<3)
            Console.WriteLine("choose Stone,Paper,Scissors");
            Player = Console.ReadLine();
            Random rd = new Random();
            randomint = rd.Next(1, 4);

            switch(randomint)
                {
                case 1:
            CPU = "Stone";
                    Console.WriteLine("Computer choose Stone");
                    if(Player=="Rock")
                    {
                        Console.WriteLine("Draw");

                    }
                    else if(Player=="paper")
                    {
                        Console.WriteLine("Player wins");
                    }
                    else if (Player == "Scissors")
                    {
                        Console.WriteLine("CPU wins");
                        ScoreCPU++;
                    }
                    break;
                case 2:
                    CPU = "Paper";
                    Console.WriteLine("Computer choose Paper");
                    if (Player == "Paper")
                    {
                        Console.WriteLine("Draw");

                    }
                    else if (Player == "Rock")
                    {
                        Console.WriteLine("CPU wins");
                    }
                    else if (Player == "Scissors")
                    {
                        Console.WriteLine("Player wins");
                        ScoreCPU++;
                    }
                    break;
                case 3:
                    CPU = "Scissors";
                    Console.WriteLine("Computer choose Scissors");
                    if (Player == "Scissors")
                    {
                        Console.WriteLine("Draw");

                    }
                    else if (Player == "Rock")
                    {
                        Console.WriteLine("Player wins");
                    }
                    else if (Player == "Paper")
                    {
                        Console.WriteLine("CPU wins");
                        ScoreCPU++;
                    }
                    break;
                default:
                    Console.WriteLine("inbalid entry");
                    break;
                    Console.WriteLine("scores",scorePlayer,ScoreCPU);


            }
            if (scorePlayer == 3)
            {
                Console.WriteLine("Player wins");

            }
            else if(ScoreCPU==3)
            {
                Console.WriteLine("CPU wins");
            }
            else
            {

            }
            Console.WriteLine("Do uwan to play again");
            string loop = Console.ReadLine();
            if (loop=="Yes")
            {
                playagain = true;
            }
            else if (loop=="No")
            {
                playagain = false;
            }
            else
            {

            }
                
        }
            
            
    }
}
