using System;

namespace CSharpPFOefeningen.model;

public delegate void Bankbericht(Rekening rekening);
public abstract class Rekening : ISpaarmiddel
{
    public event Bankbericht? RekeningUittreksel;
    public event Bankbericht? SaldoInHetRood;
    public Rekening(string rekeningnummer, decimal saldo, DateOnly creatiedatum, Klant eigenaar)
    {
        Saldo = saldo;
        Creatiedatum = creatiedatum;
        Rekeningnummer = rekeningnummer;
        Eigenaar = eigenaar;
    }

    private Klant eigenaar;
    public Klant Eigenaar
    {
        get { return eigenaar; }
        set { eigenaar = value; }
    }

    DateOnly EersteCreatie = new DateOnly(1900, 1, 1);
    public decimal Saldo { get; set; }
    private DateOnly creatiedatum;
    public DateOnly Creatiedatum
    {
        get { return creatiedatum; }
        set
        {
            if (value < EersteCreatie)
                throw new VerkeerdeDatum("Creatiedatum mag niet voor 1-1-1990 zijn.", value);
            creatiedatum = value;
        }
    }
    private string rekeningnummer;
    public string Rekeningnummer
    {
        get { return rekeningnummer; }
        init
        {
            if (!IsGeldigRekeningNummer(value))
                throw new OngeldigRekeningnummer("Ongeldig rekeningnummer: " + value, value);
            rekeningnummer = value;
        }
    }
    public virtual string GetInfo()
    {
        return $"Rekeningnummer: {rekeningnummer}\n" +
            $"Eigenaar:{Eigenaar.GetKlantInfo()}\n" +
            $"Saldo: {Saldo}\n" +
            $"Creatie Datum: {creatiedatum}\n";
    }
    public void Storten(decimal bedrag)
    {
        Saldo += bedrag;
        RekeningUittreksel?.Invoke(this);
    }

    public void Afhalen(decimal bedrag)
    {
        if (bedrag > Saldo)
        {
            SaldoInHetRood?.Invoke(this);
        }
        else
        {
            Saldo -= bedrag;
            RekeningUittreksel?.Invoke(this);
        }

    }

    private bool IsGeldigRekeningNummer(string rekeningNummer)
    {
        if (string.IsNullOrWhiteSpace(rekeningNummer))
            return false;
        if (rekeningNummer.Length != 16)
            return false;
        if (!rekeningNummer.StartsWith("BE"))
            return false;
        if (!int.TryParse(rekeningNummer.Substring(2, 2), out int n))
            return false;
        if (!ulong.TryParse(rekeningNummer.Substring(4, 12), out ulong belgischRekeningNummer))
            return false;
        ulong eerste10 = belgischRekeningNummer / 100ul;
        int laatste2 = (int)(belgischRekeningNummer % 100ul);
        return (int)(eerste10 % 97ul) == laatste2;
    }

    public class OngeldigRekeningnummer : Exception
    {
        public string RekeningNummer { get; set; }
        public OngeldigRekeningnummer(string message, string rekeningNummer)
            : base(message)
        {
            RekeningNummer = rekeningNummer;
        }
    }

    public class VerkeerdeDatum : Exception
    {
        public DateOnly CreatieDatum { get; set; }
        public VerkeerdeDatum(string message, DateOnly creatieDatum)
            : base(message)
        {
            CreatieDatum = creatieDatum;
        }
    }
}
