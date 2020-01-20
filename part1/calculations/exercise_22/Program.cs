using System;

namespace exercise_22
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
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

      double average = (firstInt + secondInt + thirdInt) / 3.0;

      Console.WriteLine("The average is " + average);

    }
  }
}
