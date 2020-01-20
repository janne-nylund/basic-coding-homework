using System;

namespace exercise_10
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Write your code here:
            Console.WriteLine("I will tell a story, but I need some information.");
            Console.WriteLine("Give a name for main character:");

            string charName = Console.ReadLine();

            Console.WriteLine("Give the character a profession:");

            string charProf = Console.ReadLine();

            Console.WriteLine("Here is the story:\n" +
            "Once upon a time there was a " + charProf + " called " + charName + "\n" +
            "On her way to work, " + charName + " often pondered what being " + charProf + " meant to them.\n" +
            "When you work as a " + charProf + " you meet interesting people.\n" +
            charName + " enjoys their work as " + charProf + ", The end.");



        }
    }
}
