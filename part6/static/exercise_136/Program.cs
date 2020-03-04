using System;
using System.Collections.Generic;

namespace exercise_136
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Person ada = new Person("Ada Lovelace");
            Person jack = new Person("Jack The Ripper");
            Person mike = new Person("Mike The Incredible Magic Mouse");

            HowManyNames(ada);
            HowManyNames(jack);
            HowManyNames(mike);
        }

        // Do something here

        public static void HowManyNames(Person person)
        {
            string name = person.ToString();
            string[] pieces = name.Split(" ");
            int numberOfNames = 0;

            for (int i = 0; i < pieces.Length; i++)
            {
                numberOfNames++;
            }
            Console.WriteLine(person.ToString() + " has " + numberOfNames + " names.");
        }
    }
}