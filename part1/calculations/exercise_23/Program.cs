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

      double firstInt = Convert.ToDouble(firstInput);
      double secondInt = Convert.ToDouble(secondInput);

      Console.WriteLine(firstInt + " + " + secondInt + " = " + (firstInt + secondInt));
      Console.WriteLine(firstInt + " - " + secondInt + " = " + (firstInt - secondInt));
      Console.WriteLine(firstInt + " * " + secondInt + " = " + (firstInt * secondInt));
      Console.WriteLine(firstInt + " / " + secondInt + " = " + (firstInt / secondInt));

    }
  }
}
