using CSharpPFCursus.model;

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


// Werknemer[] wij = new Werknemer[3];
// wij[0] = new Arbeider("Asterix", new DateTime(2026,1,1), Geslacht.Man, 24.79m, 3);
// wij[1] = new Bediende("Obelix", new DateTime(1995, 1, 1), Geslacht.Man, 2400.79m);
// wij[2] = new Manager("Idefix", new DateTime(1996,1,1), Geslacht.Man, 2400.79m, 7000m);

// foreach (Werknemer eenWerknemer in wij)
//     Console.WriteLine(eenWerknemer.GetInfo());


// string land = "belgië";
// Console.WriteLine(land.ToUpperFirst());
// Console.WriteLine(land.Right(4));
// string tekst = "Groeten van C#";
// Console.WriteLine(tekst.WordCount);
// Console.WriteLine(string.GenereerCode(8));



// Afdeling afdelingStrijd = new Afdeling
// {
//     Naam = "Strijd",
//     Verdieping = 0

// };
// Afdeling afdelingFeest = new Afdeling
// {
//     Naam = "Feest",
//     Verdieping = 1
// };

// Afdeling afdelingStrijd = new Afdeling("Strijd", 0);
// Afdeling afdelingFeest = new Afdeling("Feest", 1);

// Werknemer[] wij = new Werknemer[3];
// wij[0] = new Arbeider("Asterix", new DateTime(2026, 1, 1), Geslacht.Man, 24.79m, 3);
// wij[0].Afdeling = afdelingStrijd;
// wij[1] = new Bediende("Obelix", new DateTime(1995, 2, 1), Geslacht.Man, 2400.79m);
// wij[1].Afdeling = afdelingStrijd;
// wij[2] = new Manager("Idefix", new DateTime(1996, 3, 1), Geslacht.Man, 2400.79m, 7000m);
// wij[2].Afdeling = afdelingFeest;
// foreach (Werknemer eenWerknemer in wij)
// {
//     Console.WriteLine(eenWerknemer.GetInfo());
//     Console.WriteLine();
// }

// Afdeling afdelingStrijd = new Afdeling("Strijd", 0);
// Arbeider asterix = new Arbeider("Asterix", new DateTime(2026, 1, 1), Geslacht.Man, 24.79m, 3, afdelingStrijd);
// Console.WriteLine(asterix.GetInfo());
