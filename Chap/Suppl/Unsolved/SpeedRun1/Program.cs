
Vare enVare = new Vare("Frakke", 499.95);

Console.WriteLine($"Varens navn er {enVare.Navn} (bør være Frakke)");
Console.WriteLine($"Varens pris er {enVare.Pris} (bør være 499.95)");

enVare.Pris = 379.75;

Console.WriteLine($"Varens pris er {enVare.Pris} (bør være 379.75)");


