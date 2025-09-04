/*
 * OOP.1.3 solution by Lukas Johansen
 */

Warrior warriorA = new Warrior("Ragnar");
Warrior warriorB = new Warrior("Lagertha");

Console.WriteLine($"Warrior A is named {warriorA.Name}");
Console.WriteLine($"Warrior B is named {warriorB.Name}");

// Test level feature
Console.WriteLine($"Warrior A is level {warriorA.Level}");
warriorA.LevelUp();
Console.WriteLine($"Warrior A is now level {warriorA.Level}");