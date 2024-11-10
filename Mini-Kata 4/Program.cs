Console.WriteLine("Spawning enemies using a for loop: ");
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine($"Enemy #{i} spawned!");
}

Console.WriteLine("\nSpawning enemies using a while loop: ");
int enemiesSpawned = 1;
int maxEnemies = 3;

while (enemiesSpawned <= maxEnemies)

{
    Console.WriteLine($"Enemy #{enemiesSpawned} spawned!");
    enemiesSpawned++;
}