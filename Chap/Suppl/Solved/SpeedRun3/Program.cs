
Kunde enKunde = new Kunde("Per Laursen", "psl@fake.dk");

Console.WriteLine($"Kundens navn er {enKunde.Navn} (bør være Per Laursen)");
Console.WriteLine($"Kundens e-mail er {enKunde.Email} (bør være psl@fake.dk)");
Console.WriteLine($"Kunden er VIP : {enKunde.VIP} (bør være False)");


enKunde.Email = "psl1967@fake.dk";
Console.WriteLine($"Kundens e-mail er {enKunde.Email} (bør være psl1967@fake.dk)");

enKunde.VIP = true;
Console.WriteLine($"Kunden er VIP : {enKunde.VIP} (bør være True)");



enKunde.Varer.Add(new Vare("Jakke", 799.95));
enKunde.Varer.Add(new Vare("Sko", 479.70));
enKunde.Varer.Add(new Vare("Tørklæde", 125.50));

Console.WriteLine($"Samlet pris for varer er : {enKunde.SamletPrisForVarer} kr. (bør være 1405,15 kr.)");