using System;

namespace exercise_61
{
  class Program
  {
    public static void Main(String[] args)
    {
      //PrintSpaces(4);
      //PrintStars(4);
      //PrintRightTriangle(4);
      ChristmasTree(10);
    }

    public static void PrintStars(int stars)
    {
      for (int i = 0; i < stars; i++)
      {
        Console.Write("*");
      }
      Console.WriteLine("");
    }

    public static void PrintSpaces(int spaces)
    {
      for (int i = 0; i < spaces; i++)
      {
        Console.Write(" ");
      }
    }

    public static void PrintRightTriangle(int size)
    {
      int sizeLeft = size -1;
      for (int i = 1; i <= size; i++)
      {
        PrintSpaces(sizeLeft);
        PrintStars(i);
        sizeLeft--;
      }
    }

    public static void ChristmasTree(int size)
    {
      int sizeLeft = size - 1;
      int rowStars = 1;
      for (int i = 1; i <= size; i++)
      {
        PrintSpaces(sizeLeft);
        PrintStars(rowStars);
        sizeLeft--;
        rowStars += 2;
      }
      int footSpaces = size - 2;
      for (int x = 0; x < 2; x++)
      {
        PrintSpaces(footSpaces);
        PrintStars(3);
      }

    }
  }
}
