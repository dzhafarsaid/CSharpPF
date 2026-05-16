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

// Arbeider ik = new Arbeider("Asterix", DateTime.Today, Geslacht.Man, 24.79m, 3);
// ik.Regime = new Werknemer.WerkRegime
// {
//     Type = Werknemer.WerkRegime.RegimeType.Voltijds
// };
// Console.WriteLine(ik.Regime);
// Console.WriteLine(ik.Regime.AantalVakantiedagen);

// IKost[] kosten = new IKost[4];
// kosten[0] = new Arbeider("Asterix", new DateTime(2026, 1, 1), Geslacht.Man, 24.79m, 3);
// kosten[1] = new Bediende("Obelix", new DateTime(1995, 2, 1), Geslacht.Man, 2400.79m);
// kosten[2] = new Manager("Idefix", new DateTime(1996, 3, 1), Geslacht.Man, 2400.79m, 7000m);
// kosten[3] = new Fotokopiemachine("123", 500, 0.025m);
// decimal totakKost = 0m;
// foreach (IKost kost in kosten)
// {
//     Console.WriteLine(kost.Menselijk);
//     Console.WriteLine(kost.BerekenKostprijs());
//     totakKost += kost.BerekenKostprijs();
// }
// Console.WriteLine(totakKost);


// Object[] dingen = new Object[3];
// dingen[0] = new Arbeider("Asterix", new DateTime(2026, 1, 1), Geslacht.Man, 24.79m, 3);
// dingen[1] = new Fotokopiemachine("123", 500, 0.025m);
// dingen[2] = "C#";

// foreach (Object ding in dingen)
// {
//     Console.WriteLine(ding is IKost);
// }

// Object?[] lijst = new Object?[4];
// lijst[0] = new Arbeider("Asterix", new DateTime(2026, 1, 1), Geslacht.Man, 24.79m, 3);
// lijst[1] = new Bediende("Obelix", new DateTime(2026, 2, 1), Geslacht.Man, 2400.79m);
// lijst[2] = null;
// lijst[3] = "C# 10";

// foreach (var item in lijst)
// {
//     ToonGegevens(item);
// }


// static void ToonGegevens(Object? obj)
// {
//     if (obj is Werknemer)
//     {
//         Werknemer w = (Werknemer)obj;
//         Console.WriteLine($"Werknemer {w.Naam} kost" +
//         $" {w.BerekenKostprijs()} euro");
//     }
//     else if (obj is Fotokopiemachine)
//     {
//         Fotokopiemachine f = (Fotokopiemachine)obj;
//         Console.WriteLine($"Fotokopiemachine {f.SerieNr} kopieerde " +
//         $" {f.AantalGekopieerdeBlz} en kost {f.BerekenKostprijs()} euro");
//     }
//     else
//     {
//         Console.WriteLine("onbekend type");
//     }
// }

// void ToonGegevens(Object? obj)
// {
//     if (obj is Werknemer w)
//     {
//         Console.WriteLine($"Werknemer {w.Naam} kost {w.BerekenKostprijs()} euro");
//     }
//     else if (obj is Fotokopiemachine f)
//     {
//         Console.WriteLine($"Fotokopiemachine {f.SerieNr} kopieerde " +
//             $" {f.AantalGekopieerdeBlz} en kost {f.BerekenKostprijs()} euro");
//     }
//     else
//     {
//         Console.WriteLine("onbekend type");
//     }
// }

// void ToonGegevens(Object? obj)
// {
//     switch (obj)
//     {
//         case Werknemer w:
//             Console.WriteLine($"Werknemer {w.Naam} kost {w.BerekenKostprijs()} euro");
//             break;
//         case Fotokopiemachine f:
//             Console.WriteLine($"Fotokopiemachine {f.SerieNr} kopieerde " +
//                 $" {f.AantalGekopieerdeBlz} en kost {f.BerekenKostprijs()} euro");
//             break;
//         case null:
//             Console.WriteLine("Parameter = null");
//         break;
//         default:
//             Console.WriteLine("onbekend type");
//         break;
//     }
// }


//Object?[] lijst = new Object?[5];
//lijst[0] = new Arbeider("Asterix", new DateTime(2026, 1, 1), Geslacht.Man, 24.79m, 3);
//lijst[1] = new Bediende("Obelix", new DateTime(2026, 2, 1), Geslacht.Man, 2400.79m);
//lijst[2] = new Bediende("Walhalla", new DateTime(2026, 2, 1), Geslacht.Vrouw, 2000m);
//lijst[3] = null;
//lijst[4] = "C# 10";

//foreach (var item in lijst)
//{
//    switch (item)
//    {

