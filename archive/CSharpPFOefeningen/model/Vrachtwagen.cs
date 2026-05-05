using System;

namespace RekeningVoetuig.model;

public class Vrachtwagen : Voertuig
{
    public Vrachtwagen(string polishouder, string nummerplaat = "onbepaald",
        decimal kostprijs = 0, int pk = 0, float gemiddeldVerbruik = 0f, float maximumLading = 0f)
        : base(polishouder, nummerplaat, kostprijs, pk, gemiddeldVerbruik)
    {
        MaximumLading = maximumLading;
    }

    private float maximumLading;

    public float MaximumLading
    {
        get { return maximumLading; }
        set { if (value >= 0) maximumLading = value; }
    }

    public override string GetVoertuigInfo()
    {
        return $"{base.GetVoertuigInfo()}\n" +
               $"MaxLading: {MaximumLading}";
    }
    public override double GetKyotoScore()
    {
        if (MaximumLading == 0) return 0;
        return (GemiddeldVerbruik * Pk) / maximumLading;
    }
}

public class Personenwagen : Voertuig
{
    public Personenwagen(string polishouder, string nummerplaat = "onbepaald",
        decimal kostprijs = 0, int pk = 0, float gemiddeldVerbruik = 0f,
        int aantalDeuren = 4, int aantalPassagiers = 5)
        : base(polishouder, nummerplaat, kostprijs, pk, gemiddeldVerbruik)
    {
        AantalDeuren = aantalDeuren;
        AantalPassagiers = aantalPassagiers;
    }

    private int aantalDeuren;
    private int aantalPassagiers;

    public int AantalDeuren
    {
        get => aantalDeuren;
        set { if (value >= 0) aantalDeuren = value; }
    }

    public int AantalPassagiers
    {
        get { return aantalPassagiers; }
        set { if (value >= 0) aantalPassagiers = value; }
    }

    public override string GetVoertuigInfo()
    {
        return $"{base.GetVoertuigInfo()}\n" +
               $"AantalDeuren: {AantalDeuren}\n" +
               $"AantalPassagiers: {AantalPassagiers}";
    }
        public override double GetKyotoScore()
    {
        if (AantalPassagiers == 0) return 0;
        return (GemiddeldVerbruik * Pk) / aantalPassagiers;
    }
}