using System;

namespace exercise_47
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Where to?");
      int userEnd = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Where from?");
      int userStart = Convert.ToInt32(Console.ReadLine());

      int counter = userStart;

      while (counter <= userEnd) 
      {
        Console.WriteLine(counter);
        counter++;
      }
      
    }
  }
}
