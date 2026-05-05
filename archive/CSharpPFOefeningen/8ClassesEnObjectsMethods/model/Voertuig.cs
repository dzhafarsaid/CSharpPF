using System;

namespace _8ClassesEnObjectsMethods;

public class Voertuig
{
    public string PolisHouder { get; set; }
    private decimal kostprijs;
    public decimal Kostprijs
    {
        get => kostprijs;
        set
        {
            if (value >= 0m) kostprijs = value;
        }
    }
    private int pk;
    public int Pk
    {
        get => pk;
        set
        {
            if (value >= 0) pk = value;
        }
    }
    private float gemiddeldVerbruik;
    public float GemiddeldVerbruik
    {
        get => gemiddeldVerbruik;
        set
        {
            if (value >= 0) gemiddeldVerbruik = value;
        }
    }
    public string Nummerplaat { get; set; }

    public string GetVoertuigInfo()
    {
        return $"Polishouder: {PolisHouder}\n"+
            $"Kostprijs: {kostprijs}\n"+
            $"PK: {pk}\n"+
            $"Gemiddelde Verbruik: {gemiddeldVerbruik}\n"+
            $"Nummerplaat: {Nummerplaat}\n";
    }
}
