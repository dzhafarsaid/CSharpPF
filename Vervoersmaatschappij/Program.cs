

using Vervoersmaatschappij.model;

Brandstof type1 = new Brandstof(1.85m,"Diesel");
Brandstof type2 = new Brandstof(0m,"Elektrisch");
IVoertuig[] list = new IVoertuig[4];
list[0] = new Bus("Volvo", "7900", 2018, 250000, type1, 80);
list[1] = new Tram("Bombardier", "Flexity 2", 2020, 120000, type2, 7);
list[2] = new Bus("Mercedes", "Vito", 2015, 150000, type1, 30);
list[3] = new Fiets("Trek","Stadsfiets", 450);
foreach (IVoertuig item in list)
{
    Console.WriteLine(item.InfoTonen());
}