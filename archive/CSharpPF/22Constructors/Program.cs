using _22Constructors.model;

// Werknemer ik = new()
// {
//     Naam = "Asterix",
//     InDienst = new DateTime(2026, 1, 1),
//     Geslacht = Geslacht.Man

// };

// Console.WriteLine(ik.GetInfo());
// var persoon = new { Nr = 1, Naam = "Adam", AantalKinderen = 2 };
// Console.WriteLine(persoon.GetType().ToString());
// Console.WriteLine(persoon.Naam);


// Werknemer ik = new Werknemer("Asterix", DateTime.Today, Geslacht.Man);
// Werknemer jij = new Werknemer("Obelix", DateTime.Today, Geslacht.Man);
// Werknemer.Personeelsfeest = new DateOnly(2026, 12, 12);
// Console.WriteLine(Werknemer.Personeelsfeest);
// Console.WriteLine(jij.GetInfo());
// Console.WriteLine(ik.GetInfo());

// Console.WriteLine(Rekenaar.Kwadraat(3));

// Manager ik = new Manager("Asterix", new DateTime(2026, 1, 1), Geslacht.Man, 24.79m, 7000m);
// Manager mezelf = ik;
// Manager dezelfde = new Manager("Asterix", new DateTime(2026, 1, 1), Geslacht.Man, 2400.79m, 7000m);
// Console.WriteLine(ik.Equals(mezelf));
// Console.WriteLine(ik.Equals(dezelfde));


Werknemer[] wij = new Werknemer[3];
wij[0] = new Arbeider("Asterix", new DateTime(2026,1,1), Geslacht.Man, 24.79m, 3);
wij[1] = new Bediende("Obelix", new DateTime(1995, 1, 1), Geslacht.Man, 2400.79m);
wij[2] = new Manager("Idefix", new DateTime(1996,1,1), Geslacht.Man, 2400.79m, 7000m);

foreach (Werknemer eenWerknemer in wij)
    Console.WriteLine(eenWerknemer.GetInfo());