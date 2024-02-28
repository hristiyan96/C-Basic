using System;
internal class Program
{
    private static void Main(string[] args)
    {
        float money = float.Parse(Console.ReadLine());
        int numOfStudents = int.Parse(Console.ReadLine());
        double lightsaber = double.Parse(Console.ReadLine());
        double robe = double.Parse(Console.ReadLine());
        double belt = double.Parse(Console.ReadLine());
        double neededEquipment = 0;
        double freeBelts = numOfStudents / 6;
        double students1 = Math.Ceiling((numOfStudents * 0.1) + numOfStudents);
        neededEquipment = (students1 * lightsaber) + (numOfStudents * robe) + ((numOfStudents-freeBelts) * belt);

        if(neededEquipment > money)
        {
            Console.WriteLine($"John will need {neededEquipment - money:f2}lv more.");
        }
        else if(neededEquipment <= money)
        {
            Console.WriteLine($"The money is enough - it would cost {neededEquipment:f2}lv.");
        }
        




    }
}