
World theWorld = new World();

Fighter xara = new Fighter("Xara", 50, GameExperience.Low);
Fighter eron = new Fighter("Eron", 110, GameExperience.Mid);
Fighter dani = new Fighter("Dani", 170, GameExperience.High);

ExecuteScenario(xara, DayState.Day);
ExecuteScenario(xara, DayState.Night);
ExecuteScenario(eron, DayState.Day);
ExecuteScenario(eron, DayState.Night);
ExecuteScenario(dani, DayState.Day);
ExecuteScenario(dani, DayState.Night);


void ExecuteScenario(Fighter fighter, DayState dayState)
{
	theWorld.DayOrNight = dayState;
	theWorld.TheFighter = fighter;
	theWorld.GenerateEncounter();
}