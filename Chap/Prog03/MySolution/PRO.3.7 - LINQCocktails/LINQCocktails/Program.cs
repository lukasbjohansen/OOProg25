
#region Create ingredients
using LINQCocktails;

Ingredient ingVodka = new Ingredient("Vodka", 15, 40);
Ingredient ingRum = new Ingredient("Rum", 15, 40);
Ingredient ingGin = new Ingredient("Gin", 15, 40);
Ingredient ingTripleSec = new Ingredient("Triple Sec", 20, 30);
Ingredient ingCola = new Ingredient("Cola", 1, 0);
Ingredient ingLimeJuice = new Ingredient("Lime Juice", 2, 0);
Ingredient ingCranJuice = new Ingredient("Cranberry Juice", 2, 0);
Ingredient ingGingerBeer = new Ingredient("Ginger Beer", 2, 4);
Ingredient ingMinWater = new Ingredient("Mineral Water", 1, 0);

List<Ingredient> ingredients = new List<Ingredient>
            {
                ingVodka,
                ingRum,
                ingGin,
                ingTripleSec,
                ingCola,
                ingLimeJuice,
                ingCranJuice,
                ingGingerBeer,
                ingMinWater
            };
#endregion

#region Create cocktails
Cocktail c1 = new Cocktail("Long Island Ice Tea");
c1.AddIngredient("Rum", 3);
c1.AddIngredient("Vodka", 3);
c1.AddIngredient("Gin", 3);
c1.AddIngredient("Cola", 9);

Cocktail c2 = new Cocktail("Moscow Mule");
c2.AddIngredient("Vodka", 4);
c2.AddIngredient("Lime Juice", 3);
c2.AddIngredient("Ginger Beer", 10);

Cocktail c3 = new Cocktail("Cosmopolitan");
c3.AddIngredient("Vodka", 4);
c3.AddIngredient("Triple Sec", 2);
c3.AddIngredient("Lime Juice", 6);
c3.AddIngredient("Cranberry Juice", 6);

Cocktail c4 = new Cocktail("Mojito");
c4.AddIngredient("Rum", 4);
c4.AddIngredient("Mineral Water", 10);
c4.AddIngredient("Lime Juice", 2);

Cocktail c5 = new Cocktail("Cuba Libre");
c5.AddIngredient("Rum", 2);
c5.AddIngredient("Cola", 33);

List<Cocktail> cocktails = new List<Cocktail> { c1, c2, c3, c4, c5 };
#endregion

var allCoctailNames = from c in cocktails
                      select c.Name;
allCoctailNames.Print("1. The name of all coctails");

var allCoctailNameAndAmount = from c in cocktails
                              select new
                              {
                                  c.Name,
                                  c.Ingredients
                              };
Printer.Title("2. The name of each coctail and amount of each ingridient");
foreach(var item in allCoctailNameAndAmount)
{
	Console.WriteLine(item.Name);
    foreach(var i in item.Ingredients)
    {
		Console.WriteLine($"\t{i.Key}: {i.Value}cl");
    }
}
Console.WriteLine();

var allCoctailsAndAllIngridientsWithMoreThan10Alc = from c in cocktails
                                                    select new
                                                    {
                                                        c.Name,
                                                        Ingredients = from i in c.Ingredients
                                                                      join ing in ingredients
                                                                      on i.Key equals ing.Name
                                                                      where ing.AlcoholPercent > 10
                                                                      select ing
                                                    };
Printer.Title("3. The name of each coctail and the name of each ingridient with more than 10%");
foreach (var item in allCoctailsAndAllIngridientsWithMoreThan10Alc)
{
	Console.WriteLine(item.Name);
	foreach (var i in item.Ingredients)
	{
		Console.WriteLine($"\t{i.Name}: {i.AlcoholPercent}%");
	}
}
Console.WriteLine();

var priceOfEachCoctail = from c in cocktails
                         select new
                         {
                             c.Name,
                             Price = (from i in c.Ingredients
                                      join ing in ingredients
                                     on i.Key equals ing.Name
                                      select ing.PricePerCl * i.Value).Sum()
                         };
priceOfEachCoctail.Print("4. Price of each coctail");

var nameAndAlcoholPercentageOfCoctail = from c in cocktails
                                        select new
                                        {
                                            c.Name,
                                            AlcPercent = (from i in c.Ingredients
                                                          join ing in ingredients
                                                            on i.Key equals ing.Name
                                                          select ing.AlcoholPercent * i.Value).Sum()/
                                                          (from i in c.Ingredients
                                                           select i.Value).Sum()
                                        };
nameAndAlcoholPercentageOfCoctail.Print("5. Name an alcoholpercent of each coctail");
