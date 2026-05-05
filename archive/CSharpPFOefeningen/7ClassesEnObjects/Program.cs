using _7ClassesEnObjects.model;

// Rekening ik = new Rekening();
// ik.Rekeningnummer = "12345678";
// ik.Creatiedatum = new DateOnly(1800,01,01);
// Console.WriteLine(ik.Rekeningnummer);
// Console.WriteLine(ik.Saldo);
// Console.WriteLine(ik.Creatiedatum);

Voertuig toyota = new Voertuig();
toyota.PolisHouder = "Niels";
toyota.Kostprijs = 120.50m;
toyota.Pk = 123123;
toyota.GemiddeldVerbruik = 10.5f;
toyota.Nummerplaat = "BE1234";
Console.WriteLine(toyota.PolisHouder);
Console.WriteLine(toyota.Kostprijs);
Console.WriteLine(toyota.Pk);
Console.WriteLine(toyota.GemiddeldVerbruik);
Console.WriteLine(toyota.Nummerplaat);
