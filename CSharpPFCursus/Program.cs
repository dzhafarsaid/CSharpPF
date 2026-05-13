using MateriaalStatus = Firma.Materiaal.Status;
using PersoneelStatus = Firma.Personeel.Status;



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

MateriaalStatus statusBoorMachine = MateriaalStatus.Werkend;
PersoneelStatus statusChef = PersoneelStatus.HogerKader;
Console.WriteLine(statusBoorMachine);
Console.WriteLine(statusChef);