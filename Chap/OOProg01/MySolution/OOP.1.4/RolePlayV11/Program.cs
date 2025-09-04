/*
 * OOP.1.4 solution by Lukas Johansen
 */

Warrior warriorA = new Warrior("Ragnar", 100);
Warrior warriorB = new Warrior("Lagertha", 100);

// Battle to death
while (true) {
    int damage = warriorA.DealDamage();
    warriorB.TakeDamage(damage);
    Console.WriteLine($"{warriorA.Name} hit {warriorB.Name} for {damage} dmg.");
    if (warriorB.Dead) {
        Console.WriteLine($"{warriorB.Name} died with honor.");
        break;
    }
    damage = warriorB.DealDamage();
    warriorA.TakeDamage(damage);
    Console.WriteLine($"{warriorB.Name} hit {warriorA.Name} for {damage} dmg.");
    if (warriorA.Dead) {
        Console.WriteLine($"{warriorA.Name} died with honor.");
        break;
    }
}

Console.WriteLine($"Warrior A is named {warriorA.Name}, " +
                  $"and is level {warriorA.Level}");
Console.WriteLine($"Warrior B is named {warriorB.Name}, " +
                  $"and is level {warriorB.Level}");
