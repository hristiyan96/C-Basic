using System;
using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        string coin =  Console.ReadLine();
        decimal sumCoins = 0;
        while (coin != "Start")
        {
            switch (coin)
            {
                case "0.1":
                case "0.2":
                case "0.5":
                case "1":
                case "2":
                    sumCoins = sumCoins + decimal.Parse(coin);
                    break;
                default:
                    Console.WriteLine($"Cannot accept {coin}");
                    break;



            }
            coin = Console.ReadLine();
        }
            string product = Console.ReadLine();
            decimal price = 0;

            while (product != "End")
            {


                switch (product)
                {
                    case "Nuts":
                        price = 2.0m;
                        break;
                    case "Water":
                        price = 0.7m;
                        break;
                    case "Crisps":
                        price = 1.5m;
                        break;
                    case "Soda":
                        price = 0.8m;
                        break;
                    case "Coke":
                        price = 1.0m;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;



                }


                if (sumCoins >= price && sumCoins > 0 && price > 0)
                {
                    Console.WriteLine($"Purchased {product.ToLower()}");
                    sumCoins = sumCoins - price;
                    price = 0;
                }
                else if (price > 0)
                {
                    Console.WriteLine("Sorry, not enough money");
                    price = 0;
                }

                product = Console.ReadLine();
            }
            Console.WriteLine($"Change: {sumCoins:f2}");
        



            
        
        
    }
}