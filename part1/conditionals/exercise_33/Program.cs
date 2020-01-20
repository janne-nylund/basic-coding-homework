using System;

namespace exercise_33
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Give the first string:");
      string firstInput = Console.ReadLine();

      Console.WriteLine("Give the second string:");
      string secondInput = Console.ReadLine();

      if (firstInput == secondInput)
      {
        Console.WriteLine("Echo!");
      }
      else
      {
        Console.WriteLine("Nope!");
      }

    }
  }
}
