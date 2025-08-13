
Kasse enKasse = new Kasse("Pap", 10, 24, 30);

Console.WriteLine($"Kassen er lavet af {enKasse.Materiale} (bør være Pap)");
Console.WriteLine($"Kassens bredde er {enKasse.Bredde} (bør være 10)");
Console.WriteLine($"Kassens højde er {enKasse.Højde} (bør være 24)");
Console.WriteLine($"Kassens længde er {enKasse.Længde} (bør være 30)");
Console.WriteLine($"Kassens er fyldt: {enKasse.Fyldt} (bør være False)");

enKasse.Fyldt = true;

Console.WriteLine($"Kassens er fyldt: {enKasse.Fyldt} (bør være True)");

Console.WriteLine($"Kassens volumen er : {enKasse.Volumen} (bør være 7200)");
