
HashSet<int> setA = [12, 43, 17, 98, 66];

HashSet<int> setB = [66, 20, 43, 19, 81];

HashSet<int> setC = [66, 19, 81];


// Sets
PrintCollection("Set A", setA);
PrintCollection("Set B", setB);
PrintCollection("Set C", setC);

// Union - TODO
var unionAB = new HashSet<int>(setA);
unionAB.UnionWith(setB);
PrintCollection("Union A U B", unionAB);
// Intersection - TODO
var intersectAB = new HashSet<int>(setA);
intersectAB.IntersectWith(setB);
PrintCollection("Intersection A ∩ B", intersectAB);

// Complement - TODO
var complementAB = new HashSet<int>(setA);
complementAB.ExceptWith(setB);
PrintCollection("Complement A \\ B", complementAB);

// SuperSet - TODO
bool isSuperSet = setB.IsSupersetOf(setC);
Console.WriteLine($"\nIs B a SuperSet of C? : {isSuperSet}");

// SubSet - TODO
bool isSubSet = setC.IsSubsetOf(setB);
Console.WriteLine($"\nIs C a SubSet of B? : {isSubSet}");


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