using System;

namespace _8ClassesEnObjectsMethods;

public class Rekening
{
    DateOnly EersteCreatie = new DateOnly(1900, 1, 1);
    public decimal Saldo { get; set; }
    private DateOnly creatiedatum;
    public DateOnly Creatiedatum
    {
        get { return creatiedatum; }
        set { if (value >= EersteCreatie) creatiedatum = value; }
    }
    private string rekeningnummer;
    public string Rekeningnummer
    {
        get { return rekeningnummer; }
        set { if (IsGeldigRekeningNummer(value)) rekeningnummer = value; }
    }
    public string GetInfo()
    {
        return $"Rekeningnummer: {rekeningnummer}\n" +
            $"Saldo: {Saldo}\n" +
            $"Creatie Datum: {creatiedatum}";
    }
    public void Storten(decimal bedrag)
    {
        Saldo += bedrag;
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
}
