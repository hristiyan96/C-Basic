using System;
internal class Program
{
    private static void Main(string[] args)
    {
       int lostGames = int.Parse(Console.ReadLine());
        decimal headset = decimal.Parse(Console.ReadLine());
        decimal mouse = decimal.Parse(Console.ReadLine());
        decimal keyboard = decimal.Parse(Console.ReadLine());
        decimal display = decimal.Parse(Console.ReadLine());

        decimal trashedHeadset = (lostGames/2) * headset;
        decimal trashedMouse = (lostGames/3) * mouse;
        decimal trashedKeyboard = (lostGames/6) * keyboard;
        decimal trashedDisplay = (lostGames/12) * display;
        
        decimal expenses = trashedHeadset + trashedMouse + trashedKeyboard + trashedDisplay;
        Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
            
    }
}