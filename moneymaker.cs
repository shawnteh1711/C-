using System;

#Money maker program

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");

      Console.WriteLine("Please enter amount");

      double amount = Math.Round(Convert.ToDouble(Console.ReadLine()));

      Console.WriteLine(amount + " cents is equal to ..");
      double goldValue = 10;

      double silverValue = 5;

      double goldCoins = Math.Floor(amount/goldValue);
      
      double leftover = amount % goldValue;

      double silverCoins = Math.Floor(leftover/silverValue);

      double remainder = leftover % silverValue;

      Console.WriteLine($"Gold coins:{goldCoins}");

      Console.WriteLine($"Silver coins: {silverCoins}");

      Console.WriteLine($"Bronze coins: {remainder}");


    }
  }
}
