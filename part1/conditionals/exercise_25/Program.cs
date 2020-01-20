using System;

namespace exercise_25
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Give a number:");
      string userInput = Console.ReadLine();

      int userInt = Convert.ToInt32(userInput);

      if (userInt == 1984)
      {
        Console.WriteLine("Orwell");
      }

    }
  }
}
