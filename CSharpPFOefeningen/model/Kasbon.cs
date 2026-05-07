using System;

namespace CSharpPFOefeningen.model;

public class Kasbon : ISpaarmiddel
{
    private readonly DateOnly EersteAankoop = new(1900,1,1);
    private DateOnly aankoopDatum;
    public DateOnly AankoopDatum
    {
        get { return aankoopDatum; }
        set { if (value >= EersteAankoop ) aankoopDatum = value; }
    }
    private decimal bedrag;
    public decimal Bedrag
    {
        get { return bedrag; }
        set { if (value > 0) bedrag = value; }
    }
    
    private int looptijd;
    public int Looptijd
    {
        get { return looptijd; }
        set { if (value > 0) looptijd = value; }
    }

    private decimal intrest;
    public decimal Intrest
    {
        get { return intrest; }
        set { if (value > 0) intrest = value; }
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
}
