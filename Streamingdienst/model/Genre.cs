using System;

namespace Streamingdienst.model;

public class Genre
{
    public Genre(string naam, string beschrijving){
        Naam = naam;
        Beschrijving = beschrijving;
    }
    public string Naam { get; set; }
    public string Beschrijving { get; set; }
}
