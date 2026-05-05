using System;

namespace _7ClassesEnObjects.model;

public class Rekening
{
    public string Rekeningnummer { get; set; }
    public decimal Saldo { get; set; }
    private DateOnly creatiedatum;
    public DateOnly Creatiedatum
    {
        get { return creatiedatum; }
        set { if (value >= new DateOnly(1900, 1, 1)) creatiedatum = value; }
    }

}