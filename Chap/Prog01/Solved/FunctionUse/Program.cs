
// PART 1
// The length of a string is the number of characters in the string

string heroName = "Alexandra";

Console.WriteLine($"The length of the name {"Per"} is {NameLength("Per")}");  // 3 is correct
Console.WriteLine($"The length of the name {"Peter"} is {NameLength("Peter")}"); // 5 is correct
Console.WriteLine($"The length of the name {heroName} is {NameLength(heroName)}");
Console.WriteLine();


// PART 2
// The damage dealt by a Level L player with D base damage is
// L * (Logarithm(D) + 1), rounded to nearest lower integer. (Yuck...)

int heroLevel = 4;
int heroBaseDamage = 55;

Console.WriteLine($"The damage dealt by a level {1} player with {20} base damage is {DamageDealt(1, 20)}"); // 20 is correct
Console.WriteLine($"The damage dealt by a level {3} player with {30} base damage is {DamageDealt(3, 30)}"); // 63 is correct
Console.WriteLine($"The damage dealt by a level {7} player with {60} base damage is {DamageDealt(7, 60)}"); // 177 is correct
Console.WriteLine($"The damage dealt by a level {heroLevel} player with {heroBaseDamage} base damage is {DamageDealt(heroLevel, heroBaseDamage)}");
Console.WriteLine($"The damage dealt by a level {heroLevel} player with {heroBaseDamage} base damage is {DamageDealt(heroBaseDamage, heroLevel)}"); // OOPS!!
Console.WriteLine();



// Given functions

int NameLength(string name)
{
	int length = name.Length;
	return length;
}


int DamageDealt(int level, int baseDamage)
{
	double rawDamage = baseDamage * (Math.Log(level) + 1);
	int damage = Convert.ToInt32(rawDamage);
	return damage;
}


