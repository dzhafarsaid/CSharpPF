using System;

namespace Streamingdienst.model;

public abstract class Content
{
    public Content(string titel, int releasejaar, int minimumLeeftijd, Genre genre)
    {
        Titel = titel;
        Releasejaar = releasejaar;
        MinimumLeeftijd = minimumLeeftijd;
        this.genre = genre;
    }
    public string Titel { get; set; }
    public int Releasejaar { get; set; }
    public int MinimumLeeftijd { get; set; }
    public string Platform {get;} = "FlixHub";
    public Genre genre {get; set;}
    public LeeftijdsCategorie leeftijdsCategorie {get
        {
            if (MinimumLeeftijd <= 6)
            {
                return LeeftijdsCategorie.AlleLeeftijden;
            } else if (MinimumLeeftijd >=7 && MinimumLeeftijd <= 15)
            {
                return LeeftijdsCategorie.Tieners;
            } else return LeeftijdsCategorie.Volwassen;
        }
    }
    public abstract string InfoTonen();
}
