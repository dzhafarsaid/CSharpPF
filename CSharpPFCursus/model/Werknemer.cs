using System;

namespace CSharpPFCursus.model;

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

// ══════════════════════════════════════════════════════
//  DERIVED CLASS — Bediende
// ══════════════════════════════════════════════════════

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

// ══════════════════════════════════════════════════════
//  DERIVED CLASS — Manager  (extends Bediende)
// ══════════════════════════════════════════════════════

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

