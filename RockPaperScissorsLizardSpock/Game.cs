using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class Game
    {
        //variables
        public string Rules;
        public Player Player1;
        public Player Player2;
        public int RandomInt;


        public Game()
        {

        }

        public void GetPlayers()
        {
            Console.WriteLine("Enter How Many Players");
            string numberOfPlayers = Console.ReadLine();

            if (numberOfPlayers == "1")
            {
                Player1 = new Player();
                Player2 = new Computer();

            }
            else
            {
                Player1 = new Player();
                Player2 = new Player();
            }

            Random Rnd  = new Random();
            

            {

            }
        }
    

        
        

        
        

  


        //constructor

        //methods
        //result which player wins
        //1 or 2 player
        //compares player choices
    }
}
