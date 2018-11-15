using System;
using System.Collections.Generic;
using System.Linq;

namespace Coins 
{
    public class Program
    {
        public static void Main()
        {
            CalculateCoins totalCoinAmount = new CalculateCoins();
            Console.WriteLine("Enter an amount of Cents to be converted to coins");
            int centCount = int.Parse(Console.ReadLine());
            totalCoinAmount.TotalCoins(centCount);

            Console.WriteLine("Your Change is Equal to: ");
            Console.WriteLine("Quarters: "+ totalCoinAmount.GetQuarters());
            Console.WriteLine("Dimes: "+ totalCoinAmount.GetDimes());
            Console.WriteLine("Nickels: "+ totalCoinAmount.GetNickels());
            Console.WriteLine("Pennies: "+ totalCoinAmount.GetPennies());
        }
    }

    public class CalculateCoins
    {
        private int _quarterAmount = 0;
        private int _dimeAmount = 0;
        private int _nickelAmount = 0;
        private int _pennyAmount = 0;

        public void TotalCoins(int input)
        {
            while (input > 0)
            {
                if (input >= 25)
                {
                    input = input - 25;
                    _quarterAmount ++;
                }
                else if (input >= 10 && input < 25)
                {
                    input = input - 10;
                    _dimeAmount ++;
                }
                else if (input >= 5 && input < 10)
                {
                    input = input - 5;
                    _nickelAmount ++;
                } 
                 else if (input < 5)
                {
                    input = input - 1;
                    _pennyAmount ++;
                } 
            }
        }

        public int GetQuarters()
        {
            return _quarterAmount;
        }
         public int GetDimes()
        {
            return _dimeAmount;
        }
         public int GetNickels()
        {
            return _nickelAmount;
        }
         public int GetPennies()
        {
            return _pennyAmount;
        }
    }
}
