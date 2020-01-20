using System;

namespace exercise_24
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Your speed:");

      string userSpeed = Console.ReadLine();

      int intSpeed = Convert.ToInt32(userSpeed);

      if (intSpeed > 120)
      {
        Console.WriteLine("Speeding!");
      }
    }
  }
}
