using System;

namespace RekeningVoetuig.model;

public class Zichtrekening : Rekening
{
    public Zichtrekening(string rekeningnummer, decimal saldo, DateOnly creatiedatum, decimal maxKrediet)
        : base(rekeningnummer, saldo, creatiedatum)
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
    public Spaarrekening(string rekeningnummer, decimal saldo, DateOnly creatiedatum)
        : base(rekeningnummer, saldo, creatiedatum)
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