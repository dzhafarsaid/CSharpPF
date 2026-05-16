using System;

namespace CSharpPFOefeningen.model;

public class Klant
{
    public Klant(string voornaam, string familienaam)
    {
        Voornaam = voornaam;
        Familienaam = familienaam;
    }
    public string Voornaam { get; set; }
    public string Familienaam { get; set;}
    public string GetKlantInfo()
    {
        return $"Voornaam: {Voornaam}\n" +
            $"Familienaam: {Familienaam}";
    }
}
