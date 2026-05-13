using System;

namespace Vervoersmaatschappij.model;

public class Bus : Voertuig
{
    public Bus(string merk, string model, int bouwjaar, int kilometerstand, Brandstof brandstof, int aantalZitplaatsen)
        : base(merk, model, bouwjaar, kilometerstand, brandstof)
    {
        AantalZitplaatsen = aantalZitplaatsen;
    }

    public int AantalZitplaatsen { get; set; }

    public override decimal Operationelekosten
    {
        get
        {
            return Kilometerstand * 0.05m + Brandstof.PrijsPerLiter * 50m;
        }
    }

    public override string InfoTonen()
    {
        return $"Bus\n---\nMerk: {Merk}\nModel: {Model}\nOperationele kosten: {Operationelekosten}";
    }
}
