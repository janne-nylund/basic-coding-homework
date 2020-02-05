using System;
using System.Collections.Generic;

namespace exercise_74
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<string> list = new List<string>();
      while (true)
      {
        string input = Console.ReadLine();
        if (input == "")
        {
          break;
        }
        list.Add(input);
      }

      Console.WriteLine("Search for?");
      string userInput = Console.ReadLine();

      int match = 0;

      for (int index = 0; index < list.Count; index++) 
      {
        if (userInput == list[index])
          {
            match += 1;
          }
      }

      if (match > 0)
      {
        Console.WriteLine(userInput + " was found!");
      }
      else 
      {
        Console.WriteLine(userInput + " was not found!");
      }
    }
  }
}