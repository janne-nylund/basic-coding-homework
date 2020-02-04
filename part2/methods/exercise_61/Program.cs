using System;

namespace exercise_61
{
  class Program
  {
    public static void Main(String[] args)
    {
      //PrintSpaces(4);
      //PrintStars(4);
      PrintRightTriangle(4);
      ChristmasTree(10);
    }

    public static void PrintStars(int number)
    {
      for (int i = 0; i < number; i++)
      {
        Console.Write("*");
      }
      Console.WriteLine("");
    }

    public static void PrintSpaces(int number)
    {
      for (int i = 0; i < number; i++)
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

    public static void ChristmasTree(int height)
    {
      int sizeLeft = height - 1;
      int rowStars = 1;
      for (int i = 1; i <= height; i++)
      {
        PrintSpaces(sizeLeft);
        PrintStars(rowStars);
        sizeLeft--;
        rowStars += 2;
      }
      int footSpaces = height - 2;
      for (int x = 0; x < 2; x++)
      {
        PrintSpaces(footSpaces);
        PrintStars(3);
      }

    }
  }
}
