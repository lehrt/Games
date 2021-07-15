using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rock_paper_scissors
{
    class GameStart
    {
        public string GameType { get; set; }
        static public void PlayGame(string game)
        {
            if (game == "rock paper scissors")
            {
                Console.WriteLine("Rock, paper, scissors.... go!");
                string weaponOfChoice = Console.ReadLine();
                rock_paper_scissors.RockPaperScissors(weaponOfChoice);
            }
            else if (game == "hangman")
            {
                Console.WriteLine("Let's play hangman! Guess the word.");
                Hangman.HangMan();
            }
            else
            {
                Console.WriteLine("No game selected");
            }
        }
    }
}
