using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");
      
      Console.WriteLine("Enter an amount to convert to coins: ");
      string amountString = Console.ReadLine();

      double amountDouble = Convert.ToDouble(amountString);

      Console.WriteLine($"{amountDouble} cents is equal to ... ");

      int gold = 10;
      int silver = 5;

      double goldCoins = Math.Floor(amountDouble / gold);

      double coinsPostGold = amountDouble % gold;

      double silverCoins = Math.Floor(coinsPostGold / silver);

      double remainder = coinsPostGold % silver;

      Console.WriteLine($"Gold coins: {goldCoins}");
      Console.WriteLine($"Silver coins: {silverCoins}");
      Console.WriteLine($"Bronze coins: {remainder}");
      
      
    }
  }
}
