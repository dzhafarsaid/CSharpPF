using CSharpPFOefeningen.model;

// Rekening2 mijnRekening = new Rekening2(
//     "BE40747524091936",
//     0m,
//     DateOnly.FromDateTime(DateTime.Today)
// );
// Console.WriteLine(mijnRekening.GetInfo());



// Voertuig2 v1 = new Voertuig2();
// Voertuig2 v2 = new Voertuig2("Jan", 10000m, 75, 6.0f, "1-ABC-123");
// Console.WriteLine(v1.GetVoertuigInfo());
// Console.WriteLine();
// Console.WriteLine(v2.GetVoertuigInfo());


// Voertuig v1 = new Voertuig()
// {
//     Polishouder = "Jan",
//     Kostprijs = 10000m,
//     Pk = 75,
//     GemiddeldVerbruik = 6.0f,
//     Nummerplaat = "1 - ABC - 123"
// };
// Voertuig v2 = new Voertuig()
// {
//     Polishouder = "Piet",
//     Kostprijs = 15000m,
//     Pk = 80,
//     GemiddeldVerbruik = 7.5f,
//     Nummerplaat = "1 - DEF - 456"
// };
// Console.WriteLine(v1.GetVoertuigInfo());
// Console.WriteLine();
// Console.WriteLine(v2.GetVoertuigInfo());

// Spaarrekening ik = new Spaarrekening("BE68539007547034", 0, DateOnly.FromDateTime(DateTime.Today), 0.01m);
// ik.Storten(1000);
// Console.WriteLine(ik.GetInfo());
// Zichtrekening mijn = new Zichtrekening("BE68539007547034", 0, DateOnly.FromDateTime(DateTime.Today), 1000);
// mijn.Storten(2000);
// Console.WriteLine(mijn.GetInfo());

// Vrachtwagen mijnVrachtwagen = new Vrachtwagen("Jan", "1-ABC-123", 10000m, 75, 6.0f, 1000f);
// Console.WriteLine(mijnVrachtwagen.GetVoertuigInfo());

// Personenwagen mijnPersonenwagen = new Personenwagen("Jan", "1-ABC-123", 10000m, 75, 6.0f);
// Console.WriteLine(mijnPersonenwagen.GetVoertuigInfo());

// Spaarrekening niels = new Spaarrekening("BE68539007547034", 0, DateOnly.FromDateTime(DateTime.Today));
// Spaarrekening hawa = new Spaarrekening("BE68539007547034", 0, DateOnly.FromDateTime(DateTime.Today));
// Console.WriteLine(niels.GetInfo());
// Console.WriteLine(hawa.GetInfo());
// Console.WriteLine();
// Spaarrekening.Intrest = 3m;
// Console.WriteLine(niels.GetInfo());
// Console.WriteLine(hawa.GetInfo());
// Spaarrekening.Intrest = 5m;
// Console.WriteLine(niels.GetInfo());
// Console.WriteLine(hawa.GetInfo());

// Vrachtwagen mijnVrachtwagen = new Vrachtwagen("Jan", "1-ABC-123", 10000m, 75, 6.0f, 1000f);
// Console.WriteLine(mijnVrachtwagen.GetVoertuigInfo());
// Console.WriteLine($"Kyotoscore: {mijnVrachtwagen.GetKyotoScore():F2}");
// Console.WriteLine();
// Personenwagen mijnPersonenwagen = new Personenwagen("Jan", "1-ABC-123", 10000m, 75, 6.0f);
// Console.WriteLine(mijnPersonenwagen.GetVoertuigInfo());
// Console.WriteLine($"Kyotoscore: {mijnPersonenwagen.GetKyotoScore():F2}");

// Rekening[] mijn = new Rekening[2];
// mijn[0] = new Spaarrekening("BE68539007547034", 0, DateOnly.FromDateTime(DateTime.Today));
// mijn[1] = new Zichtrekening("BE68539007547034", 0, DateOnly.FromDateTime(DateTime.Today), 0.01m);

// foreach (Rekening eenRekening in mijn)
// {
//     Console.WriteLine(eenRekening.GetInfo());
// }

// Voertuig[] mijnVagens = new Voertuig[2];
// mijnVagens[0] = new Vrachtwagen("Jan", "1-ABC-123", 10000m, 75, 6.0f, 1000f);
// mijnVagens[1] = new Personenwagen("Jan", "1-ABC-123", 10000m, 75, 6.0f);

// foreach (Voertuig eenVagen in mijnVagens)
// {
//     Console.WriteLine(eenVagen.GetVoertuigInfo());
//     Console.WriteLine(eenVagen.GetKyotoScore());
// }

Klant ik = new Klant
{
    Voornaam = "Dzhafar",
    Familienaam = "Said"
};
Rekening mijnSpaarRekening = new Spaarrekening("BE68539007547034", 0, DateOnly.FromDateTime(DateTime.Today), ik);
Rekening mijnZichtRekening = new Zichtrekening("BE68539007547034", 0, DateOnly.FromDateTime(DateTime.Today), 0.03m, ik);
Console.WriteLine(ik.GetKlantInfo());
Console.WriteLine(mijnSpaarRekening.GetInfo());
Console.WriteLine(mijnZichtRekening.GetInfo());