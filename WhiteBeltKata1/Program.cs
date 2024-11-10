using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Welcome, brave adventurer! What is your name?");
        string name = Console.ReadLine();
        Console.WriteLine($"Greetings {name}! Your journey begins now...");
        Console.WriteLine("From a scale from 1 to 10 how excited are you to start this quest?");
        int choice = int.Parse(Console.ReadLine());

        if (choice >= 7)
        {
            Console.WriteLine("Awesome you seem ready to take on the challenge!");
        }
        else
        {
            {
                Console.WriteLine("No problem! As we complete these first challenges, you will feel the excitement begin to build!");
            }
        }
    }
}
