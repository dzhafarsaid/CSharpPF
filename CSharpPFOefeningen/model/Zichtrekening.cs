namespace CSharpPFOefeningen.model;

public class Zichtrekening : Rekening
{
    public Zichtrekening(string rekeningnummer, decimal saldo, DateOnly creatiedatum, decimal maxKrediet, Klant eigenaar)
        : base(rekeningnummer, saldo, creatiedatum, eigenaar)
    {
        MaxKrediet = maxKrediet;
    }
    private decimal maxKrediet;
    public decimal MaxKrediet
    {
        get { return maxKrediet; }
        set { if (value >= 0) maxKrediet = value; }
    }

    public override string GetInfo()
    {
        return $"{base.GetInfo()}\n" +
               $"Max Krediet: {MaxKrediet}";
    }
}

public class Spaarrekening : Rekening
{
    public Spaarrekening(string rekeningnummer, decimal saldo, DateOnly creatiedatum, Klant eigenaar)
        : base(rekeningnummer, saldo, creatiedatum, eigenaar)
    {
    }
    private static decimal intrest;
    public static decimal Intrest
    {
        get { return intrest; }
        set { if (value >= 0) intrest = value; }
    }
    public override string GetInfo()
    {
        return $"{base.GetInfo()}\n" +
               $"Intrest: {Intrest}";
    }
}