using System;

namespace exercise_19
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

      Console.WriteLine(firstInt + " + " + secondInt + " = " + (firstInt + secondInt));

    }
  }
}
