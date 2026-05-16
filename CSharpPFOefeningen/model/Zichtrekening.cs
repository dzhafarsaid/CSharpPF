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
        set { if (value > 0) 
            throw new FoutMaxKrediet("Max Krediet moet positive zijn", value);
        maxKrediet = value; }
    }

    public override string GetInfo()
    {
        return $"{base.GetInfo()}\n" +
               $"Max Krediet: {MaxKrediet}";
    }

    public class FoutMaxKrediet : Exception
    {
        public decimal MaxKrediet { get; set; }
        public FoutMaxKrediet(string message, decimal maxKrediet)
            : base(message)
        {
            MaxKrediet = maxKrediet;
        }
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
        set { if (value < 0)
            throw new FoutIntrest("Intrest moet positieve zijn", value);
         intrest = value; }
    }
    public override string GetInfo()
    {
        return $"{base.GetInfo()}\n" +
               $"Intrest: {Intrest}";
    }

    public class FoutIntrest: Exception
    {
        public decimal Intrest { get; set; }
        public FoutIntrest(string message, decimal intrest)
            : base(message)
        {
            Intrest = intrest;
        }
    }
}