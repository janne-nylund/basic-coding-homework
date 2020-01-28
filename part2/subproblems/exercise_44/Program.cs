using System;

namespace exercise_44
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      int userInt1 = Convert.ToInt32(Console.ReadLine());
      int userInt2 = Convert.ToInt32(Console.ReadLine());

      if (userInt1 > userInt2) 
      {
        Console.WriteLine(userInt1 + " is greater than " + userInt2 + ".");
      }
      else if (userInt1 < userInt2)
      {
        Console.WriteLine(userInt1 + " is less than " + userInt2 + ".");
      }   
      else 
      {
        Console.WriteLine(userInt1 + " is equal to " + userInt2 + ".");
      }

    }
  }
}
