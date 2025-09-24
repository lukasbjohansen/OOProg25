
NumberGenerator generator = new NumberGenerator();
BattleLog log = new BattleLog();

// Battle logic (1-on-1)
#region 1-on-1 battle logic
Hero theHero = new Hero(generator, log, "Olafur", 480, 25, 35);
Beast theBeast = new (generator, log, "Zakhial", 90, 10, 25);

while (!theHero.Dead && !theBeast.Dead)
{
    int damageByHero = theHero.DealDamage();
    theBeast.ReceiveDamage(damageByHero);

    if (!theBeast.Dead)
    {
        int damageByBeast = theBeast.DealDamage();
        theHero.ReceiveDamage(damageByBeast);
    }
}

log.PrintLog();
Console.WriteLine();
if (theBeast.Dead)
{
    Console.WriteLine($"The Hero {theHero.Name} was Victorious!!");
}
else
{
    Console.WriteLine($"The Beast {theBeast.Name} won... ;-(");
}
#endregion


// New battle logic (1-on-many)
#region 1-on-many battle logic
log.Reset();
theHero.Reset();
List<Beast> beasts = [
    new(generator, log, "Poul0", 40, 10, 25),
    new(generator, log, "Poul1", 30, 10, 25),
    new(generator, log, "Poul2", 45, 10, 25),
    new(generator, log, "Poul3", 25, 10, 25),
    new(generator, log, "Poul4", 27, 10, 25),
    new(generator, log, "Poul5", 10, 10, 25)
];
BeastArmy theArmy = new BeastArmy();
foreach (var beast in beasts)
{
    theArmy.AddBeast(beast);
}

while (!theHero.Dead && !theArmy.Dead)
{
    int damageByHero = theHero.DealDamage();
    theArmy.ReceiveDamage(damageByHero);

    if (!theArmy.Dead)
    {
        int damageByBeast = theArmy.DealDamage();
        theHero.ReceiveDamage(damageByBeast);
    }
}

log.PrintLog();
Console.WriteLine();
if (theArmy.Dead)
{
    Console.WriteLine($"The Hero {theHero.Name} was Victorious!!");
}
else
{
    Console.WriteLine($"The Beast army won... ;-(");
}
#endregion

theHero.Reset();
theArmy.Reset();

Simulator simulator = new Simulator(theHero, theArmy);
double percentage = simulator.Simulate(10000);
Console.WriteLine(percentage);