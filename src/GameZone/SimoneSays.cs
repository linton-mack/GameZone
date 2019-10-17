
using System;
using System.Collections.Generic;
namespace GameZone
{
    class SimonSays
    {
        public void loadSimonSays()
        {
            Console.WriteLine("Welcome to Simon says:");
            List<string> tasks = new List<string>(){
                "Pick your nose",
                "Jump",
                "Waggle your finger",
                "Sleep"
            };

            Random rand = new Random();
            int seed = rand.Next(4);
            bool simonSaidIt = (seed == 0);
            int commandSeed = rand.Next(tasks.Count);


            if (simonSaidIt)
            {
                Console.WriteLine($"Simone says {tasks[commandSeed]}");
            }
            else
            {
                Console.WriteLine($"{tasks[commandSeed]}");
            }

            string userReaction = Console.ReadLine();

            if ((simonSaidIt && userReaction == tasks[commandSeed]) || !simonSaidIt && userReaction == "")
            {
                Console.WriteLine("Correct Answer");
            }
            else
            {
                Console.WriteLine("Incorrect Ansswer");
            }
        }
    }
}