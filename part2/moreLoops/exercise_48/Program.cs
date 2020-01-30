using System;

namespace exercise_48
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Give numbers:");
      int userInput = Convert.ToInt32(Console.ReadLine());
      int sum = 0;
      int counter = 0;
      int countEven = 0;
      int countOdd = 0;

      while (userInput != -1) 
      {
        sum = sum + userInput;
        userInput = Convert.ToInt32(Console.ReadLine());
        counter++;

        if (userInput % 2 == 0)
        {
          countEven++;
        }
        else        
        {
          countOdd++;
        }
      }

      double userAvg = (double)sum / counter;

      Console.WriteLine("Thx! Bye!");
      Console.WriteLine("Sum: " + sum);
      Console.WriteLine("Numbers: " + counter);
      Console.WriteLine("Average: " + userAvg);
      Console.WriteLine("Even: " + countEven);
      Console.WriteLine("Odd: " + countOdd);
    }
  }
}
