using System;

namespace Streamingdienst.model;

public class Podcast : Content, IDownloadbaar
{
    public Podcast(string titel, int releasejaar, int minimumLeeftijd, Genre genre, string host, int duurInMinuten)
: base(titel, releasejaar, minimumLeeftijd, genre)
    {
        Host = host;
        DuurInMinuten = duurInMinuten;
    }
    public string Host { get; set; }
    public int DuurInMinuten { get; set; }

    public decimal BestandsgrootteInGB
    {
        get
        {
            return DuurInMinuten * 0.005m;
        }
    }

    public override string InfoTonen()
    {
        return $"Titel: {Titel}\n" +
            $"Release Jaar: {Releasejaar}\n" +
            $"Minimum Leeftijd: {MinimumLeeftijd}\n" +
            $"Leeftijds Categorie: {leeftijdsCategorie}\n" +
            $"Genre: {this.genre}\n" +
            $"Platform: {Platform}\n" +
            $"Host: {Host}\n" +
            $"Duur in Minuten: {DuurInMinuten} min\n" +
            $"Bestands grootte in GB: {BestandsgrootteInGB}\n";
    }

    public string Downloaden()
    {
        return $"Downloaden van {Titel}, grotte: {BestandsgrootteInGB} GB";
    }
}
