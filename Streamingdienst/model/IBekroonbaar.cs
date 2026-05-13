using System;

namespace Streamingdienst.model;

public interface IBekroonbaar
{
    public string PrijsToekennen(string prijsNaam);
    public List<string> GewonnenPrijzen {get;}
}
