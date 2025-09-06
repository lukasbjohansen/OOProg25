/*
 * OOP.1.7 solution by Lukas Johansen
 */

// Initialisation of sword objects
Sword excalibur = new Sword("Excalibur", 30, 70);
Sword nail = new Sword("Nail", 20, 60);

Warrior warriorA = new Warrior("Ragnar", 200, excalibur, damageFactor: 3);
Warrior warriorB = new Warrior("Lagertha", 240, nail, excalibur, .8);

warriorB.ToggleSwords();

Console.WriteLine("Just after creation:");
Console.WriteLine(warriorA.GetInfo());
Console.WriteLine(warriorB.GetInfo());
Console.WriteLine();

int damageFromA = warriorA.DealDamage();
int damageFromB = warriorB.DealDamage();
warriorA.ReceiveDamage(damageFromB);
warriorB.ReceiveDamage(damageFromA);

Console.WriteLine("After damage:");
Console.WriteLine(warriorA.GetInfo());
Console.WriteLine(warriorB.GetInfo());
Console.WriteLine();
