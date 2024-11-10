string name = "Lira";
int level = 5;
float healthPoints = 75.5f;
double experiencePoints = 529.28;
bool hasMagicAbility = true;
char rank = 'A';

double nextLevelThreshold = 1000.0;
double pointsToNextLevel = nextLevelThreshold - experiencePoints;

Console.WriteLine($"Character name: {name}");
Console.WriteLine($"Level: {level}");
Console.WriteLine($"Health points: {healthPoints}");
Console.WriteLine($"Experience points: {experiencePoints}");
Console.WriteLine($"Has Magic ability: {hasMagicAbility}");
Console.WriteLine($"Rank: {rank}");
Console.WriteLine($"Points needed to reach the next level: {pointsToNextLevel}");