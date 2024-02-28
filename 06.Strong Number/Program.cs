using System;
internal class Program
{
    private static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        int input = number;
        int sum = 0;
        while (number > 0)
        {
            int n = number % 10;
            int fact = 1;

            for (int i = 1; i <= number; i++)
            {
                fact *= i;
            }
            sum += fact;
            n /= 10;
        }
        if(input == sum)
        {
            
            Console.WriteLine("yes");
        }
        else 
        {
            Console.WriteLine("no");
        }
    }
}