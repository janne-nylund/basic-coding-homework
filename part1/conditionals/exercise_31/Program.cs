using System;

namespace exercise_31
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Give a number:");
      string userInput = Console.ReadLine();

      int userInt = Convert.ToInt32(userInput);

      if (userInt % 2 == 0)
      {
        Console.WriteLine("It is even.");
      }
      else
      {
        Console.WriteLine("It is odd.");
      }
    }
  }
}
