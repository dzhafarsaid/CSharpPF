using System;

namespace RekeningVoetuig.model;

public class Rekening2(string nummer, decimal saldo, DateOnly creatieDatum)
{
    // static toegevoegd
    private static readonly DateOnly EersteCreatie = new DateOnly(1900, 1, 1);

    public string Nummer { get; set; }
        = IsGeldigRekeningNummer(nummer) ? nummer : "ongeldig rekeningnummer";

    public decimal Saldo { get; set; } = saldo > 0m ? saldo : 0m;

    public DateOnly CreatieDatum { get; set; }
        = creatieDatum >= EersteCreatie ? creatieDatum : EersteCreatie;

    // static toegevoegd
    private static bool IsGeldigRekeningNummer(string rekeningNummer)
    {
        if (string.IsNullOrWhiteSpace(rekeningNummer))
            return false;

        if (rekeningNummer.Length != 16)
            return false;

        if (rekeningNummer[..2] != "BE")
            return false;

        if (!int.TryParse(rekeningNummer.Substring(2, 2),
            out int derdevierdeteken))
            return false;

        if (!ulong.TryParse(rekeningNummer.Substring(4, 12),
            out ulong belgischRekeningNummer))
            return false;

        ulong eerste10 = belgischRekeningNummer / 100ul;
        int laatste2 = (int)(belgischRekeningNummer % 100ul);

        return (int)(eerste10 % 97ul) == laatste2;
    }

    public string GetInfo()
    {
        return $"Rekeningnummer: {Nummer}\n" +
               $"Saldo: {Saldo}\n" +
               $"Creatiedatum: {CreatieDatum.ToShortDateString()}";
    }

    public void Storten(decimal bedrag)
    {
        Saldo += bedrag;
    }
}