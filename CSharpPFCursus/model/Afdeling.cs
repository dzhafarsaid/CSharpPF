using System;

namespace Firma.Personeel;

public class Afdeling
{
    private const int Verdiepingen = 10;
    public Afdeling() { }
    public Afdeling(string naam, int verdieping)
    {
        Naam = naam;
        Verdieping = verdieping;
    }
    public string Naam { get; set; }
    private int verdieping;
    public int Verdieping   
    {
        get { return verdieping; }
        set { if (value >=0 && value <= Verdiepingen) verdieping = value; }
    }
    public override string ToString()
    {
        return $"Afdeling: {Naam} op verdieping {Verdieping}";
    }
}
