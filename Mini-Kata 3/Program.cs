int playerLuck = 6;

Console.WriteLine("You encounter an enemy! Do you want to attempt an attack? (yes/no)");
string playerChoice = Console.ReadLine().ToLower();

if (playerChoice == "yes")
{
    Console.WriteLine("Attempting to attack...");

    if (playerLuck > 7)
    {
        Console.WriteLine("Success! Your attack hits the enemy.");
    }
    else if (playerLuck == 6 || playerLuck == 7)
    {
        Console.WriteLine("Your attack barely succeeded!");
    }
    else
    {
        Console.WriteLine("Your attack missed.");
    }
}
else if (playerChoice == "no")
{
    Console.WriteLine("You chose to retreat.");
}
else
{
    Console.WriteLine("Invalid choice. Please respond with 'yes' or 'no'.");
}

    
