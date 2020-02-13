using System;

namespace exercise_113

{
  // DO NOT TOUCH THE CODE IN HERE
  public class Book
  {

    public string name { get; set; }
    public int pages { get; set; }
    public int year { get; set; }

    public Book(string name, int pages, int year)
    {
      this.name = name;
      this.pages = pages;
      this.year = year;
    }

    public override string ToString()
    {
      return this.name + ", " + this.pages + " pages" + ", " + this.year;
    }
  }
}