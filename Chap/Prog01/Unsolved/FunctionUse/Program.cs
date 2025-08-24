
// PART 1
// The length of a string is the number of characters in the string
Console.WriteLine($"The length of the name {"Per"} is {3}");  // 3 is correct
Console.WriteLine($"The length of the name {"Peter"} is {3}"); // 5 is correct
Console.WriteLine();


// PART 2
// The damage dealt by a Level L player with D base damage is
// L * (Logarithm(D) + 1), rounded to nearest lower integer. (Yuck...)
Console.WriteLine($"The damage dealt by a level {1} player with {20} base damage is {20}"); // 20 is correct
Console.WriteLine($"The damage dealt by a level {3} player with {30} base damage is {20}"); // 63 is correct
Console.WriteLine($"The damage dealt by a level {7} player with {60} base damage is {20}"); // 177 is correct
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


