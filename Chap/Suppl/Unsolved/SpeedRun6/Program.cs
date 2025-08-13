
Item itemA = new Item(1, "Keyboard", 289);
Item itemB = new Item(2, "Mus", 449);
Item itemC = new Item(3, "Monitor", 2799);

Console.WriteLine($"itemA har Id = {itemA.Id} (bør være 1) ");
Console.WriteLine($"itemA har Name = {itemA.Name} (bør være Keyboard) ");
Console.WriteLine($"itemA har Price = {itemA.Price} (bør være 289) ");
Console.WriteLine();

itemA.Id = 4;
itemA.Name = "Ergonomic Keyboard";
itemA.Price = 549;

Console.WriteLine($"itemA har Id = {itemA.Id} (bør være 4) ");
Console.WriteLine($"itemA har Name = {itemA.Name} (bør være Ergonomic Keyboard) ");
Console.WriteLine($"itemA har Price = {itemA.Price} (bør være 549) ");
Console.WriteLine();


// NB: Koden herunder er kun relevant for Trin 5

ItemRepository itemRepo = new ItemRepository();
itemRepo.Add(itemA);
itemRepo.Add(itemB);
itemRepo.Add(itemC);

TryToReadItem(2);
TryToReadItem(5);

Console.WriteLine($"TotalPrice er {itemRepo.TotalPrice} (bør være 3797)");
Console.WriteLine();

Console.WriteLine("Alle Item-objekter:");
itemRepo.PrintAll();


void TryToReadItem(int id)
{
    Item? item = itemRepo.Read(id);
    if (item != null)
    {
        Console.WriteLine($"Fandt Item med Id = {id}");
    }
    else
    {
        Console.WriteLine($"Fandt ikke noget Item med Id = {id}");
    }
}