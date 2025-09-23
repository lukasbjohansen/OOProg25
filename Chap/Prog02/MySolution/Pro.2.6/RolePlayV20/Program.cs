
NumberGenerator theNumberGenerator = new NumberGenerator();
BattleLog theLog = new BattleLog();

Hero theHero = new Hero(theNumberGenerator, theLog, 100, 20, 30);
Beast theBeast = new Beast(theNumberGenerator, theLog);

// Now battle...How do we do that (Hint: You need a loop)

while (!theHero.Dead && !theBeast.Dead)
{
    theBeast.ReceiveDamage(theHero.DealDamage());
    if (!theBeast.Dead) theHero.ReceiveDamage(theBeast.DealDamage());
}

theLog.PrintLog();
