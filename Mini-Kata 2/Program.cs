string character = "Neo";
int playerHealth = 100;
float attackPower = 25.5f;
float experience = 99.99f;
bool isParalyzed = false;
double silverAmount = 72.3;

double healthAsDouble = playerHealth;
Console.WriteLine($"Health as double (implicit conversion): {healthAsDouble}");

int attackPowerAsInt = (int)attackPower;
Console.WriteLine($"Attack Power as int (explicit conversion): {attackPowerAsInt}");

int experienceAsInt = Convert.ToInt32(experience);
Console.WriteLine($"Experience as int (using Convert): {experienceAsInt}");

string currencyString = "150.3333333";
double currencyParsed;
if (double.TryParse(currencyString, out currencyParsed))
{
    Console.WriteLine($"Gold Coins (parsed from string): {currencyParsed}");
}    
else
{
    Console.WriteLine($"Parsing failed for currency string: '{currencyString}'");
}

if (int.TryParse(character, out int characterAsInt))
{
    Console.WriteLine($"Character name as int: {characterAsInt}");
}
else
{
    Console.WriteLine($"Parsing failed: '{character}' is not a number.");
}