//        case Arbeider a when a.Geslacht == Geslacht.Vrouw:
//            Console.WriteLine($"{a.Naam}" +
//                $" is een vrouwelijke arbeider " +
//                $"met een uurloon van {a.Uurloon} euro");
//            break;
//        case Arbeider a when a.Geslacht == Geslacht.Man:
//            Console.WriteLine($"{a.Naam} " +
//                $"is een mannelijke arbeider" +
//                $" met een uurloon van {a.Uurloon} euro");
//            break;
//        case Bediende b when b.Geslacht == Geslacht.Vrouw:
//            Console.WriteLine($"{b.Naam} " +
//                $"is een vrouwelijke bediende" +
//                $" met een wedde van {b.Wedde} euro");
//            break;
//        case Bediende b when b.Geslacht == Geslacht.Man:
//            Console.WriteLine($"{b.Naam} " +
//                $"is een mannelijke bediende " +
//                $"met een wedde van {b.Wedde} euro");
//            break;
//        case Werknemer w when w.Geslacht == Geslacht.Man:
//            Console.WriteLine($"{w.Naam}" +
//                $" is een mannelijke werknemer");
//            break;
//        case null:
//            Console.WriteLine($"null");
//            break;
//        default:
//            Console.WriteLine($"{item} is geen werknemer");
//            break;
//    }
//}

// MateriaalStatus statusBoorMachine = MateriaalStatus.Werkend;
// PersoneelStatus statusChef = PersoneelStatus.HogerKader;
// Console.WriteLine(statusBoorMachine);
// Console.WriteLine(statusChef);

// decimal getal1, getal2;
// try
// {
//     Console.Write("eerste getal: ");
//     getal1 = decimal.Parse(Console.ReadLine()!);
//     try
//     {
//         Console.Write("tweede getal: ");
//         getal2 = decimal.Parse(Console.ReadLine()!);
//         if (getal2 != 0m)
//             Console.WriteLine("deling: " + getal1 / getal2);


//         else
//             Console.WriteLine("Delen door nul niet toegelaten");
//     }
//     catch (FormatException)
//     {
//         Console.WriteLine("Je typt e geen getal als tweede getal");
//     }
// }
// catch (FormatException)
// {
//     Console.WriteLine("Je typt e geen getal als eerste getal");
// }


// using Firma.Materiaal;
// try
// {
//     Fotokopiemachine machine = new Fotokopiemachine("123", 100, -5.4m);
//     Console.WriteLine("Machine goed ingevuld");
// }
// catch (Exception ex)
// {
//     Console.WriteLine("Fout:" + ex.Message);
// }
// Console.WriteLine("Einde programma");

// using Firma.Materiaal;
// try
// {
//     Fotokopiemachine machine =
//     new Fotokopiemachine("123", -100, -5.4m);
//     Console.WriteLine("Machine goed ingevuld");
// }
// catch (Fotokopiemachine.KostPerBlzException ex)
// {
//     Console.WriteLine($"Fout: {ex.Message} : {ex.VerkeerdeKost} ");
// }
// catch (Fotokopiemachine.AantalGekopieerdeBlzException ex)
// {
//     Console.WriteLine($"Fout: {ex.Message} : {ex.VerkeerdAantalBlz} ");
// }
// Console.WriteLine("Einde programma");

using CSharpPFCursus.model;
using System.Collections;
using Firma.Personeel;
using Firma.Materiaal;
using CSharpPFCursus;
// Console.Write("Provincie: ");
// string provincie = Console.ReadLine()!;
// try
// {
//     ProvincieInfo info = new ProvincieInfo();
//     Console.WriteLine(info.ProvincieGrootte(provincie));
// }
// catch (Exception ex)
// {
//     Console.WriteLine(ex.Message);
// }

// Arbeider asterix = new Arbeider("Asterix", new DateTime(2026, 1, 1), Geslacht.Man, 24.79m, 3);
// Bediende obelix = new Bediende("Obelix", new DateTime(2026, 1, 1), Geslacht.Man, 2400.79m);
// Manager idefix = new Manager("Idefix", new DateTime(2026, 1, 1), Geslacht.Man, 2400.79m, 7000m);

// // ArrayList personeel = new ArrayList();
// List<Werknemer> personeel = new List<Werknemer>();
// personeel.Add(asterix);
// personeel.Add(obelix);
// personeel.Insert(1, idefix);

// Console.WriteLine($"{personeel[0].Naam}" +
//     $" is de 1ste van {personeel.Count} personeelsleden.");
// Console.WriteLine();

