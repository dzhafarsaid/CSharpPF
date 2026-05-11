using Firma.Personeel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Firma.Personeel;

public class Manager : Bediende
{
    // ── Constructors ───────────────────────────────────
    public Manager(string naam, DateTime indienst, Geslacht geslacht, decimal wedde, decimal bonus)
        : base(naam, indienst, geslacht, wedde)
    {
        Bonus = bonus;
    }

    // ── Fields ─────────────────────────────────────────
    public override decimal Premie
    {
        get
        {
            return bonus * 3m;
        }
    }

    private decimal bonus;

    // ── Properties ─────────────────────────────────────
    public decimal Bonus
    {
        get { return bonus; }
        set { if (value > 0m) bonus = value; }
    }

    // ── Methods ────────────────────────────────────────
    public override string GetInfo()
    {
        return $"{base.GetInfo()}\n" +
               $"Bonus: {Bonus}";
    }

    public override string ToString()
    {
        return $"{base.ToString()} - Bonus: {Bonus}";
    }

    public override decimal BerekenKostprijs()
    {
        return base.BerekenKostprijs() + Bonus;
    }
}
