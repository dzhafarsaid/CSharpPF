using System;

namespace CSharpPFOefeningen.model;

public class Klant
{
    public required string Voornaam { get; set; }
    public required string Familienaam { get; set;}
    public string GetKlantInfo()
    {
        return $"Voornaam: {Voornaam}\n" +
            $"Familienaam: {Familienaam}";
    }
}
