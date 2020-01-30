using System;

namespace exercise_52
{
  class Program
  {
    public static void Main(String[] args)
    {
      // Call your method here:
      PrintFromNumberToOne(5);
    }

    // Write your method here:
    public static void PrintFromNumberToOne(int number)
    {
      int i = number;
      while (i > 0) 
      {
      Console.WriteLine(i);
      i--;
      }
    }
  }
}
