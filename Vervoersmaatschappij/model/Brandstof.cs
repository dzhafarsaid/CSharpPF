using System;

namespace Vervoersmaatschappij.model;

public class Brandstof
{
    public Brandstof(decimal prijsPerLiter, string type)
    {
        PrijsPerLiter = prijsPerLiter;
        Type = type;
    }
    private decimal prijsPerLiter;

    public string Type { get; set; }
    public decimal PrijsPerLiter { get; set; }

    public Verbruikscategorie Verbruikscategorie
    {
        get
        {
            switch (PrijsPerLiter)
            {
                case decimal p when p < 1.5m:
                    return Verbruikscategorie.Laag;
                case decimal p when p <= 2.5m:
                    return Verbruikscategorie.Gemiddeld;
                default:
                    return Verbruikscategorie.Hoog;

            }
        }
    }
}
