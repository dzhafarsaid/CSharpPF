using System;

namespace CSharpPFOefeningen.model;

public class Kasbon : ISpaarmiddel
{
    private readonly DateOnly EersteAankoop = new(1990, 1, 1);
    private DateOnly aankoopDatum;
    public DateOnly AankoopDatum
    {
        get { return aankoopDatum; }
        set
        {
            if (value < EersteAankoop)
                throw new VerkeerdeDatum("Datum moet na 1-1-1990 zijn", value);
            aankoopDatum = value;
        }
    }
    private decimal bedrag;
    public decimal Bedrag
    {
        get { return bedrag; }
        set
        {
            if (value < 0)
                throw new FoutBedrag("Bedrag moet positief zijn", value);
            bedrag = value;
        }
    }

    private int looptijd;
    public int Looptijd
    {
        get { return looptijd; }
        set
        {
            if (value < 0)
                throw new FoutLooptijd("Looptijd moet positief zijn", value);
            looptijd = value;
        }
    }

    private decimal intrest;
    public decimal Intrest
    {
        get { return intrest; }
        set
        {
            if (value < 0)
                throw new FoutIntrest("Intrest moet positief zijn", value);
            intrest = value;
        }
    }

    public Klant Eigenaar { get; set; }

    public Kasbon(DateOnly aankoopDatum, decimal bedrag, int looptijd, decimal intrest, Klant eigenaar)
    {
        AankoopDatum = aankoopDatum;
        Bedrag = bedrag;
        Looptijd = looptijd;
        Intrest = intrest;
        Eigenaar = eigenaar;
    }

    public string GetInfo()
    {
        string eigenaar = Eigenaar?.GetKlantInfo() ?? "onbekend";
        return $"Eigenaar: {eigenaar}\n" +
            $"AankoopDatum: {aankoopDatum}\n" +
            $"Bedrag: {bedrag}\n" +
            $"Looptijd: {Looptijd}\n" +
            $"Intrest: {intrest}\n";
    }

    //Exeption classes

    public class FoutIntrest : Exception
    {
        public decimal Intrest { get; set; }
        public FoutIntrest(string message, decimal intrest)
            : base(message)
        {
            Intrest = intrest;
        }
    }

    public class FoutLooptijd : Exception
    {
        public int Looptijd { get; set; }
        public FoutLooptijd(string message, int looptijd)
            : base(message)
        {
            Looptijd = looptijd;
        }
    }

    public class FoutBedrag : Exception
    {
        public decimal Bedrag { get; set; }
        public FoutBedrag(string message, decimal bedrag)
            : base(message)
        {
            Bedrag = bedrag;
        }
    }

    public class VerkeerdeDatum : Exception
    {
        public DateOnly AankoopDatum { get; set; }
        public VerkeerdeDatum(string message, DateOnly aankoopDatum)
            : base(message)
        {
            AankoopDatum = aankoopDatum;
        }
    }
}
