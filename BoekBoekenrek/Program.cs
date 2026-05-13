using BoekBoekenrek.model;

Doelgroep doelgroep1 = new Doelgroep {Leeftijd = 15};
Doelgroep doelgroep2 = new Doelgroep {Leeftijd = 20};
Genre genre1 = new Genre {Naam ="Fictie", Doelgroep = doelgroep1};
Genre genre2 = new Genre {Naam = "vreemd", Doelgroep = doelgroep2};
Leesboek boek1 = new Leesboek("Harry Potter", "J.K. Rowling", 20m, genre1, "toveren");
Woordenboek boek2 = new Woordenboek("Vandale", "Kramers", 100m, genre2, "NL-E");
Boekenrek boekenrek = new Boekenrek(3m, 2.5m, 200);
IVoorwerpen[] list = new IVoorwerpen[3];
list[0] = boek1;
list[1] = boek2;
list[2] = boekenrek;

decimal totaalWinst = 0m;
foreach (IVoorwerpen  item in list)
{
    Console.WriteLine(item.GegevensTonen());
    totaalWinst += item.Winst;
}
Console.WriteLine($"Totale winst: {totaalWinst} euro");
