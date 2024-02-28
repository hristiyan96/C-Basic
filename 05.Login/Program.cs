using System;
internal class Program
{
    private static void Main(string[] args)
    {
        string username = Console.ReadLine();
        string reverse = string.Empty;
        int count = 0;
        for(int i = username.Length - 1; i >= 0; i--)
        {
            reverse += username[i];
        }
        while(true)
        {
            string attempt = Console.ReadLine();
            if(attempt != reverse)
            {
                count++;
                if(count == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");
            }
            else
            {
                Console.WriteLine($"User {username} logged in.");
                break;
            }
        }
    }
}