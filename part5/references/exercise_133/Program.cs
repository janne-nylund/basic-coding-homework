using System;
using System.Collections.Generic;

namespace exercise_133
{
  class Program
  {
    public static void Main(string[] args)
    {
      Money money = new Money(100, 11);
      Money moreMoney = new Money(30, 11);

      Money combined = money.Plus(moreMoney);
      Money subtracted = money.Minus(moreMoney);

      Console.WriteLine(money);
      Console.WriteLine(moreMoney);
      Console.WriteLine(combined);
      Console.WriteLine(subtracted);

      Console.WriteLine(money.LessThan(moreMoney));
    }
  }
}
