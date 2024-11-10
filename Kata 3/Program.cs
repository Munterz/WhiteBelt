int playerLuck = 8;

Console.WriteLine("You find a mysterious treasure chest! What will you do?");
Console.WriteLine("1. Open the chest");
Console.WriteLine("2. Ignore the chest");
Console.WriteLine("3. Leave the area");

string choice = Console.ReadLine();

if (choice == "1")
{
    Console.WriteLine("You try to open the chest...");

    if (playerLuck > 7)
    {
        Console.WriteLine("Success! The chest contains a rare gem.");
    }
    else if (playerLuck >= 5)
    {
        Console.WriteLine("You found some gold in the chest!");
    }
    else
    {
        Console.WriteLine("The chest was trapped! You lose some health.");
    }
}
else if (choice == "2")
{
    Console.WriteLine("You chose to ignore the chest and continue on your journey.");
}
else if (choice == "3")
{
    Console.WriteLine("You left the area, leaving the mystery of the chest unsolved.");
}
else
{
    Console.WriteLine("Invalid choice. Please select 1, 2, or 3.");
}
