using System;

namespace BoekBoekenrek.model;

public class Doelgroep
{
    public int Leeftijd { get; set; }
    public Categorie Categorie
    {
        get
        {
            if (Leeftijd < 18)
            {
                return Categorie.Jeugd;
            }
            return Categorie.Volwassen;
        }
    }
}
