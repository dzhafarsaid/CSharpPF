using System;

namespace BoekBoekenrek.model;

public class Leesboek : Boek
{
    public Leesboek(string titel, string auteur, decimal aankooprijs, Genre genre, string onderwerp) :
    base(titel, auteur, aankooprijs, genre)
    {
        Onderwerp = onderwerp;
    }
    public string Onderwerp { get; set; }

    public override decimal Winst
    {
        get
        {
            return Aankoopprijs * 1.5m;
        }
    }
    public override string GegevensTonen()
    {
        return $"Leesboek\n" +
                   $"--------\n" +
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
                   $"Onderwerp: {Onderwerp}";
    }
}
