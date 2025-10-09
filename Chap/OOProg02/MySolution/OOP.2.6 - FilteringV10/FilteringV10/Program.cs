
List<int> values = new List<int>() { 12, 24, 9, 10, 6, 3, 45 };
List<int> filteredValues = Filter.FilterValues(values,ValueOver10.Instance, DivisableBy3.Instance);

List<int> netFilteredValues = values.Where(v => v > 10 && v % 2 == 1).ToList();

foreach (var value in netFilteredValues)
{
    Console.Write($" {value} ");
}
Console.WriteLine();
