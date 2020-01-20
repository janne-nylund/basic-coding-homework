using System;

namespace exercise_38
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      int countNegative = 0;

      while (true) 
      {
        Console.WriteLine("Give a number:");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number == 0) 
        {
          break;
        }
        if (number < 0)
        {
          countNegative++;
        }
      }

      Console.WriteLine("Total amount of negative numbers: " + countNegative);

    }
  }
}
