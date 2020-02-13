﻿using System;
using System.Collections.Generic;

namespace exercise_113
{
  class Program
  {
    public static void Main(string[] args)
    {
      // IMPLEMENT YOUR CODE IN HERE!
      // Remember also to create the file Book.cs and class in it!

      List<Book> list = new List<Book>();

            while (true)
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();
                if (name == "")
                {
                    break;
                }
                Console.Write("Pages: ");
                int pages = Convert.ToInt32(Console.ReadLine());

                Console.Write("Publication year: ");
                int year = Convert.ToInt32(Console.ReadLine());

                list.Add(new Book(name, pages, year));
            }
            Console.WriteLine();
            Console.Write("What information will be printed? ");
            string printed = Console.ReadLine();

            foreach (Book item in list)
            {
              if (printed == "everything")
              {
                Console.WriteLine(item);
              }
              else if (printed == "title")
              {
                Console.WriteLine(item.name);
              }
              else {
                break;
              }
            }
    }
  }
}