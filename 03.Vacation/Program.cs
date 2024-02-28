using System;
using System.Security.AccessControl;

internal class Program
{
    private static void Main(string[] args)
    {
        int group = int.Parse(Console.ReadLine());
        string type = Console.ReadLine();
        string day = Console.ReadLine();
        decimal pricePerPerson = 0m;
        decimal totalPrice = 0m;
        if (type == "Students" && day == "Friday")
        {
            pricePerPerson = 8.45M;
        }
        else if (type == "Students" && day == "Saturday")
        {
            pricePerPerson = 9.80M;
        }
        else if (type == "Students" && day == "Sunday")
        {
            pricePerPerson = 10.46M;
        }
        else if (type == "Business" && day == "Friday")
        {
            pricePerPerson = 10.90M;
        }
        else if (type == "Business" && day == "Saturday")
        {
            pricePerPerson = 15.60M;
        }
        else if (type == "Business" && day == "Sunday")
        {
            pricePerPerson = 16;
        }
        else if (type == "Regular" && day == "Friday")
        {
            pricePerPerson = 15;
        }
        else if (type == "Regular" && day == "Saturday")
        {
            pricePerPerson = 20;
        }
        else if (type == "Regular" && day == "Sunday")
        {
            pricePerPerson = 22.50M;
        }
        totalPrice = group * pricePerPerson;
        if (type == "Students" && group >= 30)
        {
            totalPrice = totalPrice * 0.85M;
        }
        else if (type == "Business" && group >= 100)
        {
            totalPrice = totalPrice - (pricePerPerson * 10);
        }
        else if (type == "Regular" && group >= 10 && group <= 20)
        {
            totalPrice = totalPrice * 0.95M;
        }
        Console.WriteLine($"Total price: {totalPrice:f2}");
    }
}