class Simulator
{
    private Hero _hero;
    private BeastArmy _beastArmy;
    public Simulator(Hero hero, BeastArmy army) { 
        _hero = hero;
        _beastArmy = army;
    }
    private bool Fight()
    {
        while (!_hero.Dead && !_beastArmy.Dead)
        {
            int damageByHero = _hero.DealDamage();
            _beastArmy.ReceiveDamage(damageByHero);

            if (!_beastArmy.Dead)
            {
                int damageByBeast = _beastArmy.DealDamage();
                _hero.ReceiveDamage(damageByBeast);
            }
        }
        bool win = !_hero.Dead;
        _hero.Reset();
        _beastArmy.Reset();
        return win;
    }
    public double Simulate(int iterations)
    {
        int wins = 0;
        for (int i = 0; i < iterations; i++)
        {
            if (Fight()) wins++;
        }
        return (double) wins / iterations;
    }
}
