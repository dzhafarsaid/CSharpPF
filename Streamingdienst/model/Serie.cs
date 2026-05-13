using System;

namespace Streamingdienst.model;

public class Serie: Content, IBekroonbaar
{
        public Serie(string titel, int releasejaar, int minimumLeeftijd, Genre genre, int aantalSeizoenen, int aantalAfleveringen)
        :base(titel, releasejaar, minimumLeeftijd, genre)
    {
        AantalSeizoenen = aantalSeizoenen;
        AantalAfleveringen = aantalAfleveringen;
    }
    public int AantalSeizoenen { get; set; }
    public int AantalAfleveringen { get; set; }

    public List<string> GewonnenPrijzen {get;}

    public string PrijsToekennen(string prijsNaam)
    {
        return $"Inception heeft de {prijsNaam} gewonnen!";
    }
    public override string InfoTonen()
    {
        return $"Titel: {Titel}\n" +
            $"Release Jaar: {Releasejaar}\n" +
            $"Minimum Leeftijd: {MinimumLeeftijd}\n" +
            $"Leeftijds Categorie: {leeftijdsCategorie}\n" +
            $"Genre: {this.genre}\n" +
            $"Platform: {Platform}\n" +
            $"Aantal Seizoenen: {AantalSeizoenen}\n" +
            $"Aantal Afleveringen: {AantalAfleveringen}\n";
    }
}
