using System;

namespace CSharpPFOefeningen.model;

public abstract class Voertuig : IVervuiler, IPrivaat, IMilieu
{
    public Voertuig(string polishouder, string nummerplaat = "onbepaald", 
        decimal kostprijs=0,int pk = 0, float gemiddeldVerbruik = 0f)
    {
        this.Polishouder = polishouder;
        this.Nummerplaat = nummerplaat;
        this.kostprijs = kostprijs;
        this.gemiddeldVerbruik = gemiddeldVerbruik;
        this.pk = pk;
    }
    public string Polishouder {get; init;}
    
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

    public virtual string GetVoertuigInfo()
    {
        return $"Polishouder: {Polishouder}\n"+
            $"Kostprijs: {kostprijs}\n"+
            $"PK: {pk}\n"+
            $"Gemiddelde Verbruik: {gemiddeldVerbruik}\n"+
            $"Nummerplaat: {Nummerplaat}\n";
    }
    public abstract double GetKyotoScore();
    public abstract double GeefVervuiling();

    public string GeefPrivateData()
    {
        return $"Polishouder: {Polishouder}\n" +
            $"Nummerplaat: {Nummerplaat}";
    }

    public string GeefMilieuData()
    {
        return $"PK: {pk}\n"+
            $"Kostprijs: {kostprijs}\n"+
            $"Gemiddelde Verbruik: {gemiddeldVerbruik}\n";
    }
}

