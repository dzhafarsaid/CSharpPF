using System;

namespace CSharpPFOefeningen.model;

public class Bank
{
    public string BankId { get; set; }
    public string Naam { get; set; }

    public void ToonRekeningUittreksel(Rekening rekening)
    {
        Console.WriteLine($"Datum: {DateOnly.FromDateTime(DateTime.Today)}");
        Console.WriteLine($"Rekeningnummer: {rekening.Rekeningnummer}");
        Console.WriteLine($"Nieuw saldo: {rekening.Saldo:C}");
    }

    public void ToonSaldoFout(Rekening rekening)
    {
        Console.WriteLine($"Transactie mislukt. Maximum af te halen bedrag: {rekening.Saldo:C}");
    }
}