using System;

namespace Vervoersmaatschappij.model;

public abstract class Voertuig : IVoertuig
{
    public Voertuig(string merk, string model, int bouwjaar, int kilometerstand, Brandstof brandstof)
    {
        Merk = merk;
        Model = model;
        Bouwjaar = bouwjaar;
        Kilometerstand = kilometerstand;
        Brandstof = brandstof;
    }
    public string Merk { get; set; }
    public string Model { get; set; }
    public int Bouwjaar { get; set; }
    public int Kilometerstand { get; set; }
    public Brandstof Brandstof { get; set; }
    public string Bedrijf { get; } = "De Lijn";

    public virtual decimal Operationelekosten { get; }

    public abstract string InfoTonen();

}
