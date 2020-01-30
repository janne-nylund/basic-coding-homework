using System;

namespace exercise_60
{
  class Program
  {
    public static void PrintStars(int number)
    {
      // you can print one star with the command
      // Console.Write("*");
      // call the print command n times
      // in the end print a line break with the comand
      // Console.WriteLine("");
      for (int i = 0; i < number; i++)
      {
        Console.Write("*");
      }
      Console.WriteLine("");
    }

    public static void Main(String[] args)
    {
      PrintStars(5);
      PrintStars(3);
      PrintStars(9);
    }

  }
}
