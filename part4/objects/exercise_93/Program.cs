using System;

namespace exercise_93
{
  class Program
  {
    public static void Main(string[] args)
    {
      // DO NOT TOUCH THE OTHER FILE!
      // Do your code here!
      Account jannesAccount = new Account("Janne's account", 100.00);
      jannesAccount.Deposit(20);
      Console.WriteLine(jannesAccount.balance);
    }
  }
}



