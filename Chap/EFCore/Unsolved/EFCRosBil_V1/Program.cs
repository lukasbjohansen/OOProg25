
using EFCRosBil;
using Microsoft.EntityFrameworkCore;

// 1) DB opsætning
RosBilDBContext context = new RosBilDBContext();


// 2) Læs og udskriv alle data fra databasen.
List<Kunde> kunder = context.Set<Kunde>().ToList();
Helpers.PrintList(kunder);

List<Bil> biler = context.Set<Bil>().ToList();
Helpers.PrintList(biler);

List<Leje> lejer = context.Set<Leje>().Include(l => l.Bil).Include(l => l.Kunde).ToList();
Helpers.PrintList(lejer);


// 3) Opret to nye Kunder, og tilføj dem til DB
int maxKundeId = Helpers.FindMaxId(kunder);

Kunde k1 = Kunde.Create("Finn", 19283746, false);
Kunde k2 = Kunde.Create("Gina", 90705030, true);

k1.Id = maxKundeId + 1;
k2.Id = maxKundeId + 2;

context.Set<Kunde>().Add(k1);
context.Set<Kunde>().Add(k2);
context.SaveChanges();


// 4) Læs alle Kunder fra DB og udskriv dem (bør udskrive 7 Kunder)
kunder = context.Set<Kunde>().ToList();
Helpers.PrintList(kunder);


// 5) Slet de Kunder som lige er blevet oprettet
context.Set<Kunde>().Remove(k1);
context.Set<Kunde>().Remove(k2);
context.SaveChanges();


// 6) Læs alle Kunder fra DB og udskriv dem (bør udskrive 5 Kunder)
kunder = context.Set<Kunde>().ToList();
Helpers.PrintList(kunder);


// 7) Opret to nye Leje-objekter, og tilføj dem til DB
int maxLejeId = Helpers.FindMaxId(lejer);

Leje l1 = Leje.Create(2, 3, new DateOnly(2025, 3, 22), 5);
Leje l2 = Leje.Create(4, 2, new DateOnly(2025, 3, 23), 4);

l1.Id = maxLejeId + 1;
l2.Id = maxLejeId + 2;

context.Set<Leje>().Add(l1);
context.Set<Leje>().Add(l2);
context.SaveChanges();


// 8) Læs alle Leje-objekter fra DB og udskriv dem (bør udskrive 10 Leje-objekter)
lejer = context.Set<Leje>().Include(l => l.Bil).Include(l => l.Kunde).ToList();
Helpers.PrintList(lejer);


// 9) Slet de Leje-objekter som lige er blevet oprettet
context.Set<Leje>().Remove(l1);
context.Set<Leje>().Remove(l2);
context.SaveChanges();


// 10) Læs alle Leje-objekter fra DB og udskriv dem (bør udskrive 8 Leje-objekter)
lejer = context.Set<Leje>().Include(l => l.Bil).Include(l => l.Kunde).ToList();
Helpers.PrintList(lejer);
