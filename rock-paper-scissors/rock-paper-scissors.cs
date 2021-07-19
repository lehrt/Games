using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rock_paper_scissors
{
    class rock_paper_scissors
    {
        public static void RockPaperScissors(string weapon)
        {
            Random rand = new Random();
            int random = rand.Next(0, 2);
            string[] RockPaperScissors = { "rock", "paper", "scissors" };
            string randomWeapon = RockPaperScissors[random];
            try
            {
                if (weapon == randomWeapon)
                {
                    Console.WriteLine($"{weapon} vs. {randomWeapon}!! It's a draw!");
                }
                else if ((weapon == "scissors") && (randomWeapon == "paper"))
                {
                    Console.WriteLine($"{weapon} vs. {randomWeapon}!! You win!");
                }
                else if ((weapon == "paper") && (randomWeapon == "rock"))
                {
                    Console.WriteLine($"{weapon} vs. {randomWeapon}!! You win!");
                }
                else if ((weapon == "rock") && (randomWeapon == "paper"))
                {
                    Console.WriteLine($"{weapon} vs. {randomWeapon}!! You win!");
                }
                else if ((weapon != "rock") || (weapon != "paper") || (weapon != "scissors"))
                {
                    throw new ArgumentOutOfRangeException("Must be one of three options for rock paper scissors");
                }
                else
                {
                    Console.WriteLine($"{weapon} vs. {randomWeapon}!! You LOSE!!!");
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Dude, you have to play either rock, paper or scissors. You know this.");
            }
        }

    }
}
