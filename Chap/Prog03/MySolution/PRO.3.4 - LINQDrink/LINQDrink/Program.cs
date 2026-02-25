
#region Create drinks
using LINQDrink;
using System.Runtime.CompilerServices;

List<Drink> drinks = new List<Drink>();
drinks.Add(new Drink("Cuba Libre", "Rum", 3, "Cola", 20));
drinks.Add(new Drink("Russia Libre", "Vodka", 3, "Cola", 20));
drinks.Add(new Drink("The Day After", "None", 0, "Water", 20));
drinks.Add(new Drink("Red Mule", "Vodka", 3, "Fanta", 20));
drinks.Add(new Drink("Double Straight", "Whiskey", 6, "None", 0));
drinks.Add(new Drink("Pearly Temple", "None", 0, "Sprite", 20));
drinks.Add(new Drink("High Spirit", "Vodka", 6, "Sprite", 20));
drinks.Add(new Drink("Watered Down", "Whiskey", 3, "Water", 3));
drinks.Add(new Drink("Caribbean Gold", "Rum", 6, "Fanta", 20));
drinks.Add(new Drink("Siberian Zone", "Vodka", 6, "None", 0));
#endregion

var drinkNames = from d in drinks
				 select d.Name;
drinkNames.Print("1. Drink names");

var nonAlcoholicDrinkNames = from d in drinks
							 where d.AlcoholicPart.ToLower() == "none"
							 select d.Name;
nonAlcoholicDrinkNames.Print("2. Non alcoholic drink names");

var alcoholicDrinkDetailed = from d in drinks
							 where d.AlcoholicPart.ToLower() != "none"
							 select new
							 {
								 d.Name,
								 d.AlcoholicPart,
								 d.AlcoholicPartAmount
							 };
alcoholicDrinkDetailed.Print("3. Alcoholic drink detailed");

var alphabeticalDrinks = from d in drinks
						 orderby d.Name
						 select d.Name;
alphabeticalDrinks.Print("4. All drinks ordered alphabetically");

var totalAmountOfAlcohol = (from d in drinks 
							select d.AlcoholicPartAmount
							).Sum();
totalAmountOfAlcohol.Print("5. Total amount of alcohol");

var averageAmountOfAlcohol = (from d in drinks
							select d.AlcoholicPartAmount
							).Average();
averageAmountOfAlcohol.Print("6. Average amount of alcohol");

var groupedByAlcoholicPartDetailed = from d in drinks
									 group d by d.AlcoholicPart into grouped
									 select new
									 {
										 grouped.Key,
										 Drinks = from d in drinks
												  where d.AlcoholicPart == grouped.Key
												  select d
									 };
groupedByAlcoholicPartDetailed.Print("Drinks by Alcohol Type");
