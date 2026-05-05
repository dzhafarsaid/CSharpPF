using _21Methods.model;

// Werknemer ik = new Werknemer();
// ik.Naam = "Asterix";
// ik.Geslacht = Geslacht.Man;
// ik.InDienst = new DateTime(2026,01,01);
// Werknemer jij = new Werknemer();
// jij.Naam = "Obelix";
// jij.Geslacht = Geslacht.Man;
// jij.InDienst = new DateTime(2026, 01, 02);
// LijnenTrekker lijnenTrekker = new LijnenTrekker();
// Console.WriteLine(ik.GetInfo());
// lijnenTrekker.TekenLijn(30, '-');
// Console.WriteLine(jij.GetInfo());
// lijnenTrekker.TekenLijn(79, '=');
// lijnenTrekker.TekenLijn();
// lijnenTrekker.TekenLijn(10);
// lijnenTrekker.TekenLijn(10,'*');
// lijnenTrekker.TekenLijn(10);
// lijnenTrekker.TekenLijn(lengte: 30);
// lijnenTrekker.TekenLijn(lengte: 40, teken: '=');


// Omzetter omzetter = new Omzetter();
// Console.WriteLine("Afstand in cm: ");
// double cm = double.Parse("1.25"!);
// Console.WriteLine($"{omzetter.CmNaarInch(cm)} inches");
// LijnenTrekker lijnenTrekker = new LijnenTrekker();
// lijnenTrekker.TekenLijn();
// Console.WriteLine("Afstand in inches: ");
// double inches = double.Parse("4.5");
// Console.WriteLine($"{omzetter.CmNaarInch(inches)} cm");

int eerste = 10, tweede = 20;
// Verwisselaar verwisselaar = new Verwisselaar();
// verwisselaar.Verwissel(ref eerste,ref tweede);
// Console.WriteLine(eerste);
// Console.WriteLine(tweede);

Console.WriteLine();
VerwisselNaarAndereVariabelen verwisselNaarAndereVariabelen = new VerwisselNaarAndereVariabelen();
verwisselNaarAndereVariabelen.VerwisselNaarAndereVariabele(eerste, tweede,
out int resultaat1, out int resultaat2);
Console .WriteLine(resultaat1);
Console .WriteLine(resultaat2);
