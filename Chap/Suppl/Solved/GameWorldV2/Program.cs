
World theWorld = new World();

Fighter xara = new Fighter("Xara", 50, GameExperience.Low);
Fighter eron = new Fighter("Eron", 110, GameExperience.Mid);
Fighter dani = new Fighter("Dani", 170, GameExperience.High);

IOpponentFactory oppFacSta = new OpponentFactoryStandard();
IOpponentFactory oppFacExt = new OpponentFactoryExtended();

Console.WriteLine("Testing OpponentFactoryStandard...");
ExecuteScenario(xara, DayState.Day, oppFacSta);
ExecuteScenario(xara, DayState.Night, oppFacSta);
ExecuteScenario(eron, DayState.Day, oppFacSta);
ExecuteScenario(eron, DayState.Night, oppFacSta);
ExecuteScenario(dani, DayState.Day, oppFacSta);
ExecuteScenario(dani, DayState.Night, oppFacSta);
Console.WriteLine();

Console.WriteLine("Testing OpponentFactoryExtended...");
ExecuteScenario(xara, DayState.Day, oppFacExt);
ExecuteScenario(xara, DayState.Night, oppFacExt);
ExecuteScenario(eron, DayState.Day, oppFacExt);
ExecuteScenario(eron, DayState.Night, oppFacExt);
ExecuteScenario(dani, DayState.Day, oppFacExt);
ExecuteScenario(dani, DayState.Night, oppFacExt);
Console.WriteLine();


void ExecuteScenario(Fighter fighter, DayState dayState, IOpponentFactory opponentFactory)
{
	theWorld.DayOrNight = dayState;
	theWorld.TheFighter = fighter;
	theWorld.GenerateEncounter(new OpponentFactoryExtended());
}
