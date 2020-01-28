using System;

namespace exercise_45
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:

      int userInt = Convert.ToInt32(Console.ReadLine());

      int number = 0;

      while (number <= userInt) 
      {
        Console.WriteLine(number);
        number++;
      }

    }
  }
}
