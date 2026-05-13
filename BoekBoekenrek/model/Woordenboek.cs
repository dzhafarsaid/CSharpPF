using System;

namespace BoekBoekenrek.model;

public class Woordenboek : Boek
{
    public Woordenboek(string titel, string auteur, decimal aankooprijs, Genre genre, string taal)
        : base(titel, auteur, aankooprijs, genre)
    {
        Taal = taal;
    }
    public string Taal { get; set; }

    public override decimal Winst
    {
        get
        {
            return Aankoopprijs * 1.75m;
        }
    }

    public override string GegevensTonen()
    {
        return $"Woordenboek\n" +
           $"-----------\n" +
           $"Titel: {Titel}\n" +
           $"Auteur: {Auteur}\n" +
           $"Eigenaar: {Eigenaar}\n" +
           $"Prijs: {Aankoopprijs} euro\n" +
           $"Winst: {Winst} euro\n" +
           $"Genregegevens:\n" +
           $"  Genrenaam: {Genre.Naam}\n" +
           $"Doelgroepgegevens:\n" +
           $"  Leeftijd: {Genre.Doelgroep.Leeftijd}\n" +
           $"  Categorie: {Genre.Doelgroep.Categorie}\n" +
           $"Taal: {Taal}";
    }
}
