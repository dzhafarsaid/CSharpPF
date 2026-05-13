using Firma.Personeel;
using System;


namespace Firma.Personeel;

public class Bediende : Werknemer
{
    // ── Constructors ───────────────────────────────────
    public Bediende(string naam, DateTime indienst, Geslacht geslacht, decimal wedde)
        : base(naam, indienst, geslacht)
    {
        Wedde = wedde;
    }

    // ── Fields ─────────────────────────────────────────

    public override decimal Premie
    {
        get
        {
            return Wedde * 2m;
        }
    }
    private decimal wedde;

    // ── Properties ─────────────────────────────────────
    public decimal Wedde
    {
        get { return wedde; }
        set { if (value >= 0m) wedde = value; }
    }

    // ── Methods ────────────────────────────────────────
    public override string GetInfo()
    {
        return $"{base.GetInfo()}\n" +
               $"Wedde: {Wedde}";
    }

    public override string ToString()
    {
        return $"{base.ToString()} {Wedde} euro/maand";
    }

    public override decimal BerekenKostprijs()
    {
        return Wedde * 12m;
    }
}
