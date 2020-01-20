using System;

namespace exercise_30
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Give your percent [0 - 100]:");
      string userInput = Console.ReadLine();

      int percent = Convert.ToInt32(userInput);
      

      if (percent > 0 && percent < 50)
      {
        Console.WriteLine("Fail");

      }
      else if (percent > 49 && percent < 60)
      {
        Console.WriteLine("Grade: 1");
      }
      else if (percent > 59 && percent < 70)
      {
        Console.WriteLine("Grade: 2");
      }
      else if (percent > 69 && percent < 80)
      {
        Console.WriteLine("Grade: 3");
      }
      else if (percent > 79 && percent < 90)
      {
        Console.WriteLine("Grade: 4");
      }
      else if (percent > 89 && percent <= 100)
      {
        Console.WriteLine("Grade: 5");
      }
      else if (percent > 100)
      {
        Console.WriteLine("Outstanding!");
      }
      else
      {
        Console.WriteLine("Impossible");
      }

    }
  }
}
