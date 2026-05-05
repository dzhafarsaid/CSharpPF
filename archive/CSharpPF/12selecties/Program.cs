int leeftijd = int.Parse("1");
Console.WriteLine("Je bent");
if (leeftijd < 18)
    Console.WriteLine(" niet");
Console.WriteLine(" toegelaten");
Console.WriteLine();
if (leeftijd < 18)
{
    Console.WriteLine("Je bent niet toegelaten.");
    Console.WriteLine("Kom later terug");
}
Console.WriteLine("Dag");
Console.WriteLine();
int getal = int.Parse("4");
string bericht = string.Empty;
switch (getal)
{
    case < 0:
        bericht = "negatief";
        break;
    case 0:
        bericht = "nul";
        break;
    case < 10 and <=50 :
        bericht = "een getal tussen 10 en 50";
        break;
    case > 50 and <= 100:
        bericht = "neen getal tussen 50 en 100";
        break;
}
Console.WriteLine($"Het getal is {bericht}.");