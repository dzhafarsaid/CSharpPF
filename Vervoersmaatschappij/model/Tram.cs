using System;

namespace Vervoersmaatschappij.model;

public class Tram: Voertuig
{
    public Tram(string merk, string model, int bouwjaar, int kilometerstand, Brandstof brandstof, int lijnNummer)
    : base(merk, model, bouwjaar, kilometerstand, brandstof)
    {
        LijnNummer = LijnNummer;
    }

    public int LijnNummer { get; set; }

    public override decimal Operationelekosten
    {
        get
        {
            return Kilometerstand * 0.03m + 100m;
        }
    }

    public override string InfoTonen()
    {
        return $"Tram\n---\nMerk: {Merk}\nModel: {Model}\nOperationele kosten: {Operationelekosten}";
    }
}
