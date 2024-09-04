Random random = new Random();
int current = random.Next(1, 11);
// do while example
do
{
    current = random.Next(1, 11);

    if (current >= 8) continue;

    Console.WriteLine(current);
} while (current != 7);

// while example
while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");

// challenge hero rolls (1.6) score gets substracted from Monter health, if monster health is >0 Monster gets the same Turn
int heroHealth = 10;
int monsterHealth = 10; 

Random dice = new Random();
int currentRoll =0;

while (heroHealth > 0 && monsterHealth > 0) 
{
    currentRoll = dice.Next(1, 11);
    monsterHealth-= currentRoll;
    Console.WriteLine($"Monster was damaged and lost {currentRoll} health and now has {monsterHealth} health");
    if (monsterHealth > 0)
    {
        currentRoll = dice.Next(1, 11);
        heroHealth-= currentRoll;
        Console.WriteLine($"Hero was damaged and lost {currentRoll} health and now has {heroHealth} health");
    }
}
if (monsterHealth <= 0) Console.WriteLine("Hero wins");
if (heroHealth <= 0) Console.Write("Monster wins");
