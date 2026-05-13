using System;

namespace BoekBoekenrek.model;

public class Boekenrek : IVoorwerpen
{
    public Boekenrek(decimal hoogte, decimal breedte, decimal aankoopprijs)
    {
        Hoogte = hoogte;
        Breedte = breedte;
        Aankoopprijs = aankoopprijs;
    }
    public decimal Hoogte { get; set; }
    public decimal Breedte { get; set; }
    public decimal Aankoopprijs { get; set; }
    public decimal Winst
    {
        get
        {
            return Aankoopprijs * 2m;
        }
    }

    public string GegevensTonen()
    {
        return $"Boekenrek\n" +
           $"---------\n" +
           $"Breedte: {Breedte}\n" +
           $"Hoogte: {Hoogte}\n" +
           $"Aankoopprijs: {Aankoopprijs} euro\n" +
           $"Winst: {Winst} euro";
    }
}
