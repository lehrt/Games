using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rock_paper_scissors
{
    class Hangman
    {
        public static void HangMan()
        {
            string Input;
            List<string> answers = new List<string> { "apple", "pear", "orange", "peach", "watermelon", "greenpea", "nectarine", "cherry", "canteloupe", "tomato", "blueberry", "strawberry" };
            string thisAnswer;
            Random wordPicker = new Random();
            thisAnswer = answers[wordPicker.Next(answers.Count)];
            List<string> emptySpaces = new List<string> { };
            int roundCap = 6;

            for (int i = 0; i < thisAnswer.Length; i++)
            {
                emptySpaces.Add("_");
            }


            Console.WriteLine("Guess a letter!");

            List<string> deadMan = new List<string>
            {
                { "     ╔═════╗\n     O     ║\n    /│\\    ║\n    / \\    ║" },
                { "     ╔═════╗\n     O     ║\n    /│\\    ║\n    /      ║" },
                { "     ╔═════╗\n     O     ║\n    /│\\    ║\n           ║" },
                { "     ╔═════╗\n     O     ║\n    /│     ║\n           ║" },
                { "     ╔═════╗\n     O     ║\n     │     ║\n           ║" },
                { "     ╔═════╗\n     O     ║\n           ║\n           ║" },
                { "     ╔═════╗\n           ║\n           ║\n           ║" },

            };

            do
            {
                Console.WriteLine(deadMan[roundCap]);
                try
                {
                    foreach (string i in emptySpaces)
                    {
                        Console.Write(i + " ");
                    }
                    Input = Console.ReadLine();
                    if (thisAnswer.Contains(Input) == true)
                    {
                        Console.WriteLine("Correct!");
                        char guess = Input[0];

                        try
                        {
                            for (int i = 0; i < thisAnswer.Length; i++)
                            {
                                if (Input.Length > 1)
                                {
                                    throw new ArgumentException();
                                }
                                else if (thisAnswer[i].Equals(guess) == true)
                                {
                                    emptySpaces[i] = Input;
                                }
                            }
                        }
                        catch
                        {
                            Console.WriteLine("Please enter a single letter");
                        }
                    }
                    else if (thisAnswer.Contains(Input) != true)
                    {
                        Console.WriteLine("Nope!");
                        roundCap--;
                        Console.WriteLine($"You have {roundCap} incorrect attempts remaining");
                    }
                    else if (Input == "" || Input == " ")
                    {
                        throw new ArgumentOutOfRangeException("Hey you have to input a letter bro");
                    }
                    else if (!emptySpaces.Contains("_"))
                    {
                        Console.WriteLine("Congrats! You won!");
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("Please enter a letter!");
                }
            }
                while (emptySpaces.Contains("_") && (roundCap != 0)) ;

                if (roundCap == 0)
                {
                       Console.WriteLine(deadMan[0]);
                    Console.WriteLine("You lost. but baby bunnies and shit.");
                }
                else
                {
                    Console.WriteLine(thisAnswer);
                    Console.WriteLine("CONGRATS YOU WON!!!!!" + "");
                }


        }
    }
}
