using System;

namespace _9ClassesEnObjectsConstructors.model;

public class Voertuig
{
    public Voertuig(string polishouder, string nummerplaat = "onbepaald", 
        decimal kostprijs=0,int pk = 0, float gemiddeldVerbruik = 0f)
    {
        this.PolisHouder = polishouder;
        this.Nummerplaat = nummerplaat;
        this.kostprijs = kostprijs;
        this.gemiddeldVerbruik = gemiddeldVerbruik;
    }
    private string polisHouder;
    public string PolisHouder
    {
        get { return polisHouder; }
        init { polisHouder = value; }
    }
    
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

