using System;

namespace exercise_60
{
  class Program
  {
    public static void Main(String[] args)
    {
      PrintStars(9);
      
      PrintSquare(4);

      PrintRectangle(17,3);

      PrintTriangle(4);

    }


    public static void PrintStars(int number)
    {

      for (int i = 0; i < number; i++)
      {
        Console.Write("*");
      }
      Console.WriteLine("");
    }

    public static void PrintSquare(int size)
    {
      for (int y = 0; y < size; y++)
      {
        for (int x = 0; x < size; x++)
        {
          Console.Write("*");
        }
        Console.WriteLine("");
      }
    }

    public static void PrintRectangle(int width, int height)
    {
      for (int y = 0; y < height; y++)
      {
        for (int x = 0; x < width; x++)
        {
          Console.Write("*");
        }
        Console.WriteLine("");
      }
    }

    public static void PrintTriangle(int size)
    {
      for (int i = 0; i < size; i++)
      {
        for (int x = 0; x <= i; x++)
        {
          Console.Write("*");
        }
        Console.WriteLine("");
      }
    }
  }
}