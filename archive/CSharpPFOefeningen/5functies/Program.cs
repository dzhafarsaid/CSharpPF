int LeesCijfer(string subject)
{
    Console.WriteLine($"Geef een cijfer voor {subject} tussen 1 en 10:");
    bool valid = int.TryParse(Console.ReadLine(), out int punten);

    while (!valid || punten < 1 || punten > 10)
    {
        Console.WriteLine($"Geef een cijfer voor {subject} tussen 1 en 10:");
        valid = int.TryParse(Console.ReadLine(), out punten);
    }
    return punten;
}

bool geslaagd(int punten)
{
    return punten >= 5 && punten <= 10;
}

int percentage(int punten)
{
    return punten * 10;
}

string resultaat(int wiskunde, int boekhouden, int informatica)
{
    int totaal = (wiskunde + boekhouden + informatica) / 3;
    switch (totaal)
    {
        case >= 50 and < 68:
            return "voldoende";
        case >= 68 and < 77:
            return "onderscheiding";
        case >= 77 and < 85:
            return "grote onderscheiding";
        case >= 85:
            return "grootste onderscheiding";
        default :
        return "onvoldoende";

    }
}

int wiskunde = LeesCijfer("Wiskunde");
int boekhouden = LeesCijfer("Boekhouden");
int informatica = LeesCijfer("Informatica");

if (!geslaagd(wiskunde) || !geslaagd(boekhouden) || !geslaagd(informatica))
{
    Console.WriteLine("Deze student is niet voor alle vakken geslaagd" +
"en behaalde een onvoldoende.");
}
else
{
    int wiskundePer = percentage(wiskunde);
    int boekhoudenPer = percentage(boekhouden);
    int informaticaPer = percentage(informatica);
    Console.WriteLine(resultaat(wiskundePer, boekhoudenPer, informaticaPer));
}

