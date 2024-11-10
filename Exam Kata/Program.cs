using System;

class Program
{
    static void Main()
    {
        int playerHealth = 100;
        int playerAttackPower = 15;
        int playerHealAmount = 10;

        int enemyHealth = 50;
        int enemyAttackPower = 10;

        while (playerHealth > 0 && enemyHealth > 0)
        {
            Console.WriteLine($"\nHero's Health: {playerHealth}");
            Console.WriteLine($"Goblin's Health: {enemyHealth}");
            
            Console.WriteLine("\nChoose an action:");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Heal");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Hero attacks the Goblin!");
                enemyHealth -= playerAttackPower;
                Console.WriteLine($"Goblin takes {playerAttackPower} damage.");
            }
            else if (choice == "2")
            {
                Console.WriteLine("Hero heals himself.");
                playerHealth += playerHealAmount;
                Console.WriteLine($"Hero gains {playerHealAmount} health.");
            }
            else
            {
                Console.WriteLine("Invalid choice! Please select 1 or 2.");
                continue;
            }
            
            if (enemyHealth <= 0)
            {
                Console.WriteLine("\nCongratulations! Hero has defeated the Goblin!");
                break;
            }
            
            Console.WriteLine("Goblin attacks Hero!");
            playerHealth -= enemyAttackPower;
            Console.WriteLine($"Hero takes {enemyAttackPower} damage.");
            
            if (playerHealth <= 0)
            {
                Console.WriteLine("\nThe Goblin has defeated the Hero. Game over.");
                break;
            }
        }
    }
}
