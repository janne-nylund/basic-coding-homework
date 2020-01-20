using System;

namespace exercise_18
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

      Console.WriteLine("Give the third number!");
      string thirdInput = Console.ReadLine();

      int firstInt = Convert.ToInt32(firstInput);
      int secondInt = Convert.ToInt32(secondInput);
      int thirdInt = Convert.ToInt32(thirdInput);

      Console.WriteLine("The sum is " + (firstInt + secondInt + thirdInt));

    }
  }
}
