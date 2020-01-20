using System;

namespace exercise_35
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
        if (userNum == 42) 
        {
        break;
        }
      }

    }
  }
}
