using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
   public class Player
    {
        //variables
        //
        public string Name;
        public string WeaponChoice;
        public int Score;
        public int GameRound;
        public bool PlayAgain;

        public Player()
        {

            this.Score = 0;
            this.GameRound = 0;
        }
        public void ChooseWeapon()
        {

            Console.WriteLine("Choose Rock, Paper, Scissors, Lizard, Spock");
            //RandomInt = Rnd.Next(1, 6);
            string WeaponChoice = Console.ReadLine();

            if (WeaponChoice == "Rock")
            {
                Console.WriteLine("Rock Crushes Lizard && Rock Crushes Scissors");
                Score++;
                GameRound++;
            }
            else if (WeaponChoice == "Paper")
            {
                Console.WriteLine("Paper Covers Rock && Paper Disproves Spock ");
                Score++;
                GameRound++;
            }
            else if (WeaponChoice == "Scissors")
            {
                Console.WriteLine("Scissors Cuts Paper && Scissors Decapitates Lizard");
                Score++;
                GameRound++;
            }
            else if (WeaponChoice == "Lizard")
            {
                Console.WriteLine("Lizard Poisons Spock && Lizards eat Paper");
                Score++;
                GameRound++;
            }
            else if (WeaponChoice == "Spock")
            {
                Console.WriteLine("Spock Vaporizes Rock &&  Spock Smashes Scissors");
                Score++;
                GameRound++;
            }



        }
  


       //constructor


        //method
        //player choose weapon//
        //1 or 2 player
        //compares player choices
    }
}
