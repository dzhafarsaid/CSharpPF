using System;

namespace _20ClassesEnObjects.model;

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
        set { if (value != string.Empty) naam = value; }
    }

    public Geslacht Geslacht { get; set; }
    public DateTime InDienst { get; set;}
}
