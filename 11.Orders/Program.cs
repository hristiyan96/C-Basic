﻿using System;
internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        
        double totalPrice = 0;

        for(int i  = 0; i < n; i++)
        {
            double pricePerCapsule = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int capsules = int.Parse(Console.ReadLine());
            double price = (days * capsules) * pricePerCapsule;
            totalPrice += price;
            Console.WriteLine($"The price for the coffee is: ${price:f2}");
        }
        Console.WriteLine($"Total: ${totalPrice:f2}");
        

    }
}