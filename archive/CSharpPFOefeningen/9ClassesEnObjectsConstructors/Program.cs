using _9ClassesEnObjectsConstructors.model;

// Rekening rekening = new Rekening("BE23739010213491",0, DateOnly.FromDateTime(DateTime.Today));

// Console.WriteLine(rekening.GetInfo());
// rekening.Storten(100m);
// Console.WriteLine();
// Console.WriteLine(rekening.GetInfo());

Voertuig toyota = new Voertuig("Niels","BE1234",120.50m,12,10.5f);
Voertuig nissan = new Voertuig("Ian", nummerplaat:"BE1234");
Console.WriteLine(toyota.GetVoertuigInfo());
Console.WriteLine(nissan.GetVoertuigInfo());