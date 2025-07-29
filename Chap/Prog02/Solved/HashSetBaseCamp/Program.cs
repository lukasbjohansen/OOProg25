
HashSet<int> setA = [12, 43, 17, 98, 66];

HashSet<int> setB = [66, 20, 43, 19, 81];

HashSet<int> setC = [66, 19, 81];


// Sets
PrintCollection("Set A", setA);
PrintCollection("Set B", setB);
PrintCollection("Set C", setC);

// Union
IEnumerable<int> union = setA.Union(setB);
PrintCollection("Union", union);

// Intersection
IEnumerable<int> intersection = setA.Intersect(setB);
PrintCollection("Intersection", intersection);

// Complement
IEnumerable<int> complement = setA.Except(setB);
PrintCollection("Complement", complement);

// SuperSet
bool superSetAC = setA.IsSupersetOf(setC);
Console.WriteLine();
Console.WriteLine($"A is SuperSet of C {superSetAC}");

bool superSetBC = setB.IsSupersetOf(setC);
Console.WriteLine();
Console.WriteLine($"B is SuperSet of C {superSetBC}");

// SubSet
bool subSetCA = setC.IsSubsetOf(setA);
Console.WriteLine();
Console.WriteLine($"C is SubSet of A {subSetCA}");

bool subSetCB = setC.IsSubsetOf(setB);
Console.WriteLine();
Console.WriteLine($"C is SubSet of B {subSetCB}");


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