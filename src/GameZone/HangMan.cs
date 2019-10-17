using System;
using System.Linq;

namespace GameZone
{
    public class HangMan
    {
        private int lives = 5;
        private string wordToFind = null;
        private string[] wordBank =
            {"cast", "chose", "claws", "coach", "constantly", "contrast", "cookies", "customs", "damage"};


        public void LoadHangMan()
        {
            LoadWelcomeGameInfo();
            GenerateWordToUse();

            char[] foundChars = Enumerable.Repeat('-', wordToFind.Length).ToArray();
            Console.WriteLine("");
            Console.WriteLine(foundChars);
            Console.WriteLine("");

            PromptUser(foundChars);
        }

        public void LoadWelcomeGameInfo()
        {
            Console.WriteLine("/////////////////////////////");
            Console.WriteLine("//// WELCOME TO HANGMAN /////");
            Console.WriteLine("/////////////////////////////");
            Console.WriteLine("");

            Console.WriteLine($">>> You have {lives} left to guess the correct word<<<");
            Console.WriteLine("");
        }

        public void GenerateWordToUse()
        {
            Random rand = new Random();
            int randCount = rand.Next(wordBank.Length);

            wordToFind = wordBank[randCount];

            Console.WriteLine($">>>> TIP: This word has {wordToFind.Length} characters in it.<<<");
            Console.WriteLine("");
        }

        private void PromptUser(char[] foundChars)
        {
            Console.WriteLine(">>> User Prompt: Enter a character");
            string userInput = Console.ReadLine();
            Console.WriteLine("");


            if (CheckUserInput(userInput, foundChars))
            {
                HandleCorrectGuess(foundChars);
            }
            else
            {
                HandleIncorrectGuess(foundChars);
            }
        }

        public Boolean CheckUserInput(string userInput, char[] foundChars)
        {
            Boolean isMatch = false;
            for (int i = 0; i < wordToFind.Length; i++)
            {
                if (wordToFind[i].ToString() == userInput)
                {
                    foundChars[i] = wordToFind[i];
                    isMatch = true;
                }
            }
            return isMatch;
        }

        public void HandleIncorrectGuess(char[] foundChars)
        {
            SetLives(lives - 1);
            Console.WriteLine($"Incorrect answer you loose a life, {lives} remaining.");
            Console.WriteLine(foundChars);
            if (lives < 1)
            {
                Console.WriteLine(">>> Unlucky, you loose :( <<<");
                Console.WriteLine($">>> The Correct Word Was: {wordToFind} <<<");

                return;
            }
            PromptUser(foundChars);
        }

        public void HandleCorrectGuess(char[] foundChars)
        {
            Console.WriteLine(">>> Correct answer!");
            Console.WriteLine(foundChars);
            if (IsGameWon(foundChars))
            {
                Console.WriteLine(">>> You Completed The Game! <<<");
                return;
            }

            PromptUser(foundChars);
        }

        public Boolean IsGameWon(char[] foundChars)
        {
            Boolean isWon = true;
            for (int i = 0; i < foundChars.Length; i++)
            {
                if (foundChars[i] == '-')
                {
                    isWon = false;
                }
            }
            return isWon;
        }

        public string GetWordToFind
        {
            get
            {
                return wordToFind;
            }
        }

        public void SetLives(int newLife)
        {
            lives = newLife;
        }
        public void SetWordToFind(string newWord)
        {
            wordToFind = newWord;
        }

        public int GetHangManLives
        {
            get
            {
                return lives;
            }
        }
    }
}