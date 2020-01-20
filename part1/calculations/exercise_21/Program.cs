using System;

namespace exercise_21
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

      Console.WriteLine("The average is " + ((firstInt + secondInt) / 2.0));

    }
  }
}
