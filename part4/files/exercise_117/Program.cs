﻿using System;
using System.IO;

namespace exercise_117
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Which file should have its contents printed?");
            string fileName = Console.ReadLine();

            // Ask the user for the file name and print the content of the file
            string[] lines = File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}