using System;

namespace exercise_23
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

      double firstInt = Convert.ToInt32(firstInput);
      double secondInt = Convert.ToInt32(secondInput);

      Console.WriteLine(firstInt + " + " + secondInt + " = " + (firstInt + secondInt));
      Console.WriteLine(firstInt + " - " + secondInt + " = " + (firstInt - secondInt));
      Console.WriteLine(firstInt + " * " + secondInt + " = " + (firstInt * secondInt));
      Console.WriteLine(firstInt + " / " + secondInt + " = " + (firstInt / secondInt));

    }
  }
}
