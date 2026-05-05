using System;

namespace _21Methods.model;

public enum Geslacht
{
    Man, Vrouw, X
}
public class Werknemer
{
    private string naam;
    public string Naam
    {
        get { return naam; }
        set
        {
            if (value != string.Empty) naam = value;
        }
    }
    public Geslacht Geslacht { get; set; }
    public DateTime InDienst { get; set; }

    public string GetInfo()
    {
        return $"Naam: {Naam}\n" +
            $"Geslacht: {Geslacht}\n" +
            $"In dienst: {InDienst}";
    }


}




















public class LijnenTrekker
{
    public void TekenLijn(int lengte, char teken = '-')
    {
        for (int i = 0; i < lengte; i++)
            Console.Write(teken);
        Console.WriteLine();
    }

    public void TekenLijn(int lengte)
    {
        TekenLijn(lengte, '-');
    }

    public void TekenLijn()
    {
        TekenLijn(79);
    }
}

public class Omzetter
{
    public const double CentimetersPerInch = 2.54;
    public double CmNaarInch(double cm)
    {
        return cm / CentimetersPerInch;
    }
    public double InchNaarCm(double inch)
    {
        return inch * CentimetersPerInch;
    }
}
public class Verwisselaar
{
    public void Verwissel(ref int getal1, ref int getal2)
    {
        int tussen = getal1;
        getal1 = getal2;
        getal2 = tussen;
    }
}
public class VerwisselNaarAndereVariabelen
{
    public void VerwisselNaarAndereVariabele(int getal1, int getal2,
out int verwisseld1, out int verwisseld2)
    {
        verwisseld1 = getal2;
        verwisseld2 = getal1;
    }
}