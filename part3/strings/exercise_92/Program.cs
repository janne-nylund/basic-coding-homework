using System;
using System.Collections.Generic;

namespace exercise_92
{
    class Program
    {
        public static void Main(string[] args)
        {
            int oldest = Convert.ToInt32(DateTime.Now.Year + 1);
            string longestName = "";

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }

                string[] pieces = input.Split(",");

                if (oldest > Convert.ToInt32(pieces[1]))
                {
                    oldest = Convert.ToInt32(pieces[1]);
                }

                if (longestName.Length < pieces[0].Length)
                {
                    longestName = pieces[0];
                }
            }
            Console.WriteLine("Longest name: " + longestName);
            Console.WriteLine("Highest age: " + (Convert.ToInt32(DateTime.Now.Year) - oldest));
        }
    }
}