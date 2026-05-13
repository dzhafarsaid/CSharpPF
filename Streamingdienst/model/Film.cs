using System;

namespace Streamingdienst.model;

public class Film : Content, IDownloadbaar, IBekroonbaar
{
    public Film(string titel, int releasejaar, int minimumLeeftijd, Genre genre, int duurInMinuten, string regisseur)
        :base(titel, releasejaar, minimumLeeftijd, genre)
    {
        DuurInMinuten = duurInMinuten;
        Regisseur = regisseur;
    }
    public int DuurInMinuten { get; set; }
    public string Regisseur { get; set; }
    public decimal BestandsgrootteInGB
    {
        get
        {
            return DuurInMinuten * 0.02m;
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
            $"Duur in Minuten: {DuurInMinuten}\n" +
            $"Regisseur: {Regisseur}\n" +
            $"Bestands grootte in GB: {BestandsgrootteInGB}\n";
    }
    public List<string> GewonnenPrijzen {get;}

    public string Downloaden()
    {
        return $"Downloaden van {Titel}, grotte: {BestandsgrootteInGB} GB";
    }

    public string PrijsToekennen(string prijsNaam)
    {
        return $"Inception heeft de {prijsNaam} gewonnen!";
    }
}
