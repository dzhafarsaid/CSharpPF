
using _20ClassesEnObjects.model;

Werknemer ik;
ik = new Werknemer();
ik.Naam = "Asterix";
ik.Geslacht = Geslacht.Man;
ik.InDienst = new DateTime(2026, 1, 1);
Console.WriteLine(ik.Naam);
Console.WriteLine(ik.Geslacht);
Console.WriteLine(ik.InDienst);
Console.WriteLine();
Werknemer mezelf = ik;
Console.WriteLine(mezelf.Naam);
Console.WriteLine(ik == mezelf);
ik = null;
Console.WriteLine(ik == mezelf);
Console.WriteLine(mezelf.Naam);

// Werknemer ? ik = new Werknemer ();
// if (ik is null )
//     Console .WriteLine("niet verbonden");
// else
//     Console .WriteLine("verbonden");
// ik = null; 
// if (ik is null )
//     Console .WriteLine("niet verbonden");
// else
//     Console .WriteLine("verbonden");