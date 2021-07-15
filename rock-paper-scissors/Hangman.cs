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
            List<string> answers = new List<string> { "apples", "pear", "butts", "chicken butt" };
            string thisAnswer;
            Random wordPicker = new Random();
            thisAnswer = answers[wordPicker.Next(answers.Count)];
            List<string> emptySpaces = new List<string> { };
            bool hasWon = false;

            for (int i = 0; i < thisAnswer.Length - 1; i++)
            {
                emptySpaces.Add("_");
            }


            Console.WriteLine("Guess a letter!");
            
            do
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

                    for (int i = 0; i < thisAnswer.Length; i++)
                    {
                        if (thisAnswer[i].Equals(guess) == true)
                        {
                            emptySpaces[i] = Input;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("nope.");
                }

                        

                    //hasWon = true;

                
            }
            while (emptySpaces.Contains("_"));

            Console.WriteLine("Congrats! You won!");
        }
    }
}
