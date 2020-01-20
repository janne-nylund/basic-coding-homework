using System;

namespace exercise_36
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      while (true) 
      {
        Console.WriteLine("Give a number:");
        int userNum = Convert.ToInt32(Console.ReadLine());
        if (userNum == 0) 
        {
          break;
        }
        else if (userNum > 0)
        {
          Console.WriteLine(userNum * userNum);
        }
        else 
        {
          Console.WriteLine("That is negative");

        }

      }

    }
  }
}
