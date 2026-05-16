using System;

namespace CSharpPFCursus.model;

public class ProvincieInfo
{
    public int ProvincieGrootte(string provincieNaam)
    {
        StreamReader lezer = new StreamReader(
        @"/Users/dzhafarsaid/Documents/DOTNET10/C# VS2026 DOTNET10 PF Cursus (2)/provincies.txt");
        int oppervlakte = -1;
        string? regel;
        while ((regel = lezer.ReadLine()) != null)
        {
            int dubbelPuntPos = regel.IndexOf(':');
            string provincie = regel.Substring(0, dubbelPuntPos);
            if (provincie == provincieNaam)
                oppervlakte = int.Parse(regel.Substring(dubbelPuntPos + 1));
        }
        lezer.Close();
        if (oppervlakte == -1)
            throw new Exception("Onbestaande provincie: " + provincieNaam);
        else
            return oppervlakte;
    }
}
