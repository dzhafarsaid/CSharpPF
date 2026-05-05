using _8ClassesEnObjectsMethods;

// Rekening rekening = new Rekening();
// rekening.Rekeningnummer = "BE23739010213491";
// rekening.Saldo = 0;
// rekening.Creatiedatum = DateOnly.FromDateTime(DateTime.Today);
// Console.WriteLine(rekening.GetInfo());
// rekening.Storten(100m);
// Console.WriteLine();
// Console.WriteLine(rekening.GetInfo());

Voertuig toyota = new Voertuig();
toyota.PolisHouder = "Niels";
toyota.Kostprijs = 120.50m;
toyota.Pk = 123123;
toyota.GemiddeldVerbruik = 10.5f;
toyota.Nummerplaat = "BE1234";
Console.WriteLine(toyota.GetVoertuigInfo());
