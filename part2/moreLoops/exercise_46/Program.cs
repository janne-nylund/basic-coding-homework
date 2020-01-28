using System;

namespace exercise_46
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      int userInt = Convert.ToInt32(Console.ReadLine());

      while (userInt <= 100) 
      {
        Console.WriteLine(userInt);
        userInt++;
      }

    }
  }
}
