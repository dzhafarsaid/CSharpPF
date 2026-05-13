using System;

namespace BoekBoekenrek.model;

public abstract class Boek : IVoorwerpen
{
    public Boek(string titel, string auteur, decimal aankoopprijs, Genre genre)
    {
        Titel = titel;
        Auteur = auteur;
        Aankoopprijs = aankoopprijs;
        Genre = genre;
    }
    public string Titel { get; set; }
    public string Auteur { get; set; }
    public static string Eigenaar { get; } = "VDAB";
    public decimal Aankoopprijs { get; set; }
    public Genre Genre { get; set; }

    public abstract decimal Winst { get; }
    public abstract string GegevensTonen();
}
