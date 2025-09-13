/*
 * OOP.1.9 solution by Lukas Johansen
 */
// ListMethods test
List<int> aList = new List<int> { 23, 86, 51, 11, 39 };

int smallest = ListMethods.FindSmallestNumber(aList);
Console.WriteLine($"The smallest number in the list is : {smallest}");

int average = ListMethods.FindAverage(aList);
Console.WriteLine($"The average of the list is : {average}");

// Car test
Car car1 = new Car("ABC-123", 15000);
Car car2 = new Car("XYZ-789", 20000);
Car car3 = new Car("LMN-456", 18000);

Console.WriteLine($"Car 1: License Plate = {car1.LicensePlate}, Price = {car1.Price}");
Console.WriteLine($"Car 2: License Plate = {car2.LicensePlate}");
Car.PrintUsageStatistics();