// foreach (Werknemer personeelslid in personeel)
//     Console.WriteLine(personeelslid.Naam);
// Console.WriteLine();

// Afdeling eenAfdeling = new Afdeling
// {
//     Naam = "Verzending",
//     Verdieping = 0
// };

// personeel.Add(eenAfdeling);
// foreach (Werknemer personeelslid in personeel)
//     Console.WriteLine(personeelslid.Naam);

// Werknemer[] wij = 
// [
//     new Arbeider("Asterix", new DateTime(2026, 1, 1), Geslacht.Man, 24.79m, 3),
//     new Bediende("Obelix", new DateTime(2026, 1, 1), Geslacht.Man, 2400.79m),
//     new Manager("Idefix", new DateTime(2026, 1, 1), Geslacht.Man, 2400.79m, 7000m)        
// ];

// WerknemersLijst lijst;
// lijst = Werknemer.UitgebreideWerknemersLijst;
// Console.WriteLine(lijst(wij));
// Console.WriteLine();

// lijst = Werknemer.KorteWerknemersLijst;
// Console.WriteLine(lijst(wij));

// Fotokopiemachine machine1 = new Fotokopiemachine ( "123" , 0, 2.0m);
// Fotokopiemachine machine2 = new Fotokopiemachine ( "456" , 0, 2.5m);
// Bediende eenBediende = new Bediende ( "Asterix" , DateTime .Today, Geslacht .Man, 2400.79m);
// Manager eenManager = new Manager ( "Idefix" , DateTime .Today, Geslacht .Man, 4800.4m, 2000m);
// machine1.OnderhoudNodig += eenBediende.DoeOnderhoud;
// machine1.OnderhoudNodig += eenManager.OnderhoudNoteren;
// machine2.OnderhoudNodig += eenBediende.DoeOnderhoud;
// machine2.OnderhoudNodig += eenManager.OnderhoudNoteren;
// machine1.Fotokopieer(49);
// machine2.Fotokopieer(14);

// Kwadraat kwadraat = getal => getal * getal;
// Console.WriteLine(kwadraat(5));
// Console.WriteLine(kwadraat(10));

// FunctieMetTweeParameters som = (getal1, getal2) => getal1 + getal2;
// Console.WriteLine(som(3, 7));
// Console.WriteLine(som(10,6));

// FunctieMetEenParameter omgekeerdeTekst = tekst => new string(tekst.Reverse().ToArray());
// Console.WriteLine(omgekeerdeTekst("C# is leuk"));

// FucntieZonderParameters willekeurigeGetal = () => new Random().Next(10);
// Console.WriteLine(willekeurigeGetal());

// int[] getallen = [ 1, 2, 3, 4, 5, 6, 7, 8, 9 ];
// Filter evenFilter = getal => getal % 2 == 0;
// Console.WriteLine("Even getallen:");
// ToonGetallen(getallen, evenFilter);

// Console.WriteLine("Oneven getallen:");
// ToonGetallen(getallen, getal => getal % 2 == 1);

// static void ToonGetallen(int[] getallen, Filter filter)
// {
//     foreach (int getal in getallen)
//     {
//         if (filter(getal))
//             Console.WriteLine(getal);
//     }
// }

// Console.WriteLine();

// Action<int> kwadraat1 = getal => Console.WriteLine(getal * getal);
// kwadraat(10);

// Action<string, int> tekstDeel = (tekst, vanaf) => Console.WriteLine(tekst.Substring(vanaf));
// tekstDeel("VDAB", 2);

int[] getallen = [-5, -3, -1, 0, 1, 3, 5];

Console.WriteLine("Even getallen:");
Filter evenFilter = getal => getal % 2 == 0;
Console.ForegroundColor = ConsoleColor.Green;
ToonGetallen(getallen, evenFilter);

Console.WriteLine("Oneven getallen:");
Filter onevenFilter = getal => getal % 2 != 0;
Console.ForegroundColor = ConsoleColor.Red;
ToonGetallen(getallen, onevenFilter);

Console.WriteLine("Positieve getallen:");
Filter positieveFilter = getal => getal > 0;
Console.ForegroundColor = ConsoleColor.Blue;
ToonGetallen(getallen, positieveFilter);

Console.WriteLine("Negatieve getallen:");
Filter negatieveFilter = getal => getal < 0;
Console.ForegroundColor = ConsoleColor.Yellow;
ToonGetallen(getallen, negatieveFilter);

Console.ResetColor();

static void ToonGetallen(int[] getallen, Filter filter)
{
    foreach (int getal in getallen)
    {
        if (filter(getal))
            Console.WriteLine(getal);
    }
}

delegate bool Filter(int getal);