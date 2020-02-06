using System;
using System.Collections.Generic;

namespace exercise_92
{
    class Program
    {
        public static void Main(string[] args)
        {
            int oldest = 0;
            int age = 0;
            string name = "";
            int nameLength = 0;
            int longest = 0;
            string longestName = "";

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }
                string[] pieces = input.Split(",");
                age = 2020 - Convert.ToInt32(pieces[1]);
                name = pieces[0];
                nameLength = name.Length;

                if (oldest < age)
                {
                    oldest = age;
                }
               
                if (longest < nameLength)
                {
                    longest = nameLength;
                    longestName = name;
                }
         
            }
            Console.WriteLine("Longest name: " + longestName);
            Console.WriteLine("Highest age: " + oldest);
            
        }
    }
}