
Bil bilA = new Bil("BMW", "320i", 88000, false);
Bil bilB = new Bil("Tesla", "3", 0, true);
Bil bilC = new Bil("Skoda", "Octavia", 56000, true);
Bil bilD = new Bil("BMW", "318i", 12000, false);

Console.WriteLine(bilA);
Console.WriteLine(bilB);
Console.WriteLine(bilC);
Console.WriteLine(bilD);
Console.WriteLine();

bilA.Kilometer = 123000;
bilC.Ny = false;

Console.WriteLine(bilA);
Console.WriteLine(bilB);
Console.WriteLine(bilC);
Console.WriteLine(bilD);
Console.WriteLine();


// NB: Dette er kode hørende til Trin 5
BilFlåde bilFlåde = new BilFlåde();
bilFlåde.TilføjBil(bilA);
bilFlåde.TilføjBil(bilB);
bilFlåde.TilføjBil(bilC);
bilFlåde.TilføjBil(bilD);

Console.WriteLine(bilFlåde);

int antalBMW = bilFlåde.HvorMangeAfDetteMærke("BMW");
Console.WriteLine($"Bilflåden rummer {antalBMW} biler af mærket BMW");

int antalAudi = bilFlåde.HvorMangeAfDetteMærke("Audi");
Console.WriteLine($"Bilflåden rummer {antalAudi} biler af mærket Audi");

Bil? førsteNyeBil = bilFlåde.FindFørsteNyeBil();
if (førsteNyeBil == null)
{
    Console.WriteLine("Bilflåden rummer ingen nye biler");
}
else
{
    Console.WriteLine($"Første nye bil : {førsteNyeBil}");
}