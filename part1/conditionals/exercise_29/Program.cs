using System;

namespace exercise_29
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Give the first number!");
      string firstInput = Console.ReadLine();

      Console.WriteLine("Give the second number!");
      string secondInput = Console.ReadLine();

      int firstInt = Convert.ToInt32(firstInput);
      int secondInt = Convert.ToInt32(secondInput);
      

      if (firstInt > secondInt)
      {
        Console.WriteLine("The larger number is " + firstInt + "!");

      }
      else if (secondInt > firstInt)
      {
        Console.WriteLine("The larger number is " + secondInt + "!");
      }
      else
      {
        Console.WriteLine("They are equal!");
      }

    }
  }
}
