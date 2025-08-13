
Ingrediens ing = new Ingrediens("Mel", 600, false);
Console.WriteLine($"{ing} (bør være: Mel (600 gram)  Alleri-risiko : False)");

ing.Vægt = 450;
Console.WriteLine($"{ing} (bør være: Mel (450 gram)  Alleri-risiko : False)");


Opskrift opskriftKage = new Opskrift("Kage");
opskriftKage.Ingredienser.Add(new Ingrediens("Mel", 400, false));
opskriftKage.Ingredienser.Add(new Ingrediens("Nødder", 200, true));
opskriftKage.Ingredienser.Add(new Ingrediens("Mælk", 300, false));

Opskrift opskriftBrød = new Opskrift("Brød");
opskriftBrød.Ingredienser.Add(new Ingrediens("Mel", 600, false));
opskriftBrød.Ingredienser.Add(new Ingrediens("Æg", 200, false));
opskriftBrød.Ingredienser.Add(new Ingrediens("Vand", 500, false));

Console.WriteLine($"Opskriften {opskriftKage.Beskrivelse} har en samlet vægt på {opskriftKage.SamletVægt} gram, og er allergivenlig : {opskriftKage.AllergiVenlig}");
Console.WriteLine($"Opskriften {opskriftBrød.Beskrivelse} har en samlet vægt på {opskriftBrød.SamletVægt} gram, og er allergivenlig : {opskriftBrød.AllergiVenlig}");
