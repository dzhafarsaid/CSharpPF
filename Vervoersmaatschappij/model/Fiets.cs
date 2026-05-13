using System;

namespace Vervoersmaatschappij.model;

public class Fiets:IVoertuig
{
    public Fiets(string merk, string type, decimal aankoopprijs)
    {
        Merk = merk;
        Type = type;
        Aankoopprijs = aankoopprijs;
    }
    public string Merk { get; set; }
    public string Type { get; set; }

    public decimal Aankoopprijs {get; set;}

    public decimal Operationelekosten
    {
        get
        {
            return Aankoopprijs * 0.01m;
        }
    }

    public string InfoTonen()
    {
        return $"Fiets\n---\nMerk: {Merk}\nType: {Type}\nOperationele kosten: {Operationelekosten}";
    }
}
