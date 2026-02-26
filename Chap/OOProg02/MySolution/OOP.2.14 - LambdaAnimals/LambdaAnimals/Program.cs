
Dog d1 = new Dog("King", 25);
Dog d2 = new Dog("Tiny", 95);
Dog d3 = new Dog("Rufus", 36);
Dog d4 = new Dog("Spot", 55);
Dog d5 = new Dog("Daisy", 8);
List<Dog> dogs = new List<Dog> { d1, d2, d3, d4, d5 };

// Print out all Dogs with a weight larger than 40 kg.
ConditionalPrint(dogs, d => d.Weight > 40);

// Print out all Dogs with a weight smaller than Rufus' weight.
ConditionalPrint(dogs, d => d.Weight < d3.Weight);

// Print out all Dogs with a name that contains an "i"
ConditionalPrint(dogs, d => d.Name.Contains("i"));

ConditionalPrint2(dogs, d => d.Weight < 90, d => d.Weight > 30);
MultiConditionalPrint(dogs, d => d.Weight < 90, d => d.Weight > 30);

static void ConditionalPrint<T>(List<T> objects, Predicate<T> pred)
{
    Console.WriteLine();
    foreach (var item in objects.FindAll(pred))
    {
        Console.WriteLine(item);
    }
}
static void ConditionalPrint2<T>(List<T> objects, Predicate<T> pred1, Predicate<T> pred2)
{
    Console.WriteLine();
    foreach(T item in objects.FindAll(pred1).FindAll(pred2))
    {
        Console.WriteLine(item);
    }
}
static void MultiConditionalPrint<T>(List<T> objects, params Predicate<T>[] predicates)
{
    List<T> matchingObjects = new List<T>(objects);
    foreach (var pred in predicates)
    {
        matchingObjects.RemoveAll(item => !pred(item));
    }

    Console.WriteLine();
    foreach (T item in matchingObjects)
    {
        Console.WriteLine(item);
    }
}