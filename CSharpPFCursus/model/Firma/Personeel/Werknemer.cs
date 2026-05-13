using System;

namespace Firma.Personeel;

public abstract partial class Werknemer : IKost
{
    // ── Constructors ───────────────────────────────────
    static Werknemer()
    {
        Personeelsfeest = new DateOnly(DateTime.Today.Year, 2, 1);
        while (Personeelsfeest.DayOfWeek != DayOfWeek.Friday)
            Personeelsfeest = Personeelsfeest.AddDays(1);
    }
    //Default constructor
    public Werknemer()
    {
        this.Naam = "Onbekend";
        this.InDienst = DateTime.Today;
        this.Geslacht = Geslacht.Man;
    }

    public Werknemer(string naam, DateTime inDienst, Geslacht geslacht)
    {
        Naam = naam;
        InDienst = inDienst;
        Geslacht = geslacht;
    }
    
    // ── Fields ─────────────────────────────────────────
    private Afdeling afdeling;
    public Afdeling Afdeling
    {
        get { return afdeling; }
        set { afdeling = value; }
    }

    public abstract decimal Premie
    {
        get;
    }


    private string naam = "Onbekend";
    public static DateOnly personeelsfeest;

    public WerkRegime Regime { get; set; }

    // ── Properties ─────────────────────────────────────
    public string Naam
    {
        get { return naam; }
        set { if (value != string.Empty) naam = value; }
    }

    public Geslacht Geslacht { get; set; }
    public DateTime InDienst { get; set; }

    public static DateOnly Personeelsfeest
    {
        get { return personeelsfeest; }
        set { personeelsfeest = value; }
    }

    public bool Menselijk
    {
        get { return true;}    
    }
    // ── Methods ────────────────────────────────────────
    public virtual string GetInfo()
    {
        return $"Naam: {Naam}\n" +
               $"Geslacht: {Geslacht}\n" +
               $"In dienst: {InDienst}\n" +
               $"Personeelsfeest: {Personeelsfeest}\n" +
               $"{(Afdeling is not null? Afdeling.ToString() : "Onbekende afdeling")}";
    }

    public override string ToString()
    {
        return $"{Naam} {Geslacht}";
    }

    public abstract decimal BerekenKostprijs();
}

// ══════════════════════════════════════════════════════
//  UTILITY CLASS
// ══════════════════════════════════════════════════════

public static class Rekenaar
{
    public static int Kwadraat(int getal) { return getal * getal; }
}

// ══════════════════════════════════════════════════════
//  DERIVED CLASS — Arbeider
// ══════════════════════════════════════════════════════

public class Arbeider : Werknemer
{
    // ── Constructors ───────────────────────────────────
    public Arbeider(string naam, DateTime indienst, Geslacht geslacht, decimal uurloon, byte ploegenstelsel)
        : base(naam, indienst, geslacht)
    {
        Uurloon = uurloon;
        Ploegenstelsel = ploegenstelsel;
    }

    // ── Fields ─────────────────────────────────────────
    private decimal uurloon;
    private byte ploegenstelsel;

    public override decimal Premie
    {
        get
        {
            return Uurloon * 150m;
        }
    }

    // ── Properties ─────────────────────────────────────
    public decimal Uurloon
    {
        get { return uurloon; }
        set { if (value >= 0m) uurloon = value; }
    }

    public byte Ploegenstelsel
    {
        get { return ploegenstelsel; }
        set { if (value >= 1 && value <= 3) ploegenstelsel = value; }
    }

    // ── Methods ────────────────────────────────────────
    public override string GetInfo()
    {
        return $"{base.GetInfo()}\n" +
               $"Uurloon: {Uurloon}\n" +
               $"Ploegenstelsel: {Ploegenstelsel}";
    }

    public override string ToString()
    {
        return $"{base.ToString()} {Uurloon} euro/uur";
    }

    public override decimal BerekenKostprijs()
    {
        return Uurloon * 2000m;
    }
}
