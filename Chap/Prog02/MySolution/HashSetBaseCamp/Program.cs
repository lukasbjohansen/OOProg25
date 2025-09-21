
HashSet<int> setA = [12, 43, 17, 98, 66];

HashSet<int> setB = [66, 20, 43, 19, 81];

HashSet<int> setC = [66, 19, 81];


// Sets
PrintCollection("Set A", setA);
PrintCollection("Set B", setB);
PrintCollection("Set C", setC);

// Union - TODO

// Intersection - TODO

// Complement - TODO

// SuperSet - TODO

// SubSet - TODO


void PrintCollection(string text, IEnumerable<int> collection)
{
    Console.WriteLine();
    Console.Write($"{text} (Count = {collection.Count()}) :   [ ");

    foreach (int val in collection)
    {
        Console.Write($" {val} ");
    }

    Console.Write($"]");
    Console.WriteLine();
}