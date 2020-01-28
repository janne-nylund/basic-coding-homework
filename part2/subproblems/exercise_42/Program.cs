using System;

namespace exercise_42
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      int userInt1 = Convert.ToInt32(Console.ReadLine());
      int userInt2 = Convert.ToInt32(Console.ReadLine());

      int sum = userInt1 + userInt2;

      double squareRoot = Math.Sqrt(sum);
      Console.WriteLine(squareRoot);
    
    }
  }
}
