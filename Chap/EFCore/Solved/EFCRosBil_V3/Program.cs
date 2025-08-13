using EFCRosBil;

bool useMock = true;

// 1) Setup
IDataService dataService = useMock ? new MockDataService() : new DataService();
UI ui = new UI(dataService);


// 2) Vis alle data
ui.VisAlleKunder();
ui.VisAlleBiler();
ui.VisAlleUdlejninger();


// 3) Opret to nye Kunder
Kunde k1 = Kunde.Construct("Finn", 19283746, false);
Kunde k2 = Kunde.Construct("Gina", 90705030, true);

int idk1 = dataService.Kunder.Create(k1);
int idk2 = dataService.Kunder.Create(k2);


// 4) Vis alle Kunder (bør udskrive 7 Kunder)
ui.VisAlleKunder();


// 5) Slet de Kunder som lige er blevet oprettet
dataService.Kunder.Delete(idk1);
dataService.Kunder.Delete(idk2);


// 6) Vis alle Kunder (bør udskrive 5 Kunder)
ui.VisAlleKunder();


// 7) Opret to nye Leje-objekter

Leje l1 = Leje.Construct(2, 3, new DateOnly(2025, 3, 22), 5);
Leje l2 = Leje.Construct(4, 2, new DateOnly(2025, 3, 23), 4);

int idl1 = dataService.Udlejninger.Create(l1);
int idl2 = dataService.Udlejninger.Create(l2);


// 8) Vis alle Udlejninger (bør udskrive 10 Leje-objekter)
ui.VisAlleUdlejninger();


// 9) Slet de Leje-objekter som lige er blevet oprettet
dataService.Udlejninger.Delete(idl1);
dataService.Udlejninger.Delete(idl2);


// 10) Vis alle Udlejninger (bør udskrive 8 Leje-objekter)
ui.VisAlleUdlejninger();


// 11) Read
Kunde? k = dataService.Kunder.Read(3);
Console.WriteLine(k);
