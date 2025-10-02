
Barometer theBarometer = new Barometer();

for (int pressure = 975; pressure < 1050; pressure = pressure + 10)
{
	theBarometer.Pressure = pressure;
	Console.WriteLine($"Pressure is {theBarometer.Pressure} hPa : {theBarometer.WeatherDescription}");
}
Console.WriteLine();



