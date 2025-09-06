/*
 * OOP.1.5 solution by Lukas Johansen
 */

// Testing the class
Clock clock = new Clock();
Console.WriteLine(clock.TimeString);
clock.SetTime(-2, 59);
Console.WriteLine(clock.TimeString);
clock.AddOneMinute();
Console.WriteLine(clock.TimeString);
clock.AddOneMinute();
Console.WriteLine(clock.TimeString);