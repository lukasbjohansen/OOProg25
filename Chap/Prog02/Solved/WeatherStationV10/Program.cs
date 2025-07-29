
Barometer theBarometer = new Barometer();

Console.WriteLine("Using if-else statement");
for (int pressure = 975; pressure < 1050; pressure = pressure + 10)
{
	theBarometer.Pressure = pressure;
	Console.WriteLine($"Pressure is {theBarometer.Pressure} hPa : {theBarometer.WeatherDescription}");
}
Console.WriteLine();

Console.WriteLine("Using switch statement");
for (int pressure = 975; pressure < 1050; pressure = pressure + 10)
{
	theBarometer.Pressure = pressure;
	Console.WriteLine($"Pressure is {theBarometer.Pressure} hPa : {theBarometer.WeatherDescriptionUsingSwitch}");
}
Console.WriteLine();


